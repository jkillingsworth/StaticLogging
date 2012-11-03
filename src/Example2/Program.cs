using System;
using System.Diagnostics;
using StaticLogging;

namespace Example2
{
    class Program
    {
        static void Main()
        {
            // Try this with and without the USE_NAMED_HIERARCHY symbol defined.

            var stopwatch = Stopwatch.StartNew();

            for (var i = 0; i < 1000000; i++)
            {
                Log.Debug("Hello world.");
            }

            stopwatch.Stop();
            Console.WriteLine(stopwatch.ElapsedMilliseconds);
        }
    }
}
