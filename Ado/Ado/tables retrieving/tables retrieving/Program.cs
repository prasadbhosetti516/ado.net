using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace tables_retrieving
{
    class Program
    {
        static void Main(string[] args)
        {
            Restaurant rt = new Restaurant();
            RestaurentDataLayer rd = new RestaurentDataLayer();
            Console.WriteLine("select your operation\n 1.inert\n 2.show\n 3.delete\n 4.update\n 5.exit ");

            int ch = int.Parse(Console.ReadLine());
            switch (ch)
            {
                case 1:
                    rt.setData();
                    rd.InsertRestaurent(rt);
                    Console.WriteLine("succefully inserted");
                    break;

                case 2:
                    rd.ShowData(rt);
                    break;

                case 3:
                    rd.delete();
                    break;

                case 4:
                    rd.update();
                    break;

                default:
                    Console.WriteLine("wrong choice");
                    break;

            }
            
            Console.ReadKey();
        }
    }
}

