using FactoryLib.Interfaces;

namespace FactoryLib.Characters
{
    public class NullFighter : ShotoFighter
    {
        public string Name => "Name not defined";

        public string ImgMain => "https://user-images.githubusercontent.com/24848110/33519396-7e56363c-d79d-11e7-969b-09782f5ccbab.png";

        public Move DragonPunch()
        {
            return new Move
            {
                Name = "Not Defined",
                ImagePath = "https://user-images.githubusercontent.com/24848110/33519396-7e56363c-d79d-11e7-969b-09782f5ccbab.png"
            };
        }

        public Move Fireball()
        {
            return new Move
            {
                Name = "Not Defined",
                ImagePath = "https://user-images.githubusercontent.com/24848110/33519396-7e56363c-d79d-11e7-969b-09782f5ccbab.png"
            };

        }
    }
}
