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
            Game[] games = Games.Get(); 
            ApplicationConfiguration.Initialize();
            Application.Run(new FrmMain(games));
        }
    }
}