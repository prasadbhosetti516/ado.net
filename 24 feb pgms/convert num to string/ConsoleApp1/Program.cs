using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        public void ConvertTo(int num)
        {
            int n,rev=0;
            while(num>0)
            {
                n = num % 10;
                rev = rev * 10 + n;
                num = num / 10;
            }
            int r1;
            while(rev>0)
            {
                r1 = rev % 10;
                fan(r1);
                rev = rev / 10;
            }
        }
        public void fan(int r1)
        {
            switch(r1)
            {
                case 0:Console.WriteLine("zero");break;
                case 1: Console.WriteLine("one"); break;
                case 2: Console.WriteLine("two"); break;
                case 3: Console.WriteLine("three"); break;
                case 4: Console.WriteLine("four"); break;
                case 5: Console.WriteLine("five"); break;
                case 6: Console.WriteLine("six"); break;
                case 7: Console.WriteLine("seven"); break;
                case 8: Console.WriteLine("eight"); break;
                case 9: Console.WriteLine("nine"); break;

            }
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.ConvertTo(1234);
        }
    }
}
