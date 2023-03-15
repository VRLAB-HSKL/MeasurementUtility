namespace MeasurementUtility
{
    /// <summary>
    /// This class defines the base of every tool.
    /// </summary>
    /// <typeparam name="MeasurementBase">Datatype of the measurement. Primarily intended for types of MeasurementBase, but primitve data types
    /// can also be used.</typeparam>
    public abstract class ToolBase<MeasurementBase> : ClassSetupBase
    {
        /// <summary>
        /// Method used to create an instance of a MeasurementBase.
        /// </summary>
        /// <returns>Measurement created the corresponding tool</returns>
        public abstract MeasurementBase Measure();

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="System.NotImplementedException"></exception>
        public void UpdatePoints()
        {
            throw new System.NotImplementedException();
        }

        /// <inheritdoc/>
        public abstract override string ToString();
    }
}
