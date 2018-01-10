using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid
{
    public class Box
    {
        private BoxType _boxType;

        public double Width { get; set; } 
        public double Height { get; set; } 
        public double Radius { get; set; }
        public BoxType BoxType { get { return _boxType; } set { _boxType = value; } }

        public void Add()
        {
            using (var con = new SqlConnection())
            {
                SqlCommand cmd;
                if (_boxType == BoxType.Circle)
                {
                    cmd = new SqlCommand(string.Format("insert into [Table] values({0}, {1})", _boxType, Radius), con);
                }
                else { cmd = new SqlCommand(string.Format("insert into [Table] values({0}, {1}, {2})", _boxType, Width, Height), con); }
                cmd.ExecuteNonQuery();
            }
        }

        public double CalculateArea() 
        { 
            if (_boxType == BoxType.Rectangle) 
            { 
                return Width * Height; 
            } 
            else if (_boxType == BoxType.Square) 
            { 
                return Width * Height; 
            } 
            else if (_boxType == BoxType.Circle) 
            { 
                return Radius * Math.PI; 
            } 
            else 
            { 
                return 0; 
            } 
        }
    }

    public enum BoxType 
    { 
        Unknown, 
        Square, 
        Rectangle, 
        Circle 
    }
}