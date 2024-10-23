namespace Builder.Example2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BurgerDirector chef = new BurgerDirector();

            ClassicBurgerBuilder classicBurgerBuilder = new ClassicBurgerBuilder();
            chef.MakeBurger(classicBurgerBuilder);
            Burger classicBurger = classicBurgerBuilder.GetBurger();

            Console.WriteLine("Classic Burger:");
            classicBurger.DisplayInformation();

            VeggieBurgerBuilder veggieBurgerBuilder = new VeggieBurgerBuilder();
            chef.MakeBurger(veggieBurgerBuilder);
            Burger veggieBurger = veggieBurgerBuilder.GetBurger();

            Console.WriteLine("Veggie Burger:");
            veggieBurger.DisplayInformation();
        }
    }
}
