using System;

namespace PascalsTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number = ");

            int num = 0;

            if (Int32.TryParse(Console.ReadLine(), out num) == false)
                return;

            for (int i = 0; i <= num; i++)
            {
                for (int j = num; j > i; j--)
                { 
                    Console.Write("   ");
                }

                for (int k = 0; k <= i; k++)
                {
                    Console.Write(String.Format("{0, 6}", pascal(i, k)));
                }

                Console.WriteLine("");
            }
        }

        static int pascal(int column, int row)
        {
              if ((column == 0 || row == 0 || column == row)) 
              {
                return 1;
              }
              else
              {
                return pascal(column - 1, row - 1) + pascal(column - 1, row);
              }
        }
    }
}