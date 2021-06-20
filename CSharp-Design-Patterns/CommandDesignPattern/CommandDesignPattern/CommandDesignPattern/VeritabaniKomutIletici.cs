using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandDesignPattern.CommandDesignPattern
{
    public class VeritabaniKomutIletici
    {
        public void Calistir(IKomut komut)
        {
            komut.Calistir();
        }
    }
}
