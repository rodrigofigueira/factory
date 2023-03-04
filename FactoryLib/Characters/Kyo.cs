using FactoryLib.Interfaces;

namespace FactoryLib.Characters
{
    public class Kyo : ShotoFighter
    {
        public string Name => "Kyo Kusanagi";

        public string ImgMain => "https://static.wikia.nocookie.net/snk/images/1/1b/Kyokofxii.gif/revision/latest?cb=20100417163143";

        public Move DragonPunch()
        {
            return new Move
            {
                Name = "100 Shiki Oniyaki",
                ImagePath = "https://static.wikia.nocookie.net/snk/images/b/bd/Kyo_100_Shiki_Oniyaki_2003.gif/revision/latest?cb=20220522141006"
            };
        }

        public Move Fireball()
        {
            return new Move
            {
                Name = "108 Shiki Yami Barai",
                ImagePath = "https://static.wikia.nocookie.net/snk/images/2/24/Kyo_108_Shiki_Yami_Barai_XI.gif/revision/latest?cb=20221215041748"
            };
        }
    }
}
