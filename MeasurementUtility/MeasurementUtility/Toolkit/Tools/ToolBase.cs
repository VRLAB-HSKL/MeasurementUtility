namespace MeasurementUtility
{
    public abstract class ToolBase<IMeasureable> : ITool<IMeasureable>
    {
        // Serializable?
        // Auslagern?
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

        public abstract IMeasureable Measure();

        public void UpdatePoints()
        {
            throw new System.NotImplementedException();
        }

        public abstract override string ToString();
    }
}
