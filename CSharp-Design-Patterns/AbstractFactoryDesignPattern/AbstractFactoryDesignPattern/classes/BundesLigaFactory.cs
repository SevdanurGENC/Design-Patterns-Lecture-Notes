using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactoryDesignPattern.interfaces;

namespace AbstractFactoryDesignPattern.classes
{
    public class BundesLigaFactory : IFootballFactory
    {
        public IPlayer CreatePlayer()
        {
            return new BundesLigaPlayer();
        }

        public ITeam CreateTeam()
        {
            return new BorussiaDotmund();
        }
    }
}
