using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;

namespace VectorSum
{
    class Program
    {
        static List<string> array;
        static int sum = 0;      
        static readonly object _obj = new object();
        static List<int> result = new List<int>();
        static char[] separator = { ',' };    

        static void Main(string[] args)
        {
            Console.WriteLine("Processing the input file.");
            ProcessInputFile();

            Console.WriteLine("Sorting the sums.");
            result.Sort();

            Console.WriteLine("Creating the output file.");
            CreateOutputFile();
        }

        private static void ProcessInputFile()
        {
            StreamReader sr = new StreamReader(@"input.txt");
            string line = sr.ReadLine();

            while (line != null)
            {
                sum = 0;
                array = new List<string>();

                string[] tempArray = line.Split(separator);
                foreach (string s in tempArray) { array.Add(s); }

                Thread t = new Thread(new ThreadStart(CalculateSum));
                t.Start();
                t.Join();

                line = sr.ReadLine();
            }

            sr.Close();
        }        

        private static void CalculateSum()
        {
            lock (_obj)
            {
                foreach (string s in array) { sum += Int32.Parse(s); }
                result.Add(sum);
            }
        }

        private static void CreateOutputFile()
        {
            StreamWriter sw = new StreamWriter(@"output.txt");

            foreach (int i in result) { sw.WriteLine(i.ToString()); }
            
            sw.Close();

            Console.WriteLine("File 'output.txt' has been created.");
        }
    }
}
