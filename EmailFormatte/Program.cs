namespace EmailFormatte
{
    

    internal class Program
    {
        private delegate string EmailFormatter(string email);
        private static void testing1()
        {
            EmailFormatter emailFormatter = new EmailFormatter(RemoveDots);

            const string Address = "admin@google.com";
            var first = emailFormatter(Address);
            Console.WriteLine($"First={first}");
            emailFormatter += RemoveAtSign;

            var second = emailFormatter(Address);
            Console.WriteLine($"Second={second}");
            
        }
        static void Main(string[] args)
        {
            testing1();
        }
    }
}