using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandDesignPattern.CommandDesignPattern
{
    public class SiparisGuncellemeKomutu : IKomut
    {
        private SiparisIslemleri siparisIslemleri;
        public SiparisGuncellemeKomutu(SiparisIslemleri siparisIslemleri)
        {
            this.siparisIslemleri = siparisIslemleri;
        }
        public void Calistir()
        {
            siparisIslemleri.SiparisGuncelle();
        }
    }
}
