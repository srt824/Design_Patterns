namespace Adapter.Example1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CommunicationSystem communicationSystem = new CommunicationSystem();
            EnglishSpeaker englishSpeaker = new EnglishSpeaker();
            communicationSystem.StartCommunication(englishSpeaker, "How are you?", "I'm fine, thank you!");

            SpanishSpeaker spanishSpeaker = new SpanishSpeaker();
            Translator translator = new Translator(spanishSpeaker);
            communicationSystem.StartCommunication(translator, "cómo estás?", "Estoy bien, gracias");
        }
    }
}
