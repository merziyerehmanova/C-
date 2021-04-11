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
            if((a < b & a > c) | (a < c & a > b))
            {
                Console.WriteLine(a);
            }
            else if((b < a & b > c) | (b < c & b > a))
            {
                Console.WriteLine(b);
            }
            else if((c < a & c > b) | (c < b & c > a))
            {
                Console.WriteLine(c);
            }
        }
    }      
