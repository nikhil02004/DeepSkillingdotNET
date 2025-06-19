using System;

namespace SingletonPatternExample
{
    class Program
    {
        static void Main()
        {
            Logger log1 = Logger.Instance;
            Logger log2 = Logger.Instance;

            log1.Log("This is the first log.");
            log2.Log("This is the second log.");

            Console.WriteLine(Object.ReferenceEquals(log1, log2)); // Should print True
        }
    }
}
