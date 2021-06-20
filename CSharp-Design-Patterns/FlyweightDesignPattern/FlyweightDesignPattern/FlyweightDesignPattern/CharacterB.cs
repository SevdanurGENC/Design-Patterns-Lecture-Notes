using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightDesignPattern.FlyweightDesignPattern
{
    public class CharacterB : Character
    {
        public CharacterB()
        {
            this.symbol = 'B';
            this.keyKod = 2;
        }

        public override void Display(int pointIndex)
        {
            this.pointIndex = pointIndex;
            Console.WriteLine(this.symbol + " (pointIndex " + this.pointIndex + ")");
        }
    }
}
