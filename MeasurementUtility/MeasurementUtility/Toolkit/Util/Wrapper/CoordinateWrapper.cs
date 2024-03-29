﻿namespace MeasurementUtility
{
    /// <summary>
    /// Wrapper for any number of <see cref="Coordinate"/>.
    /// </summary>
    public abstract class CoordinateWrapper: JsonConverter
    {
        /// <summary>
        /// Number of Coordinates the wrapper holds.
        /// </summary>
        public int numberOfCoordinates { get; protected set; }

        /// <summary>
        /// Arguments used in the corresponding class.
        /// </summary>
        protected Coordinate[] coordinates { get; set; }

        /// <summary>
        /// Method used in order to set the arguments for the class. 
        /// Examples: <see cref="Distance"/>, <see cref="TwoPointDistanceMeasure"/>.
        /// </summary>
        /// <param name="args">Any number of arguments of type T.</param>
        protected void SetCoordinates(params Coordinate[] args)
        {
            if(args.Length != numberOfCoordinates) 
            { 
                throw new System.ArgumentOutOfRangeException(nameof(args));
            }
            else
            {
                this.coordinates = args;
            }   
        }

        /// <summary>
        /// Method used in order to get the arguments for the class. 
        /// </summary>
        /// <returns>An array of contained Coordinates.</returns>
        public Coordinate[] GetCoordinates()
        {
            return coordinates;
        }
    }
}
