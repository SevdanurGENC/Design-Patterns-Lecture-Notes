using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeDesignPattern.FacadeDesignPattern
{
    class Araba
    {
        public Araba(IskeletOlusturu Iskelet, MotorOlusturucu Motor, Renkler Renk)
        {
            Console.WriteLine($"Iskelet x = {Iskelet.x}");
            Console.WriteLine($"Iskelet y = {Iskelet.y}");
            Console.WriteLine($"Iskelet z = {Iskelet.z}");
            Console.WriteLine($"Motor x = {Motor.x}");
            Console.WriteLine($"Motor y = {Motor.y}");
            Console.WriteLine($"Motor z = {Motor.z}");
            Console.WriteLine($"Renk = {Renk}");
        }
    }
}
