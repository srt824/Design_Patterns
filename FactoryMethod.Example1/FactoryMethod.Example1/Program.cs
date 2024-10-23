using FactoryMethod.Example1.Factories;

namespace FactoryMethod.Example1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Factory Method example");

            VehicleFactory vehicleFactory = null;

            while (true)
            {
                Console.WriteLine("\nPlease choose a vehicle type: (1) Car, (2) Motorcycle, (3) Bike, (4) Quit");

                int vehicleChoise = Convert.ToInt32(Console.ReadLine());
                switch (vehicleChoise)
                {
                    case 1:
                        vehicleFactory = new CarFactory();
                        break;
                    case 2:
                        vehicleFactory = new MotorcycleFactory();
                        break;
                    case 3:
                        vehicleFactory = new BikeFactory();
                        break;
                    default:
                        break;
                }

                IVehicle vehicle = vehicleFactory.OrderVehicle();
                Console.WriteLine($"You have used a {vehicle.GetType().Name}.\n");
            }

            Console.WriteLine("Thank you for using the System");
            Console.ReadKey();
        }
    }
}
