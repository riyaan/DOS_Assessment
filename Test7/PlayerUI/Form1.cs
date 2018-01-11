using System;
using System.Windows.Forms;

namespace PlayerUI
{
    public partial class frmPlayerUI : Form
    {
        public frmPlayerUI()
        {
            InitializeComponent();
        }

        private void btnRetrieveAllPlayers_Click(object sender, EventArgs e)
        {
            try
            {
                GameServiceReference.GameClient client = new GameServiceReference.GameClient();

                dgView.DataSource = client.GetAllPlayers();
            }
            catch(Exception ex)
            {
                MessageBox.Show(String.Format("A server error occurred. {0}", ex.Message));
            }
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            // keep the button centered in the form
            btnRetrieveAllPlayers.Left = (this.ClientSize.Width - btnRetrieveAllPlayers.Width) / 2;
            btnRetrieveAllPlayers.Top = (this.ClientSize.Height - btnRetrieveAllPlayers.Height) / 2;
        }
    }
}
