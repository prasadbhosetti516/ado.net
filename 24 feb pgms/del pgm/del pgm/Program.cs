using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace del_pgm
{
    public delegate double delegatereturn(double a, double b);
    class Program
    {
       
        public static double delegatetarea(double h, double b)
        {
            double res1;
            return res1 = 0.5* b * h;
        }


      /*  public static int delegaterarea(int l,int b)
        {
           return  res1 = l * b;
        }*/

        public static void Main(string[] args)
        {
          delegatereturn del = delegatetarea;
          double R= delegatetarea(10, 20);
            
            Console.WriteLine(R);
        }
    }
}
