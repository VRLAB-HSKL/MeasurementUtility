using log4net;
using System.Collections.Generic;

namespace MeasurementUtility
{
    public class ToolboxManager
    {
        private static readonly ILog log = LogAssistant.GetLogger();

        public const int MAXCAPACITY = 6;

        int selected = 0;
        public int Selected 
        { 
            get 
            { 
                return selected; 
            } 
            set
            {
                log.Info("Input value: " + value + ", converted to valid value: " + value % MAXCAPACITY);
                selected = value % MAXCAPACITY;
            } 
        }  

        // List of Tools
        private List<ITool> tools = new List<ITool>();

        public ToolboxManager() // path parameter: xml, json
        {
            AddTool(new TapeMeasure("t1"));
            AddTool(new TapeMeasure("t2"));
        }

        private void AddTool(ITool tool)
        {
            if(tools.Count >= MAXCAPACITY)
            {
                throw new System.ArgumentOutOfRangeException(nameof(tool), " could not be added. Manager is already ad max capacity");
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
        }
        public void SaveSnapshot()
        {
            //tools[selected]
        }

        public Measurement GetMeasurement(Coordinate[] coordinates)
        {
            tools[selected].Measure(coordinates);
            return tools[selected].CreateMeasurement();
        }
    }
}
