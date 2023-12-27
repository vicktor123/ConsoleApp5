namespace PrintMessage
{
    public delegate void Del(string msg);
    class Class6
    {
        public void Method(int param1,Del callback)
        {
            callback("The number is : " + param1.ToString());
        }
    }
    internal class Program
    {
        static void PrintMes(string mes)
        {
            Console.WriteLine(mes);
        }

       // реализовать многоадрестность
        static void Main(string[] args)
        {
            Class6 cl = new Class6();
            Del deleg= new Del(PrintMes);          
            
            cl.Method(3, deleg);
            Console.ReadKey();
        }
    }
}