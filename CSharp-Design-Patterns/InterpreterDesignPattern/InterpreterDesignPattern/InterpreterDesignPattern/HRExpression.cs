﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpreterDesignPattern.InterpreterDesignPattern
{
    public class HRExpression : DepartmentExpression
    {
        public override void Interpret(Context context)
        {
            context.TotalCost += 20;
        }
    }
}
