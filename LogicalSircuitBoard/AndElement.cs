using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalSircuitBoard
{
    class AndElement : Element
    {
        private int firstInput;
        private int secondInput;

        public AndElement(bool isAvailable, string elementId, string elementType, List<Line> inputLine, List<Line> outputLine) 
            : base(isAvailable, elementId, elementType, inputLine, outputLine)
        {
        }

        public override void Calculate()
        {

        }
    }

    
}
