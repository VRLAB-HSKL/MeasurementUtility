namespace MeasurementUtility
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class SerializableObject
    {
        /// <summary>
        /// ID of the object.
        /// </summary>
        private string id;
        public string ID
        {
            get => id;
            protected set => id = value;
        }
    }
}
