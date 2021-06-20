using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightDesignPattern.FlyweightDesignPattern
{
    public class CharacterZ : Character
    {
        public CharacterZ()
        {
            this.symbol = 'Z';
            this.keyKod = 29;
        }

        public override void Display(int pointIndex)
        {
            this.pointIndex = pointIndex;
            Console.WriteLine(this.symbol + " (pointIndex " + this.pointIndex + ")");
        }
    }
}
