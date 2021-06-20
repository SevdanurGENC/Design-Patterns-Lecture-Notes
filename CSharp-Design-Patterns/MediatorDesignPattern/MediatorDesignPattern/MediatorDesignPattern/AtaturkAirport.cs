using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorDesignPattern.MediatorDesignPattern
{
    public class AtaturkAirport : IAirport
    {
        private Dictionary<string, AirlineBase> _planes;

        public AtaturkAirport()
        {
            _planes = new Dictionary<string, AirlineBase>();
        }

        public void Register(AirlineBase airline)
        {
            if (!_planes.ContainsValue(airline))
                _planes.Add(airline.FlightCode, airline);

            airline.Airport = this;
        }

        public bool GiveLandingPermission(string flightCode)
        {
            if (_planes.ContainsKey(flightCode))
                return true;
            else
                return false;
        }
    }
}
