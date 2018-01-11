using System;
using System.ComponentModel;
using System.Text;
using System.Windows.Forms;

namespace WorkerThread
{
    public partial class frmWorker : Form
    {
        const int NUMBER_OF_PRIMES = 100;

        private BackgroundWorker myWorker1 = new BackgroundWorker();
        private BackgroundWorker myWorker2 = new BackgroundWorker();
        private BackgroundWorker myWorker3 = new BackgroundWorker();

        StringBuilder sb1 = new StringBuilder();
        StringBuilder sb2 = new StringBuilder();
        StringBuilder sb3 = new StringBuilder();

        readonly object _obj = new object();

        public frmWorker()
        {
            InitializeComponent();

            lblOne.Text = NUMBER_OF_PRIMES.ToString();
            lblTwo.Text = NUMBER_OF_PRIMES.ToString();
            lblThree.Text = NUMBER_OF_PRIMES.ToString();


            myWorker1.DoWork += new DoWorkEventHandler(myWorker_DoWork);
            myWorker2.DoWork += new DoWorkEventHandler(myWorker_DoWork);
            myWorker3.DoWork += new DoWorkEventHandler(myWorker_DoWork);

            myWorker1.RunWorkerCompleted += new RunWorkerCompletedEventHandler(myWorker_RunWorkerCompleted);
            myWorker2.RunWorkerCompleted += new RunWorkerCompletedEventHandler(myWorker_RunWorkerCompleted);
            myWorker3.RunWorkerCompleted += new RunWorkerCompletedEventHandler(myWorker_RunWorkerCompleted);
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            if (!myWorker1.IsBusy) myWorker1.RunWorkerAsync(sb1);
            if (!myWorker2.IsBusy) myWorker2.RunWorkerAsync(sb2);
            if (!myWorker3.IsBusy) myWorker3.RunWorkerAsync(sb2);
        }

        private void prime_num(long num, StringBuilder sb)
        {
            lock (_obj)
            {
                for (long i = 0; i <= num; i++)
                {
                    bool isPrime = true;
                    for (long j = 2; j < i; j++)
                    {
                        if (i % j == 0)
                        {
                            isPrime = false;
                            break;
                        }
                    }
                    if (isPrime)
                    {
                        sb.Append(i);
                        sb.Append(",");
                    }
                }
            }
        }        

        protected void myWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            if (myWorker1.Equals((BackgroundWorker)sender))
                prime_num(NUMBER_OF_PRIMES, sb1);
            else if (myWorker2.Equals((BackgroundWorker)sender))
                prime_num(NUMBER_OF_PRIMES, sb2);
            else if (myWorker3.Equals((BackgroundWorker)sender))
                prime_num(NUMBER_OF_PRIMES, sb3);
        }

        protected void myWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (myWorker1.Equals((BackgroundWorker)sender))
                lblOne.Text = sb1.Remove(sb1.Length-1, 1).ToString();
            else if(myWorker2.Equals((BackgroundWorker)sender))
                lblTwo.Text = sb2.Remove(sb2.Length - 1, 1).ToString();
            else if(myWorker3.Equals((BackgroundWorker)sender))
                lblThree.Text = sb3.Remove(sb3.Length - 1, 1).ToString();
        }
    }
}
