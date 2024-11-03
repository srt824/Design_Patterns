namespace Decorator.Example2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IBurger burger = new BasicBurger();
            Console.WriteLine($"{burger.GetDescription()}: ${burger.GetCost()}");

            burger = new CheeseDecorator(burger);
            Console.WriteLine($"{burger.GetDescription()}: ${burger.GetCost()}");

            burger = new BaconDecorator(burger);
            Console.WriteLine($"{burger.GetDescription()}: ${burger.GetCost()}");

        }
    }
}
