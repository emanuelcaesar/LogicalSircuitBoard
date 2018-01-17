using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalSircuitBoard
{
    class SinkElement : Element
    {
        private int input;

        public SinkElement(bool isAvailable, string elementId, string elementType, List<Line> inputLine, List<Line> outputLine) : base(isAvailable, elementId, elementType, inputLine, outputLine)
        {
        }


        public override void Calculate()
        {
            throw new NotImplementedException();
        }
    }
}
