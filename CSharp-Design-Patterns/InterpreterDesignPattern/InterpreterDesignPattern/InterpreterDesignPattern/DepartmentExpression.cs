using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpreterDesignPattern.InterpreterDesignPattern
{
    public abstract class DepartmentExpression
    {
        public abstract void Interpret(Context context);
    }
}
