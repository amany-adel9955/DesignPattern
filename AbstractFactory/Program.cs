using AbstractFactory.CarComponents;
using AbstractFactory.CarComponents.Factories;

namespace AbstractFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Thread thread = Thread.CurrentThread;
            thread.Name = "New Thread";
            Console.WriteLine($"thread name is {thread.Name}");
        }
    }
}
