using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARRAY
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] tokens = Console.ReadLine().Split();
            int[] arr = new int[n];
           
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(tokens[i]);
                if (!(arr[i] < 0)) arr[i] += 2;
                Console.Write(arr[i] + " ");

            }

        }
    }
}
