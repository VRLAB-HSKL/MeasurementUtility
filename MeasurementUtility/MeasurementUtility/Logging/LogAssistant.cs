using System.IO;
using System.Runtime.CompilerServices;
using log4net;

namespace MeasurementUtility
{
    /// <summary>
    /// Manages predefined values in order to unify Logs.
    /// </summary>
    public static class LogAssistant
    {
        // readonly zu const?
        public const string TOOL_ID = "Tool: ";
        public const string MEASUREMENT_ID = " Measurement: ";
        public const string MEASUREMENT_ID_DISTANCE = " Distance: ";

        public const string METHOD_ENTER = "Entering Method: ";
        public const string METHOD_EXIT = "Exiting Method: ";

        public const string OPERATOR_USE = "Using Operator: ";

        public static ILog GetLogger([CallerFilePath] string filename = "")
        {
            return LogManager.GetLogger(Path.GetFileName( filename ));
        }
    }
}
