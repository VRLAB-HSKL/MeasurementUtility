namespace MeasurementUtility
{
    /// <summary>
    /// This abstract class is the base for every class using serialization. 
    /// </summary>
    public abstract class ClassSetupBase
    {
        /// <summary>
        /// ID of the Tool, Measurement or Point used.
        /// </summary>
        string id;
        public string ID
        {
            get
            {
                return id;
            }

            protected set
            {
                id = value;
            }
        }

        /// <summary>
        /// Arguments used in the corresponding class.
        /// </summary>
        protected Coordinate[] args;
        /// <summary>
        /// Method used in order to set the arguments for the class. Intended use in constructor. Examples: <see cref="Distance"/>, <see cref="TapeMeasure"/>.
        /// </summary>
        /// <param name="args">Any number of arguments of type Coordinate.</param>
        protected void SetArguments(params Coordinate[] args)
        {
            this.args = args;
        }
    }
}
