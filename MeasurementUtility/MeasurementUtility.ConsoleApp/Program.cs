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

            //TapeMeasure t = new TapeMeasure("1");
            Coordinate[] c = new Coordinate[] { c1, c2 };
            //t.Measure(c);
            //Console.WriteLine(t.GetMeasurement());

            //ToolboxManager m = new ToolboxManager();
            //m.SetupTools(t);

            //string jsonString = JsonSerializer.Serialize(c1);

            //Console.WriteLine("String: " + jsonString);

            //Coordinate? c5 =
            //    JsonSerializer.Deserialize<Coordinate>(jsonString);

            //Console.WriteLine(c5);

            //string js2 = JsonSerializer.Serialize(t);
            //Console.WriteLine(js2);

            //Distance d = new Distance("d1", c1,c2, 1f);
            //Console.WriteLine("Distance: " + JsonSerializer.Serialize(d));


            ToolboxManager toolboxManager = new ToolboxManager();
            toolboxManager.Selected = 7;
            //TODO: Get Coords from Points
            Measurement m = toolboxManager.GetMeasurement(c);
            Console.WriteLine("Measurement: " + m);
        }
    }
}