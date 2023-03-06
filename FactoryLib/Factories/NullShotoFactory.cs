using FactoryLib.Characters;

namespace FactoryLib.Factories
{
    public class NullShotoFactory : ShotoFactory
    {
        public override void CreateCharacter(string type)
        {
            fighter = new NullFighter();
        }
    }
}
