using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactoryDesignPattern.interfaces;

namespace AbstractFactoryDesignPattern.classes
{
    public class LaLigaFactory : IFootballFactory
    {
        public IPlayer CreatePlayer()
        {
            return new LaLigaPlayer();
        }

        public ITeam CreateTeam()
        {
            return new RealMadrid();
        }
    }
}
