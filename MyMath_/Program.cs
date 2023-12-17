namespace MyMath_
{
    public class MyMath
    {
        public delegate long ToDo(int x);
        public static double EvalTimeDToD(int count, ToDo fun, int x)
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
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}