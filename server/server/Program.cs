using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace server
{
    class Program
    {
        static void Main(string[] args)
        {
            string constr = @"Data Source=BLT1071\SQLEXPRESS;Initial Catalog=kanna;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(constr))
            {
                string querystr = "select * from student";
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(querystr, con);
                    SqlDataReader detared = cmd.ExecuteReader();
                    while (detared.Read())
                    {
                        Console.WriteLine("{0}\t{1}\t{2}\t", detared[0], detared[1], detared[2]);
                    }
                    detared.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                Console.ReadKey();
                }
            }
        }
    }
    

