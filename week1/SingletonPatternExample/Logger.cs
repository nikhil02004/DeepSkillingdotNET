
using System;

namespace SingletonPatternExample
{
    public class Logger
    {
        private static Logger instance = null;
        private static readonly object padlock = new object();

        private Logger()
        {
            Console.WriteLine("Logger initialized.");
        }

        public static Logger Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                        instance = new Logger();
                    return instance;
                }
            }
        }

        public void Log(string message)
        {
            Console.WriteLine("[LOG]: " + message);
        }
    }
}
