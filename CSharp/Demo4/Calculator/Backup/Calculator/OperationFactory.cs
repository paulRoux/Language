﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculator
{
    class OperationFactory
    {
        public static Operation CreateOperation(string strOperator)
        {
            Operation opr = null;
            switch (strOperator)
            {
                case "+":
                    opr = new OperationAdd();
                    break;
                case "-":
                    opr = new OperationSub();
                    break;
                case "*":
                    opr = new OperationMul();
                    break;
                case "/":
                    opr = new OperationDiv();
                    break;
                default:
                    throw new Exception("运算符输入错误！");
            }
            return opr;
        }
    }
}
