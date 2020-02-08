using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace tables_retrieving
{
    class Restaurant : Menu
    {
        public int Rlic_no { get; set; }//if is is created using identity keyword we dont ste the value;
        public string Rname
        {
            get; set;
        }
        public string Rloc { get; set; }
        public string Rtype { get; set; }

        public void setData()
        {
            Console.WriteLine("enter returant details: lic no");
            int rlcno = int.Parse(Console.ReadLine());
            Console.WriteLine("enter returant details: name");
            string rname = Console.ReadLine();
            Console.WriteLine("enter returant details:loc");
            string rloc = Console.ReadLine();
            Console.WriteLine("enter returant details:type");
            string rtype = Console.ReadLine();

            Rlic_no = rlcno;
            Rname = rname;
            Rloc = rloc;
            Rtype = rtype;

        }
    }
}


       