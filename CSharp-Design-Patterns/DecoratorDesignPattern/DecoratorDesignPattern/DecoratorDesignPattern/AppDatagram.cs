using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDesignPattern.DecoratorDesignPattern
{
    class AppDatagram : IDatagram
    {
        public void Send()
        {
            Console.WriteLine("IP datagram gönder.");
        }
    }
}
