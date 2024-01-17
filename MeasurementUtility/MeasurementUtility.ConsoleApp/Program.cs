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
            Distance dcopy = d;
            Console.WriteLine(dcopy.ToJson());
            Console.WriteLine(d.ToJson());
            Console.WriteLine(d.ToJObject());

            Distance d2 = new Distance(d.ToJObject());
            Console.WriteLine(d2.ToJson());
            Console.WriteLine(d2.ToJObject());

            EmptyMeasurement e = new EmptyMeasurement();
            Console.WriteLine(e.ToJson());
            Console.WriteLine(e.ToJObject());
            EmptyMeasurement e1 = e;
            Console.WriteLine(e1.ToJson());

            Measurement m;
            Console.WriteLine(TestFunc(out m, d));
            
        }
        
        static bool TestFunc(out Measurement m, Distance d)
        {
            m = d;
            return true;
        }
    }
}