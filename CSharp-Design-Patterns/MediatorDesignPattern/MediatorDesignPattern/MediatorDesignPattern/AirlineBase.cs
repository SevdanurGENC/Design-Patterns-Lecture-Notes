using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorDesignPattern.MediatorDesignPattern
{
    public abstract class AirlineBase
    {
        public string FlightCode { get; set; }
        public IAirport Airport { get; set; }

        public virtual void GetLandingPermission()
        {
            if (Airport != null)
            {
                bool hasPermissionForLanding =
                       Airport.GiveLandingPermission(FlightCode);
                if (hasPermissionForLanding)
                    Console.WriteLine("Inis izni verildi.");
                else
                    Console.WriteLine("Inis izni verilmedi!");
            }
            else
                Console.WriteLine("Ucak kaydı yapılmamış. İniş izni yok!");
        }
    }
}
