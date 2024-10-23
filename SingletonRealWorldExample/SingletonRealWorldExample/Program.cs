namespace SingletonRealWorldExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EventLogger logger = EventLogger.GetInstance();

            logger.LogEvent("Starting app...");
            logger.LogEvent("Executing Task 1...");

            EventLogger logger2 = EventLogger.GetInstance();

            logger2.LogEvent("Finish execution of Task 1.");
            logger2.LogEvent("Ending app.");

            EventLogger logger3 = EventLogger.GetInstance();

            logger.DisplayLogs();
        }
    }
}
