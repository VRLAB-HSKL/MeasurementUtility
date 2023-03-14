namespace MeasurementUtility
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="MeasurementBase">Datatype of the measurement. Primarily intended for types of MeasurementBase, but primitve data types
    /// can also be used.</typeparam>
    public abstract class ToolBase<MeasurementBase> : ClassSetupBase
    {
        public abstract MeasurementBase Measure();

        public void UpdatePoints()
        {
            throw new System.NotImplementedException();
        }

        public abstract override string ToString();
    }
}
