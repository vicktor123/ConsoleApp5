namespace ConsoleApp5_1
{
    internal class FInter
    {

        public double I(double a, double b, int n, FuncType f)
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
            
            
        }
        static double fun(double x)
        {
            return Math.Sqrt(x);
        }
    }
}