using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeDesignPattern.BridgeDesignPattern
{
    class ImplementationA : Bridge
    {
        public string OperationImp()
        {
            return "Implementation A";
        }
    }
}
