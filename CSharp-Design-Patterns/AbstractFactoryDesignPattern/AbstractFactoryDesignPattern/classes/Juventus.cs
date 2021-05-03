using AbstractFactoryDesignPattern.interfaces;

namespace AbstractFactoryDesignPattern.classes
{
    public class Juventus : ITeam
    {
        public string GetTeamColor()
        {
            return "Black and White";
        }
    }
}