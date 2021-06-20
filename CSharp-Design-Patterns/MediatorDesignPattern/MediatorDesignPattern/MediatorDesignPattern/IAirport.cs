using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorDesignPattern.MediatorDesignPattern
{
    public interface IAirport
    {
        void Register(AirlineBase airline);
        bool GiveLandingPermission(string flightCode);
    }
}
