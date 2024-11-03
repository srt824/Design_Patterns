using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Example1
{
    public class CommunicationSystem
    {
        public void StartCommunication(ICommunication communicator, string question, string answer)
        {
            Console.WriteLine(communicator.Ask(question));
            Console.WriteLine(communicator.Reply(answer));
        }
    }
}
