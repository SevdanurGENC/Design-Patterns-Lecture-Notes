using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDesignPattern.DecoratorDesignPattern
{
    class UseTCP : TransportLayer
    {
        public UseTCP(IDatagram datagram) : base(datagram) { }
        private void AddTCPHeader()
        {
            Console.WriteLine("TCP protokolü devreye sokuldu.");
        }
        public override void Send()
        {
            AddTCPHeader();
            base.Send();
        }
    }
}
