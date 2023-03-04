using FactoryLib.Interfaces;

namespace FactoryLib.Characters
{
    public class Akuma : ShotoFighter
    {
        public string Name => "Akuma";

        public string ImgMain => "https://www.fightersgeneration.com/characters/akuma-alphastand.gif";

        public Move DragonPunch()
        {
            return new Move
            {
                Name = "Shoryuken",
                ImagePath = "https://www.fightersgeneration.com/characters/akuma-ts-shoryu1.gif"
            };
        }

        public Move Fireball()
        {
            return new Move
            {
                Name = "Gadouken",
                ImagePath = "https://www.fightersgeneration.com/characters/akumahado.gif"
            };
        }
    }
}
