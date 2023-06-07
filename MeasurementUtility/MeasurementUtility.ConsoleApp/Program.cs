using log4net;
using System.IO;
using System.Xml.Serialization;
using System.Text.Json;
using System.Diagnostics;
using System.Text.Json.Serialization;

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

            Console.WriteLine(c1.ToJson());
            Console.WriteLine(c1.ToJObject());

            Coordinate c4 = new Coordinate(c1.ToJObject());
            Console.WriteLine(c4.ToJson());
            Console.WriteLine(c4.ToJObject());

            Distance d = new Distance("1", c1, c2, 1f);
            Console.WriteLine(d.ToJson());
            Console.WriteLine(d.ToJObject());

            Distance d2 = new Distance(d.ToJObject());
            Console.WriteLine(d2.ToJson());
            Console.WriteLine(d2.ToJObject());

            EmptyMeasurement e = new EmptyMeasurement();
            Console.WriteLine(e.ToJson());
            Console.WriteLine(e.ToJObject());
            EmptyMeasurement e1 = new EmptyMeasurement(e.ToJObject());
            Console.WriteLine(e1.ToJson());


            //TapeMeasure t = new TapeMeasure("1");
            //Coordinate[] c = new Coordinate[] { c1, c2 };
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

            //Console.WriteLine(c1.ToJson());
            //Coordinate cx = JsonSerializer.Deserialize<Coordinate>(c1.ToJson());
            //Console.WriteLine(cx.ToJson());
        }
        
    }
}