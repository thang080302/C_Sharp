using System.Data.Common;
using System.Data.SqlClient;
namespace ConsoleApp3
{
    internal class Program
    {
        public static void ConnectDB()
        {
            
        }
        
        static void Main(string[] args)
        {
            //string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            //foreach (string car in cars)
            //{
            //    console.write(car + " ");
            //}
            //Console.WriteLine(args);
            //Car car = new Car();
            //Console.WriteLine($"{car.Color} {car.Name1} {car.brand}");
            string StrConn = @"Data Source=XUANTHANG-08030;Initial Catalog=QLBanHang;Integrated Security=True";
            SqlConnection conn = new SqlConnection(StrConn);
            try
            {
                Console.WriteLine("Openning Connection ...");
                conn.Open();
                Console.WriteLine("Connection successful!");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
            SqlCommand cmd = new SqlCommand("select * from HangSX",conn);

            DbDataReader dbDataReader = cmd.ExecuteReader();
            
            if(dbDataReader.HasRows)
            {
                Console.WriteLine($"MaHangSX   TenHang");
                while(dbDataReader.Read())
                {
                    int TenHangindex = dbDataReader.GetOrdinal("TenHang");
                    int index = dbDataReader.GetOrdinal("MaHangSX");
                    string MaHangSX = dbDataReader.GetString(index);
                    string TenHang = dbDataReader.GetString(TenHangindex);
                    if (!dbDataReader.IsDBNull(index))
                    {
                       Console.WriteLine($"{MaHangSX} {TenHang}");
                    }
                }
            }
            
            
        }
    }
}