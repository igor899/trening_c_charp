using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Begin3()
        {
            Console.Write("Введите сторону а: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите сторону b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            int P = 2 * (a + b);
            int S = a * b;
            Console.WriteLine($"S = {S} P = {P}"); 


        }
        static void Main(string[] args)
        {
            Begin3();

            Console.ReadKey();
        }
    }
}
