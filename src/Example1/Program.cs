using System;
using StaticLogging;

namespace Example1
{
    class Program
    {
        static void Main()
        {
            Log.Trace("Hello trace.");
            Log.Debug("Hello debug.");

            Log.Info("Hello info: {0}, {1}, {2}.", 1, 2.3, "four");
            Log.Warn("Hello warn.");

            try
            {
                DoSomethingErroneous("Hello error.");
            }
            catch (Exception ex)
            {
                Log.Error(ex);
            }

            try
            {
                DoSomethingErroneous("Hello fatal.");
            }
            catch (Exception ex)
            {
                Log.Fatal(ex);
            }
        }

        static void DoSomethingErroneous(string message)
        {
            Log.Warn("Heads up!");
            throw new ApplicationException(message);
        }
    }
}
