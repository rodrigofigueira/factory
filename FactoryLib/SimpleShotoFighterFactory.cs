using FactoryLib.Factories;

namespace FactoryLib
{
    public static class SimpleShotoFighterFactory
    {
        public static ShotoFactory? Create(string name)
        {
            switch (name)
            {
                case "Street Fighter": return new StreetFighterShotoFactory();
                case "The King of Fighters": return new KofShotoFactory();
                default: return null;
            }
        }
    }
}
