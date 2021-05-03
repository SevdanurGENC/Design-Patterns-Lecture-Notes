using AbstractFactoryDesignPattern.interfaces;

namespace AbstractFactoryDesignPattern.classes
{
    public class LaLigaPlayer : IPlayer
    {
        public string GetTopScorer()
        {
            return "Lionel Messi";
        }
    }
}