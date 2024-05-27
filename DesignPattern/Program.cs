namespace DesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var white1 = new WhiteDuck();
            var rubber1 = new RubberDuck();

            white1.Fly();
            white1.Cack();
            white1.Display();
            white1.Swim();

            Console.WriteLine("*****************");

            rubber1.Fly();
            rubber1.Cack();
            rubber1.Display();
            rubber1.Swim();
        }
    }
}
