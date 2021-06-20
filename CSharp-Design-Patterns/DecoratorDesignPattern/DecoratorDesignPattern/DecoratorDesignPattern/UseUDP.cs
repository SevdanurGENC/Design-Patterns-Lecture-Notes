using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDesignPattern.DecoratorDesignPattern
{
    class UseUDP : TransportLayer
    {
        public UseUDP(IDatagram datagram) : base(datagram) { }
        private void AddUDPHeader()
        {
            Console.WriteLine("UDP protokolü devreye sokuldu.");
        }
        public override void Send()
        {
            AddUDPHeader();
            base.Send();
        }
    }
}
