namespace Singleton.Example2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MySingleton instance1 = MySingleton.GetInstance();
            Console.WriteLine($"Instance 1 ID: {instance1.Id}");

            MySingleton instance2 = MySingleton.GetInstance();
            Console.WriteLine($"Instance 2 ID: {instance1.Id}");

            MySingleton instance3 = MySingleton.GetInstance();
            Console.WriteLine($"Instance 3 ID: {instance1.Id}");
        }
    }
}
