using System.Runtime.CompilerServices;
using log4net;

namespace MeasurementUtility
{
    public class LogAssistant
    {
        public readonly static string INFO_METHODENTER = "Entering Method: ";
        public readonly static string INFO_METHODEXIT = "Exiting Method: ";

        public static ILog GetLogger([CallerFilePath] string filename = "")
        {
            return LogManager.GetLogger(filename);
        }
    }
}
