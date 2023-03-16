namespace MeasurementUtility
{
    public abstract class SerializableObject
    {
        /// <summary>
        /// ID
        /// </summary>
        private string id;
        public string ID
        {
            get => id;
            protected set => id = value;
        }
    }
}
