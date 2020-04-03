using System;

namespace Delegates
{
    // public delegate double MathsFunction(double x);

    class Program
    {
        public delegate int D1 (double x);
        Func<double, int> d1;

        public delegate int D2(double x, string s);
        Func<double, string, int> d2;

        public delegate void D3(int i);
        Action<int> d3;

        static void Plot (Func<double,double> f, double x0, double x1, double dx)
        {
            for (double x = x0; x < x1; x += dx)
            {
                double y = f(x);

                Console.WriteLine($"{x:N2}, {y:N2}");
            }
        }

        static double Double (double x)
        {
            Console.WriteLine("Doubling");
            return x * 2;
        }

        static double Triple(double x)
        {
            Console.WriteLine("Tripling");
            return x * 2;
        }
        
        static void Main(string[] args)
        {
             Plot(x => x * 2, 0.0, Math.PI / 2, 0.01);
        }
    }
}
