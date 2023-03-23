using log4net;
using System;

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

            log.Debug("Coordinate " + this + "created.");

            //log.Debug("Coordinate: " + this);
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

        /// <summary>
        /// Comparison by Hashcode. Accurate for 7 decimal places.
        /// Also compares data types.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>Equals</returns>
        public override bool Equals(object obj)
        {
            log.Debug(LogAssistant.METHOD_ENTER + "Equals()");

            return obj is Coordinate coordinate &&
                   x == coordinate.x &&
                   y == coordinate.y &&
                   z == coordinate.z;
        }
        public override int GetHashCode()
        {
            log.Debug(LogAssistant.METHOD_ENTER + "GetHashCode()");

            return base.GetHashCode();
        }

        /// <summary>
        /// Compares only the Values of two Coordinates.
        /// </summary>
        /// <param name="c1">Coordinate 1</param>
        /// <param name="c2">Coordinate 2</param>
        /// <param name="epsilon"> Epsilon, fault tolerance</param>
        /// <returns></returns>
        public static bool EqualValue(Coordinate c1, Coordinate c2, double epsilon = Constants.Epsilon)
        {
            log.Debug(LogAssistant.METHOD_ENTER + "EqualValue()");

            return (Math.Abs(c1.x - c2.x) <= epsilon
                && Math.Abs(c1.y - c2.y) <= epsilon
                && Math.Abs(c1.z - c2.z) <= epsilon);
        }

        public static bool operator ==(Coordinate c1, Coordinate c2)
        {
            log.Debug(LogAssistant.OPERATOR_USE + "==");
            return c1.Equals(c2);
        }
        public static bool operator !=(Coordinate c1, Coordinate c2)
        {
            log.Debug(LogAssistant.OPERATOR_USE + "!=");
            return !c1.Equals(c2);
        }

        public static Coordinate operator +(Coordinate c1, Coordinate c2)
        {
            log.Debug(LogAssistant.OPERATOR_USE + "+");
            return new Coordinate(checked(c1.x + c2.x), checked(c1.y + c2.y), checked(c1.z + c2.z));
        }

        public static Coordinate operator -(Coordinate c1, Coordinate c2)
        {
            log.Debug(LogAssistant.OPERATOR_USE + "-");
            return new Coordinate(checked(c1.x - c2.x), checked(c1.y - c2.y), checked(c1.z - c2.z));
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            log.Debug(LogAssistant.METHOD_ENTER + "ToString()");
            return "{ " + x + ", " + y + ", " + z + " }";
        }
    }
}
