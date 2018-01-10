using System;
using System.Data;

namespace Test3.Solid
{
    public enum ShapeType
    {
        Unknown,
        Square,
        Rectangle,
        Circle
    }

    public interface IShape
    {
        double CalculateArea();
    }

    public class Shape : IShape
    {
        private ShapeType _type;

        public double Width { get; set; } 
        public double Height { get; set; } 
        public double Radius { get; set; }
        public ShapeType Type { get { return _type; } set { _type = value; } }

        public void Add(IDataProvider dp, IDbConnection dbConnection)
        {            
            dp.Add(this, dbConnection);
        }

        public double CalculateArea() 
        { 
            if (this.Type == ShapeType.Rectangle) 
            { 
                return Width * Height; 
            }
            else if (this.Type == ShapeType.Square) 
            { 
                return Width * Height; 
            }
            else if (this.Type == ShapeType.Circle) 
            { 
                return Radius * Math.PI; 
            } 
            else 
            { 
                return 0; 
            } 
        }
    }    
}