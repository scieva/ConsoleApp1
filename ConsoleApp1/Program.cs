using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trials_1._0
{
    class Program
    {
        static int SumUp(int n) {
            int sum = 0;
            for (int i = 0; i < n; i++) {
                sum += 1;
            }
            return n;
        }

        static void Main(string[] args)
        {
            int s = SumUp(10);
            Console.WriteLine("The sum is: " + s);

            Console.Write("Hello");
            Console.WriteLine(" World!");
            Console.ReadKey();
        }
    }
}
