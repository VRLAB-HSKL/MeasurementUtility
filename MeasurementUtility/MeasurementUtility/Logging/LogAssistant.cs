﻿using System.Runtime.CompilerServices;
using log4net;

namespace MeasurementUtility
{
    public class LogAssistant
    {
        public readonly static string TOOL_ID = "Tool: ";
        public readonly static string MEASUREMENT_ID = " Measurement: ";
        public readonly static string MEASUREMENT_ID_DISTANCE = " Distance: ";

        public readonly static string METHOD_ENTER = "Entering Method: ";
        public readonly static string METHOD_EXIT = "Exiting Method: ";

        public static ILog GetLogger([CallerFilePath] string filename = "")
        {
            return LogManager.GetLogger(filename);
        }
    }
}
