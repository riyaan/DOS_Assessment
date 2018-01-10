using System;

namespace Test2.PascalsTriangle
{
    public class Blaise
    {
        private int rows;

        public int Rows
        {
            get { return rows; }
            set { rows = value; }
        }

        public Blaise(int rows)
        {
            Rows = rows;
        }

        public void Process()
        {
            for (int i = 0; i <= Rows; i++)
            {
                for (int j = Rows; j > i; j--)
                {
                    Console.Write("   ");
                }

                for (int k = 0; k <= i; k++)
                {
                    Console.Write(String.Format("{0, 6}", Pascal(i, k)));
                }

                Console.WriteLine("");
            }
        }

        public int Pascal(int column, int row)
        {
            if ((column == 0 || row == 0 || column == row))
            {
                return 1;
            }
            else
            {
                return Pascal(column - 1, row - 1) + Pascal(column - 1, row);
            }
        }
    }
}
