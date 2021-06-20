using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightDesignPattern.FlyweightDesignPattern
{
    public class CharacterA : Character
    {
        public CharacterA()
        {
            this.symbol = 'A';
            this.keyKod = 1;
        }

        public override void Display(int pointIndex)
        {
            this.pointIndex = pointIndex;
            Console.WriteLine(this.symbol + " (pointIndex " + this.pointIndex + ")");
        }
    }
}
