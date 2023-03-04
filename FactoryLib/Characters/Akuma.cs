using FactoryLib.Interfaces;

namespace FactoryLib.Characters
{
    public class Akuma : ShotoFighter
    {
        public string Name => "Akuma";

        public Move AntiAir()
        {
            return new Move
            {
                Name = "Roris do Akuma"
            };
        }

        public Move Fireball()
        {
            return new Move
            {
                Name = "Gadouken"
            };
        }
    }
}
