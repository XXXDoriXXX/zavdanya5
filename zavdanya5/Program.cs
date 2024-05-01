using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace ConsoleApplication1
{
    class Program
    {
      

            static double Factorial(int n)
            {
                double fact = 1;
                for (int i = 1; i <= n; i++)
                {
                    fact *= i;
                }
                return fact;
            }

            static double Result(double x, int terms)
            {
                double cosx = 1;
                for (int n = 1; n < terms; n++)
                {
                    cosx += Math.Pow(-1, n) * Math.Pow(x, 2 * n) / Factorial(2 * n);
                }
                return cosx;
            }

            static void Main()
            {
                Console.Write("Введіть значення x: ");
                double x = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введіть кількість: ");
                int terms = Convert.ToInt32(Console.ReadLine());

                double result = Result(x, terms);
                Console.WriteLine($"Косинус {x} = {result}");
            }

        
    }

}


