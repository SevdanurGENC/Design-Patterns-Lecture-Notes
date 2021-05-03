using AbstractFactoryDesignPattern.interfaces;

namespace AbstractFactoryDesignPattern.classes
{
    public class BundesLigaPlayer : IPlayer
    {
        public string GetTopScorer()
        {
            return "Robert Lewandowski";
        }
    }
}