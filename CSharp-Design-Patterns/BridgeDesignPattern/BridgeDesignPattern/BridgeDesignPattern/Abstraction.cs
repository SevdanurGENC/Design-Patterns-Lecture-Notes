using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeDesignPattern.BridgeDesignPattern
{
    class Abstraction
    {
        Bridge bridge;

        public Abstraction(Bridge Implementation)
        { bridge = Implementation; }

        public string Operation()
        {
            return "Abstraction <> " + bridge.OperationImp();
        }
    }
}
