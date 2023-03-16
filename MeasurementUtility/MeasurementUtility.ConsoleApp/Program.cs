namespace MeasurementUtility.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Coordinate c1 = new Coordinate(1f, 0f, 1f);
            Coordinate c2 = new Coordinate(1d, 1d, 1d);
            Coordinate c3 = new Coordinate(2f, 2f, 2f);

            TapeMeasure t = new TapeMeasure("1");
            t.UpdateCoordinates(c1, c3);
            

            Console.WriteLine(t.CreateMeasurement());
        }
    }
}