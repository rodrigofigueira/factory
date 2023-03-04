using FactoryLib.Interfaces;

namespace FactoryLib.Characters
{
    public class Kyo : ShotoFighter
    {
        public string Name => "Kyo Kusanagi";

        public Move AntiAir()
        {
            return new Move
            {
                Name = "Fúúúúúúria"
            };
        }

        public Move Fireball()
        {
            return new Move
            {
                Name = "108 Shiki Yami Barai"
            };
        }
    }
}
