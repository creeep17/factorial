using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factorial
{
    class Factoiral
    {
        static string name = "Факториал";

        public static int fact(int n)
        {
            int result = 1; // Здесь можно сократить
            for (int i = 2; i <= n; i++)
                result *= i;
            return result;
        }


        

        public static void Main(string[] args)
        {
            Console.Write("Введите число: "); // Здесь 
            var n = int.Parse(Console.ReadLine());
            var result = fact(n); // И здесь
            Console.Write(" {0} равен = ", name);
            for (int i = 1; i < n; i++)
                Console.Write("{0} * ", i);
            for (int i = n; i <= n; i++)
                Console.Write("{0} = ", i);
            Console.Write("{0} (при n  = {1} )", result, n);

            Console.ReadLine();
        }
    }
}
