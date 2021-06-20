using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeDesignPattern.FacadeDesignPattern
{
    class FacadeUretici
    {
        IskeletOlusturu iskelet;
        MotorOlusturucu motor;
        ArabaOlusturucu olustur;

        public FacadeUretici()
        {
            iskelet = new IskeletOlusturu() { x = 3, y = 5, z = true };
            motor = new MotorOlusturucu() { x = 2, y = 4, z = false };
            olustur = new ArabaOlusturucu(iskelet, motor);
        }

        public void ArabaUret()
        {
            Araba uretilenAraba = olustur.Olustur(Renkler.Kırmızı);
        }
    }
}
