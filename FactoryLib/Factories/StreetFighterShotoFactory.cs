using FactoryLib.Characters;

namespace FactoryLib.Factories
{
    public class StreetFighterShotoFactory : ShotoFactory
    {
        public override void CreateCharacter(string type)
        {
            if (type.ToUpper().Equals("AKUMA"))
            {
                fighter = new Akuma();
            }
            else if (type.ToUpper().Equals("RYU"))
            {
                fighter = new Ryu();
            }
        }
    }
}
