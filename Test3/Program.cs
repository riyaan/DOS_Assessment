using System;
using System.Data.SqlClient;

namespace Test3.Solid
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape shape = new Shape();
            shape.Type = ShapeType.Rectangle;
            shape.Height = 4;
            shape.Width = 3;

            double result = shape.CalculateArea();
            //shape.Add(new DataProvider(), new SqlConnection());

            // expected result = 12
            Console.WriteLine(result);
        }
    }
}
