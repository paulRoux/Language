using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculator
{
    class OperationDiv : Operation
    {
        public override double GetResult()
        {
            double dResult = 0;
            if (NumberB == 0)
            {
                throw new Exception("除数不能为0！");
            }
            dResult = NumberA / NumberB;
            return dResult;
        }
    }
}
