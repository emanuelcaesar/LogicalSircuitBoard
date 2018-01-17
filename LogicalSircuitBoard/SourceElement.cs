using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalSircuitBoard
{
    class SourceElement : Element
    {
        private System.Drawing.Color colorinput;
        int value;

        public SourceElement(bool isAvailable, string elementId, string elementType, List<Line> inputLine, List<Line> outputLine) : base(isAvailable, elementId, elementType, inputLine, outputLine)
        {
        }
        public SourceElement()
        {

        }
        
        public void SetColorInput(System.Drawing.Color colorinput)
        {
            this.colorinput = colorinput;
            Calculate();
        }
        public int GetValue()
        {
            return value;
        }

        public override void Calculate()
        {
            if (colorinput == System.Drawing.Color.Green)
            {
                value = 1;
            }
            else
                value = 0;

        }

    }
}
