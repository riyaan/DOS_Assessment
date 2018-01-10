using System.Data;
using System.Data.SqlClient;

namespace Test3.Solid
{
    public class DataProvider : IDataProvider
    {
        public int Add(Shape shape, IDbConnection connection)
        {
            SqlCommand cmd;
            if (shape.Type == ShapeType.Circle)
            {
                cmd = new SqlCommand(string.Format("insert into [Table] values({0}, {1})", shape, shape.Radius), (SqlConnection)connection);
            }
            else
            {
                cmd = new SqlCommand(string.Format("insert into [Table] values({0}, {1}, {2})", shape, shape.Width, shape.Height), (SqlConnection)connection);
            }
            return cmd.ExecuteNonQuery();
        }
    }

    public interface IDataProvider
    {
        int Add(Shape shape, IDbConnection connection);
    }
}
