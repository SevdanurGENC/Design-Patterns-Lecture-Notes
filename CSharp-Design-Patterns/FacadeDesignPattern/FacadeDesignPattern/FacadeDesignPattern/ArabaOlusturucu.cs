using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeDesignPattern.FacadeDesignPattern
{
    class ArabaOlusturucu
    {
        public IskeletOlusturu Iskelet { get; set; }
        public MotorOlusturucu Motor { get; set; }
        public ArabaOlusturucu(IskeletOlusturu Iskelet, MotorOlusturucu Motor)
        {
            this.Iskelet = Iskelet;
            this.Motor = Motor;
        }

        public Araba Olustur(Renkler renk)
        {
            return new Araba(Iskelet, Motor, renk);
        }
    }
}
