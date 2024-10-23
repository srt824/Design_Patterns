using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonRealWorldExample
{
    public class EventLogger
    {
        private static EventLogger _instance;
        private List<string> _eventLogs;
        private EventLogger()
        {
            _eventLogs = new List<string>();
        }
        public static EventLogger GetInstance()
        {
            if (_instance == null)
            {
                _instance = new EventLogger();
            }
            return _instance;
        }
        public void LogEvent(string eventMessage)
        {
            string timestamp = DateTime.UtcNow.ToString("yyyy-MM-dd HH:mm:ss.fff");
            _eventLogs.Add($"{timestamp}: {eventMessage}");
        }
        public void DisplayLogs()
        {
            foreach (string log in _eventLogs)
            {
                Console.WriteLine(log);
            }
        }
    }
}
