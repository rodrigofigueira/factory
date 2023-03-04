using FactoryLib.Interfaces;

namespace FactoryLib.Characters
{
    public class Ryu : ShotoFighter
    {
        public string Name => "Ryu";

        public Move AntiAir()
        {
            return new Move
            {
                Name = "Roooooooriuken"
            };                
        }

        public Move Fireball()
        {
            return new Move
            {
                Name = "Hadouken"
            };
        }
    }
}
