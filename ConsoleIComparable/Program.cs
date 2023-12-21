namespace ConsoleIComparable
{
    class Person : IComparable
    {
        public string Name { get; }
        public int Age { get; set; }
        public Person(string name, int age)
        {
            Name = name; Age = age;
        }
        public int CompareTo(object? o)
        {
            if (o is Person person) return Name.CompareTo(person.Name);
            else throw new ArgumentException("Некорректное значение параметра");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Person[] list = new Person[] {
                    new Person("Tom", 37),
                    new Person("Bob", 41),
                    new Person("Sam", 25),
                    new Person("Ahmed",19)
            };
            Array.Sort(list);
            foreach (Person person in list)
            {
                Console.WriteLine($"{person.Name}\t: {person.Age}");
            }
        }
    }
}