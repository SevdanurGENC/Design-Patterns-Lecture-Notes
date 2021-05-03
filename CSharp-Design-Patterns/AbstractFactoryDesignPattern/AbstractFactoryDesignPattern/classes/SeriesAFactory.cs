using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactoryDesignPattern.interfaces;

namespace AbstractFactoryDesignPattern.classes
{
    public class SeriesAFactory : IFootballFactory
    {
        public IPlayer CreatePlayer()
        {
            return new SeriesAPlayer();
        }

        public ITeam CreateTeam()
        {
            return new Juventus();
        }
    }
}
