using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoDesignPattern.MementoDesignPattern
{
    public class Memento<T>
    {
        private readonly T _state;

        public Memento(T state)
        {
            _state = state;
        }

        public T State
        {
            get { return _state; }
        }
    }
}
