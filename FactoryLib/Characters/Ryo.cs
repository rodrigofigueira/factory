using FactoryLib.Interfaces;

namespace FactoryLib.Characters
{
    public class Ryo : ShotoFighter
    {
        public string Name => "Ryo Sasazaki";

        public string ImgMain => "https://static.wikia.nocookie.net/snk/images/8/8b/Ryokofxii.gif/revision/latest?cb=20100411130822";

        public Move DragonPunch()
        {
            return new Move
            {
                Name = "Ko Hou",
                ImagePath = "https://static.wikia.nocookie.net/snk/images/c/c6/Kohou_%2798.gif/revision/latest?cb=20220513054641"
            };
        }

        public Move Fireball()
        {
            return new Move { 
                Name = "Ko-Ou Ken",
                ImagePath = "https://static.wikia.nocookie.net/snk/images/b/be/Ryo_Ko-Ou_Ken_%2796.gif/revision/latest?cb=20220513054840"
            };
        }
    }
}
