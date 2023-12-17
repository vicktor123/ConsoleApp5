namespace ConsoleApp5_1
{
    internal class FInter
    {

        public double I(double a, double b, int n, Func<double,double> f)
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
    }
    internal class Program
    {       

        static void Main(string[] args)
        {
            var res = (new FInter()).I(0, 6, 10, fun);
            Console.WriteLine(res);
        }
        static double fun(double x)
        {
            return Math.Sqrt(x);
        }
    }
}