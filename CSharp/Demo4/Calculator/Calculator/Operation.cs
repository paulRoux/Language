using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculator
{
    class Operation
    {
        private double m_dNumberA;
        private double m_dNumberB;
        
        public double NumberA
        {
            get
            {
                return m_dNumberA;
            }
            set
            {
                m_dNumberA = value;
            }
        }

        public double NumberB
        {
            get
            {
                return m_dNumberB;
            }
            set
            {
                m_dNumberB = value;
            }
        }

        public virtual double GetResult()
        {
            double dResult = 0;
            return dResult;
    //        return 0;
        }
    }
}
