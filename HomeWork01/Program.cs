using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework01
{
    class Program
    {
        static void Main(string[] args)
        {

            int n=46;

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(fibonacci(i).ToString() + ",");
            }
            Console.ReadLine();
        }
        static double fibonacci(double i)
        {
            switch (i)
            {
                case 0:
                    return 1;
                case 1:
                    return 1;
                default:
                    return fibonacci(i - 1) + fibonacci(i - 2);
            }
        }
    }
}


