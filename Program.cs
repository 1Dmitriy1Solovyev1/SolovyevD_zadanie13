using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolovyevD
{
    class Program
    {
        static double y(double x, int n)
        {
            if (n == 1) return x;
            if (n % 2 == 0)
            {
                double tmp = y(x, n / 2);
                return tmp * tmp;
            }
            return x * y(x, n - 1);
        }
        static void Main(string[] args)
        {
            Console.Write("x = ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine($"{x}^{n} = {y(x, n)}");
            Console.ReadLine();
        }
    }
}