namespace MyMath_
{
    public class MyMath
    {
        public delegate double ToDo(double x);
        public static double EvalTimeDToD(int count, ToDo fun, double x)
        {
            DateTime start, finish;
            double res = 0;
            start = DateTime.Now;
            for (int i = 1; i < count; i++)
                fun(x);
            finish = DateTime.Now;
            res = (finish - start).Ticks;
            return res;
        }
    }

    internal class Program
    {
        static double foo(double x)
        {
            return Math.Sin(2 * x);
        }

        static void Main(string[] args)
        {
            
        }
    }
}