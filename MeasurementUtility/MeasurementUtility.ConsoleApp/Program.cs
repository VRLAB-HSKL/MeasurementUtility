using log4net;
using System.IO;
using System.Xml.Serialization;
using System.Text.Json;

namespace MeasurementUtility.ConsoleApp
{
    class Program
    {
        private static readonly ILog log = LogAssistant.GetLogger();
        static void Main(string[] args)
        {
            Coordinate c1 = new Coordinate(1f, 0f, 1f);
            Coordinate c2 = new Coordinate(1d, 1d, 1d);
            Coordinate c3 = new Coordinate(2f, 2f, 2f);

            TapeMeasure t = new TapeMeasure("1");
            Coordinate[] c = new Coordinate[] { c1, c2 };
            t.Measure(c);
            Console.WriteLine(t.CreateMeasurement());

            ToolboxManager m = new ToolboxManager();
            m.SetupTools(t);

            string jsonString = JsonSerializer.Serialize(c1);

            Console.WriteLine(jsonString);

            Coordinate? c5 =
                JsonSerializer.Deserialize<Coordinate>(jsonString);

            Console.WriteLine(c);

            string js2 = JsonSerializer.Serialize(t);
            Console.WriteLine(js2);

        }
    }
}