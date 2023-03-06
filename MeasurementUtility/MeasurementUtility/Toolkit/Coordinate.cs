using log4net;
using System;
using MeasurementUtility.Logging;

namespace MeasurementUtility
{
    /// <summary>
    /// Coordinate documentation test.
    /// </summary>
    public struct Coordinate
    {
        private static readonly ILog log = LogAssistant.GetLogger();

        public Coordinate(double x = 0d, double y = 0d, double z = 0d)
        {
            this.x = x;
            this.y = y;
            this.z = z;

            log.Debug("Coordinate: " + this);
            //log.Debug(System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location));
            //log.Info("Info");
            //log.Warn("Warn");

            //int i = 0;
            //try
            //{
            //    var x1 = 10 / i;
            //}
            //catch(DivideByZeroException ex)
            //{
            //    log.Error("Error accured: ", ex);
            //}

            //log.Fatal("Fatal");
        }

        public double x { get; set; }
        public double y { get; set; }
        public double z { get; set; }

        // comparison by Hashcode. Accurate for 7 decimal places.
        // also compares data types.
        public override bool Equals(object obj)
        {
            return obj is Coordinate coordinate &&
                   x == coordinate.x &&
                   y == coordinate.y &&
                   z == coordinate.z;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public static bool EqualValue(Coordinate c1, Coordinate c2, double epsilon = Constants.Epsilon)
        {
            return (Math.Abs(c1.x - c2.x) <= epsilon
                && Math.Abs(c1.y - c2.y) <= epsilon
                && Math.Abs(c1.z - c2.z) <= epsilon);
        }

        public static bool operator ==(Coordinate c1, Coordinate c2)
        {
            return c1.Equals(c2);
        }
        public static bool operator !=(Coordinate c1, Coordinate c2)
        {
            return !c1.Equals(c2);
        }

        public static Coordinate operator +(Coordinate c1, Coordinate c2)
        {
            return new Coordinate(checked(c1.x + c2.x), checked(c1.y + c2.y), checked(c1.z + c2.z));
        }

        public static Coordinate operator -(Coordinate c1, Coordinate c2)
        {
            return new Coordinate(checked(c1.x - c2.x), checked(c1.y - c2.y), checked(c1.z - c2.z));
        }

        public override string ToString()
        {
            return "{ " + x + ", " + y + ", " + z + " }";
        }
    }
}
