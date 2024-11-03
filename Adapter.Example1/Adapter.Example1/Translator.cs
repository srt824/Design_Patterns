using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Example1
{
    public class Translator : ICommunication
    {
        private readonly SpanishSpeaker _spanishSpeaker;
        public Translator(SpanishSpeaker spanishSpeaker)
        {
            _spanishSpeaker = spanishSpeaker;
        }
        public string Ask(string question)
        {
            return _spanishSpeaker.Pregunta(question);
        }

        public string Reply(string answer)
        {
            return _spanishSpeaker.Respuesta(answer);
        }
    }
}
