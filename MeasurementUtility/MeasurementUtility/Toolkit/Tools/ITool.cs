namespace MeasurementUtility
{
    internal interface ITool<IMeasureable>
    {
        IMeasureable Measure();
        void UpdatePoints();
    }
}
