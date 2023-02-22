using System.Runtime.CompilerServices;
using log4net;

namespace MeasurementUtility.Logging
{
    public class LogAssistant
    {
        public static ILog GetLogger([CallerFilePath] string filename = "")
        {
            return LogManager.GetLogger(filename);
        }
    }
}
