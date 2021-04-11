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
int level = int.Parse(Console.ReadLine());
            if (level <= 3)
            {
                Console.WriteLine("Initial");
            }
            else if (level <= 6)
            {
                Console.WriteLine("Average");
            }
            else if (level <= 9)
            {
                Console.WriteLine("Sufficient");
            }
            else if (level <= 12)
            {
                Console.WriteLine("High");
            }
            else
            {
                Console.WriteLine("hec biri");

            }
        }
    }
}
