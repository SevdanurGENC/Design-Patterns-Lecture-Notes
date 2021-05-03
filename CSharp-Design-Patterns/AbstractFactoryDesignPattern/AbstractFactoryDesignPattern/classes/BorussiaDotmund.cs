using AbstractFactoryDesignPattern.interfaces;

namespace AbstractFactoryDesignPattern.classes
{
    public class BorussiaDotmund : ITeam
    {
        public string GetTeamColor()
        {
            return "Black and Yellow";
        }
    }
}