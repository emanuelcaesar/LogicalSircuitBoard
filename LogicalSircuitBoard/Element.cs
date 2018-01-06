using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalSircuitBoard
{
    class Element
    {
        private bool isAvailable;
        private string elementId;
        private string elementType;
        private List<Line> inputLine;
        private List<Line> outputLine;

        public Element(bool isAvailable, string elementId, string elementType, List<Line> inputLine, List<Line> outputLine)
        {
            this.isAvailable = isAvailable;
            this.elementId = elementId;
            this.elementType = elementType;
            this.inputLine = inputLine;
            this.outputLine = outputLine;
        }

        public bool getIsAvailable()
        {
            return isAvailable;
        }
        
        public string getElementId()
        {
            return elementId;
        }

        public string getElementType()
        {
            return elementType;
        }

        public void Calculate()
        {

        }

        public void CalculateStartArea(System.Drawing.Point start)
        {

        }

        public void CalculateGoalArea(System.Drawing.Point goal)
        {

        }

    }
}
