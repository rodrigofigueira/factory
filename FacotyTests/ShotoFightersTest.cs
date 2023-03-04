using FactoryLib;
using FactoryLib.Factories;
using FactoryLib.Interfaces;
using System.IO;
using System.Net.NetworkInformation;

namespace FactoryTests
{
    public class ShotoFightersTest
    {
        protected ShotoFactory? shotoFighterFactory;

        public static TheoryData<string, ShotoFactory> FightersValues => new()
        {
            { "ryu", new StreetFighterShotoFactory() },
            { "akuma", new StreetFighterShotoFactory() },
            { "kyo", new KofShotoFactory() },
            { "ryo", new KofShotoFactory() }
        };

        public static TheoryData<string, ShotoFactory> FactoriesValues => new()
        {
            {"Street Fighter", new StreetFighterShotoFactory() },
            {"The King of Fighters", new KofShotoFactory() }
        };

        [Theory]
        [MemberData(nameof(FightersValues))]
        public void Should_Create_Fighters_And_Validate_Name(string name, ShotoFactory factory)
        {
            shotoFighterFactory = factory;
            shotoFighterFactory?.CreateCharacter(name);
            ShotoFighter? fighter = shotoFighterFactory?.GetFighter;
            Assert.NotNull(fighter);
            Assert.True(fighter.Name?.ToUpper().Contains(name.ToUpper()));
        }

        [Theory]
        [MemberData(nameof(FactoriesValues))]
        public void Should_Create_Factories(string game, ShotoFactory factory)
        {
            var createdFactory = SimpleShotoFighterFactory.Create(game);
            Assert.NotNull(createdFactory);
            Assert.Equal(createdFactory.GetType(), factory.GetType());
        }

    }
}