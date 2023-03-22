using System.Collections.Generic;

namespace MeasurementUtility
{
    public class ToolboxManager
    {
        int selected = 0;
        public int Selected 
        { 
            get 
            { 
                return selected; 
            } 
            set
            {
                if (value < 0 || value > tools.Count) 
                {
                    throw new System.IndexOutOfRangeException();
                }
                else
                {
                    selected = value;
                }
            } 
        }

        public const int MAXCAPACITY = 6;

        // List of Tools
        private List<ITool> tools = new List<ITool>();

        public ToolboxManager()
        {

        }

        private void AddTool(ITool tool)
        {
            if(tools.Count >= MAXCAPACITY)
            {
                throw new System.ArgumentOutOfRangeException();
            }
            else
            {
                tools.Add(tool);
            }
        }

        // Setup Tools via xml file
        public void SetupTools(ITool tool)
        {
            AddTool(tool);
            AddTool(tool);
            AddTool(tool);
        }
        public void SaveSnapshot()
        {
            //tools[selected]
        }

        public CoordinateWrapper CreateMeasurement()
        {
            return tools[selected].CreateMeasurement();
        }
    }
}
