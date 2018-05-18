using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork02
{
    class Program
    {

        static void Main(string[] args)
        {
            Monkey monkey = new Monkey();
            Console.WriteLine("有100隻猴子，每數到3個，該猴子就要離開此圈");
            Console.WriteLine("則第" + monkey.King(100,3) + "隻猴子為大王。");
            Console.ReadLine();
        }

        public class Monkey
        {
            public int King(int total, int number)
            {
                int k = 0;
                for (int i = 2; i <= total; i++)
                {
                    k = (k + number) % i;
                }  
                return ++k;
            }
        }
    }
}
