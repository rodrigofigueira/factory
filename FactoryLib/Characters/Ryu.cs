using FactoryLib.Interfaces;

namespace FactoryLib.Characters
{
    public class Ryu : ShotoFighter
    {
        public string Name => "Ryu";

        public string ImgMain => @"https://media.tenor.com/qTaCrewuaG0AAAAi/float-like-a-butterfly-sting-like-a-bee.gif";

        public Move DragonPunch()
        {
            return new Move
            {
                Name = "Shoryuken",
                ImagePath = @"https://media.tenor.com/VvVEu48lQGQAAAAi/street-fighter.gif"
            };                
        }

        public Move Fireball()
        {
            return new Move
            {
                Name = "Hadouken",
                ImagePath = "https://media.tenor.com/5wdslJBsaVcAAAAC/ryu-street-fighter.gif"
            };
        }
    }
}
