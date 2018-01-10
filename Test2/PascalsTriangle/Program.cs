using System;

namespace Test2.PascalsTriangle
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of rows:");

            int rows = 0;

            if (Int32.TryParse(Console.ReadLine(), out rows) == false)
                return;

            Blaise blaise = new Blaise(rows);            
            blaise.Process();
        }
    }
}