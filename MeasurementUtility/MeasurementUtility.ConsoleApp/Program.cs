namespace MeasurementUtility.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Coordinate c1 = new Coordinate(1f, 0f, 1f);
            Coordinate c2 = new Coordinate(1d, 1d, 1d);

            Distance d = new Distance("möp:",c1, c2);

            Console.WriteLine(d.ToString());
        }
    }
}