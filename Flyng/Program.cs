namespace Flyng
{
    public interface IFlyable {
        void Fly();
    }
    public class Bird : IFlyable {
        public void Fly() {     
        }
    }
    public class Dog {
        public void Bark() {
            // Implementation of Bark method.
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            object obj = new Bird();
            bool isFlyable = obj is IFlyable; // true
            obj = new Dog();
            isFlyable = obj is IFlyable; // false
            var  flyableObj = obj as IFlyable; //line 1
        }
    }
}