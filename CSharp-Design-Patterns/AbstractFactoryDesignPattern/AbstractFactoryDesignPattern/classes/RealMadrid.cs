using AbstractFactoryDesignPattern.interfaces;

namespace AbstractFactoryDesignPattern.classes
{
    public class RealMadrid : ITeam
    {
        public string GetTeamColor()
        {
            return "Blue and white";
        }
    }
}