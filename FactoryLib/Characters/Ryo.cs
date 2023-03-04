using FactoryLib.Interfaces;

namespace FactoryLib.Characters
{
    public class Ryo : ShotoFighter
    {
        public string Name => "Ryo Sasazaki";

        public Move AntiAir()
        {
            return new Move
            {
                Name = "Roris do Ryo"
            };
        }

        public Move Fireball()
        {
            return new Move { 
                Name = "Ko-Ou Ken" 
            };
        }
    }
}
