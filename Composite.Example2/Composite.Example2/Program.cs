namespace Composite.Example2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee john = new Employee("John Doe");
            Employee jane = new Employee("Jane Doe");

            Manager bob = new Manager("Bob Smith");
            bob.Add(jane);
            bob.Add(john);

            Employee tom = new Employee("Tom Johnson");
            Manager susan = new Manager("Susan Thompson");
            susan.Add(tom);
            susan.Add(bob);

            susan.Display(1);
        }
    }
}
