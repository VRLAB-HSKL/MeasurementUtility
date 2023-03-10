﻿namespace MeasurementUtility
{
    public abstract class MeasurementBase<T> : ClassSetupBase, IMeasureable<T>
    {
        public T GetMeasurement()
        {
            return CalculateMeasurement();
        }
        
        protected abstract T CalculateMeasurement();

        public abstract override string ToString();
    }
}
