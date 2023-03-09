namespace FactoryLib
{
    public static class Games
    {
        public static Game[] Get()
        {
            return new Game[] {
                new Game{ Name="Street Fighter",
                          FightersName = new string[] {"Ryu", "Akuma"}
                },
                new Game{ Name="The King of Fighters",
                          FightersName = new string[] {"Ryo", "Kyo", "Robert Garcia"}
                },
            };
        }
    }
}
