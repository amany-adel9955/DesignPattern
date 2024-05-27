namespace DecoratorDP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Beverage espresso = new Espresso();
            Console.WriteLine(espresso);

            Beverage espressowithmilk = new Milk(espresso);  // decorating espresso with milk as composition relationship
            Console.WriteLine(espressowithmilk);

            Beverage mocha = new Mocha(espressowithmilk);
            Console.WriteLine(mocha);

            Beverage caramel = new Caramel(espressowithmilk);
            Console.WriteLine(caramel);
        }
    }
}
