namespace MeasurementUtility
{
    public abstract class ClassSetupBase
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
    }
}
