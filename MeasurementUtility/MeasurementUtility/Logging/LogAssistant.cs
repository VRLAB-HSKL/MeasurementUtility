using System.IO;
using System.Runtime.CompilerServices;
using log4net;

namespace MeasurementUtility
{
    /// <summary>
    /// Manages predefined values in order to unify Logs.
    /// </summary>
    public class LogAssistant
    {
        public readonly static string TOOL_ID = "Tool: ";
        public readonly static string MEASUREMENT_ID = " Measurement: ";
        public readonly static string MEASUREMENT_ID_DISTANCE = " Distance: ";

        public readonly static string METHOD_ENTER = "Entering Method: ";
        public readonly static string METHOD_EXIT = "Exiting Method: ";

        public readonly static string OPERATOR_USE = "Using Operator: ";

        public static ILog GetLogger([CallerFilePath] string filename = "")
        {
            return LogManager.GetLogger(Path.GetFileName( filename ));
        }
    }
}
