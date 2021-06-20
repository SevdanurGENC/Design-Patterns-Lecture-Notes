using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorDesignPattern.MediatorDesignPattern
{
    public class THYAirline : AirlineBase
    {
        public override void GetLandingPermission()
        {
            Console.WriteLine(FlightCode + " nolu THY ucağı inis icin izin gonderdi.");
            base.GetLandingPermission();
        }
    }
}
