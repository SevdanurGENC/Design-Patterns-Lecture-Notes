using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDesignPattern.DecoratorDesignPattern
{
    class TransportLayer : IDatagram
    {
        readonly IDatagram _datagram;
        public TransportLayer(IDatagram datagram)
        {
            _datagram = datagram;
        }
        virtual public void Send()
        {
            _datagram.Send();
        }
    }
}
