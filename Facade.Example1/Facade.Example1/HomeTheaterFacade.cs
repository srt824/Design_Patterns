using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.Example1
{
    public class HomeTheaterFacade
    {
        private DvdPlayer _dvdPlayer;
        private Projector _projector;
        private Speakers _speakers;

        public HomeTheaterFacade(DvdPlayer dvdPlayer,
                                 Projector projector,
                                 Speakers speakers)
        {
            _dvdPlayer = dvdPlayer;
            _projector = projector;
            _speakers = speakers;
        }
        public void WatchMovie(string movie)
        {
            Console.WriteLine("Get ready to watch a movie...");

            _projector.On();
            _speakers.On();
            _dvdPlayer.On();
            _dvdPlayer.PlayMovie(movie);
        }
        public void EndMovie()
        {
            Console.WriteLine("Shutting movie theater down...");
            _projector.On();
            _speakers.On();
            _dvdPlayer.On();
            
        }
    }
}
