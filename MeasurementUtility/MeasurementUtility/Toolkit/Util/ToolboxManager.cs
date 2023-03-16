using System;
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
        List<ITool> tools = new List<ITool>();

        public void AddTool(ITool tool)
        {
            if(tools.Count >= MAXCAPACITY)
            {
                // warning
            }
            else
            {
                tools.Add(tool);
            }
        }
        // Setup Tools
        public void SetupTools(string path)
        {

        }
        public void SaveSnapshot()
        {
            //tools[selected]
        }
    }
}
