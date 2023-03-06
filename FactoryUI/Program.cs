using FactoryLib;

namespace FactoryUI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //todo: ver uma forma externa
            Game[] games = new Game[] {
                new Game{ Name="Street Fighter",
                          FightersName = new string[] {"Ryu", "Akuma"} 
                },
                new Game{ Name="The King of Fighters",
                          FightersName = new string[] {"Ryo", "Kyo"} 
                },
            };
            ApplicationConfiguration.Initialize();
            Application.Run(new FrmMain(games));
        }
    }
}