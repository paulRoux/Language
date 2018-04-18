using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculator
{
    class OperationSub : Operation
    {
        public override double GetResult()
        {
            double dResult = 0;
            dResult = NumberA - NumberB;
            return dResult;
        }
    }
}
