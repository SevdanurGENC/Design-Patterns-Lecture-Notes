using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoDesignPattern.MementoDesignPattern
{
    public class CareTaker<T>
    {
        private readonly List<Memento<T>> _mementoList;

        public CareTaker()
        {
            _mementoList = new List<Memento<T>>();
        }

        public void Add(Memento<T> state)
        {
            _mementoList.Add(state);
        }

        public Memento<T> this[int index]
        {
            get { return _mementoList[index]; }
        }
    }
}
