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
            double[] arr = new double[n];
            int index = -1;
            for (int i = 0; i < n; i++)
            {
                arr[i] = double.Parse(tokens[i]);
                if (arr[i] <= 2.5)
                {
                    index = i + 1;
                    Console.WriteLine("{0} {1:N2}" , index, arr[i]);
                    break;
                }
            }
            if (index == -1) Console.WriteLine("Not Found");
        }
    }
}
