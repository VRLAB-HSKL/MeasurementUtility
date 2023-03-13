namespace MeasurementUtility
{
    public abstract class ToolBase<IMeasureable> : ClassSetupBase
    {
        public abstract IMeasureable Measure();

        public void UpdatePoints()
        {
            throw new System.NotImplementedException();
        }

        public abstract override string ToString();
    }
}
