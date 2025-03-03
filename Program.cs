


using NLog;
using NLog.Fluent;

namespace TestLog;

class Program
{
    private static Logger logger = LogManager.GetCurrentClassLogger();
    static void Main()
    {
       logger.Error("Hello World!");
        logger.Info("Info");
        logger.Debug("Debug");
        



    }

    static void Devide(int a, int b)
    {
        Console.WriteLine(a/b);
    }
}