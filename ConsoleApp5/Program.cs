namespace ConsoleApp5
{
    internal class FInter
    {
        public double I(double a, double b, int n)
        {
            double s = 0;
            double dx = (b - a) / n;
            for (var x = a; x <= b;)
            {
                s += dx * f(x);
                x += dx;
            }
            return s;
        }

        protected virtual double f(double x)
        {
            return 1.0;
        }
    }
    internal class FISon : FInter
    {
        protected override double f(double x)
        {
            double a = 1.0; double b = 2.0; double c = 3.0;
            return (double)(a * x * x + b * x + c);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}