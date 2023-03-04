using FactoryLib.Characters;

namespace FactoryLib.Factories
{
    public class KofShotoFactory : ShotoFactory
    {
        public override void CreateCharacter(string type)
        {
            if (type.ToUpper().Equals("KYO"))
            {
                fighter = new Kyo();
            }
            else if (type.ToUpper().Equals("RYO"))
            {
                fighter = new Ryo();
            }
        }
    }
}
