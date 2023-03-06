using FactoryLib.Interfaces;

namespace FactoryLib.Factories
{
    public abstract class ShotoFactory
    {
        protected ShotoFighter fighter;

        public abstract void CreateCharacter(string type);

        public ShotoFighter GetFighter => fighter;

    }
}
