using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightDesignPattern.FlyweightDesignPattern
{
    public abstract class Character
    {
        //intrinsic
        protected char symbol;
        protected int keyKod;
        //extrinsic
        protected int pointIndex;

        public abstract void Display(int pointIndex);

    }
}
