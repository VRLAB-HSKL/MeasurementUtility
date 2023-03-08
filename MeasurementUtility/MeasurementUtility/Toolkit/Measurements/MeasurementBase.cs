﻿namespace MeasurementUtility
{
    public abstract class MeasurementBase<T> : IMeasureable<T>
    {
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

        protected Coordinate[] args;
        protected void SetArguments(params Coordinate[] args)
        {
            this.args = args;
        }

        public T GetMeasurement()
        {
            return CalculateMeasurement();
        }
        
        protected abstract T CalculateMeasurement();

        public abstract override string ToString();
    }
}
