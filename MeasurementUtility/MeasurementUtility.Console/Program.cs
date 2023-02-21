using MeasurementUtility.Global;
using MeasurementUtility.Toolkit;

namespace MeasurementUtility.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Coordinate c1 = new Coordinate(1f, 0f, 1f);
            Coordinate c2 = new Coordinate(1d, 1d, 1d);

            Console.WriteLine(Formulary.Distance(c1, c2));


        }
    }
}