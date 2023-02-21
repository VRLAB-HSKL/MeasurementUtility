namespace MeasurementUtility.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Toolkit.Coordinate c1 = new Toolkit.Coordinate(1f, 0f, 1f);
            Toolkit.Coordinate c2 = new Toolkit.Coordinate(1d, 1d, 1d);

            Console.WriteLine( Global.Formulary.Distance(c1, c2) );



        }
    }
}