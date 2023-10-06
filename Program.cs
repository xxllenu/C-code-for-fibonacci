using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buenaventura_eyo__fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter how many Fibonacci numbers to generate: ");
            Console.WriteLine("------------------------------------------");
            int n = Convert.ToInt32(Console.ReadLine());

            int a = 0, b = 1;

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(a);
                int temp = a;
                a = b;
                b = temp + b;
            }
            Console.ReadKey();
        }
    }

}
