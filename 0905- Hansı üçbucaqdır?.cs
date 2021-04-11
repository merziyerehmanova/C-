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
        {
            
            string[] tokens = Console.ReadLine().Split();
            int a = int.Parse(tokens[0]);
            int b = int.Parse(tokens[1]);
            int c = int.Parse(tokens[2]);

            if ((a == b) & (a == c))
            {
                Console.WriteLine("1");
            }
            else if ((a != b) & (a != c) & (b != c))
            {
                Console.WriteLine("3");
            }
            else
            {
                Console.WriteLine("2");
            }
        }
    }
}
