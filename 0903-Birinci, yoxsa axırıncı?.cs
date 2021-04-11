using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e.olymp
{
    class Program
    {
        static void Main(string[] args)
            //birinci yoxsa sonuncu
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = a / 100;
            int d = a % 10;
            if(b > d)
            {
                Console.WriteLine(b);
            }
            else if(b < d)
            {
                Console.WriteLine(d);
            }
            else 
            {
                Console.WriteLine("=");
            }
        }
}
}
