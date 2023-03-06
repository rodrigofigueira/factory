using FactoryLib.Interfaces;

namespace FactoryLib.Characters
{
    public class RobertGarcia : ShotoFighter
    {
        public string Name => "Robert Garcia";

        public string ImgMain => "https://static.wikia.nocookie.net/snk/images/4/4d/Robertkofxii.gif/revision/latest?cb=20100419182217";

        public Move DragonPunch()
        {
            return new Move
            {
                ImagePath = "https://static.wikia.nocookie.net/snk/images/e/e9/Ryuuga_%2796.gif/revision/latest?cb=20220705161311",
                Name = "Ryuuga"
            };
        }

        public Move Fireball()
        {
            return new Move
            {
                ImagePath = "https://static.wikia.nocookie.net/snk/images/c/c1/Ryuu-Geki_Ken_2002.gif/revision/latest?cb=20220705161004",
                Name = "Ryuu-Geki Ken"
            };
        }
    }
}
