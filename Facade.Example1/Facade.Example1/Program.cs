namespace Facade.Example1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DvdPlayer dvdPlayer = new DvdPlayer();
            Projector projector = new Projector();
            Speakers speakers = new Speakers();

            HomeTheaterFacade homeTheater = new HomeTheaterFacade(dvdPlayer, projector, speakers);
            homeTheater.WatchMovie("Inception");

            Console.WriteLine("Wait two hours");

            homeTheater.EndMovie();
        }
    }
}
