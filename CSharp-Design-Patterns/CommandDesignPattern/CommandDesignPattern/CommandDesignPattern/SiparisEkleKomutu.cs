using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandDesignPattern.CommandDesignPattern
{
    public class SiparisEkleKomutu : IKomut
    {
        private SiparisIslemleri siparisIslemleri;
        public SiparisEkleKomutu(SiparisIslemleri siparisIslemleri)
        {
            this.siparisIslemleri = siparisIslemleri;
        }

        public void Calistir()
        {
            siparisIslemleri.YeniSiparisEkle();
        }
    }
}
