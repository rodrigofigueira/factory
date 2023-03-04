using FactoryLib;
using FactoryLib.Factories;
using FactoryLib.Interfaces;

namespace FactoryUI
{
    public partial class frmMain : Form
    {

        private Game[] _games;
        private ShotoFighter? _fighter;
        private ShotoFactory? _factory;

        public frmMain(Game[] games)
        {
            InitializeComponent();
            _games = games;
            LoadGamesComboBox();
        }

        private void LoadGamesComboBox()
        {
            foreach (var game in _games)
            {
                cbChoiceGame.Items.Add(game.Name);
            }
        }

        private void cbChoiceGame_SelectedIndexChanged(object sender, EventArgs e)
        {
            string? gameName = (sender as ComboBox)?.Text;

            if (gameName is not null)
            {
                loadFighterComboBox(gameName);
                _factory = SimpleShotoFighterFactory.Create(gameName);
            }
        }

        private void loadFighterComboBox(string gameName)
        {
            string[]? fightersNames = GetFightersNames(gameName);

            if (fightersNames is not null)
                FillFighterComboBox(fightersNames);
        }

        private string[]? GetFightersNames(string gameName)
        {
            Game? gameSelected = _games.Where(game => game.Name.Contains(gameName))
                                       .FirstOrDefault();
            return gameSelected?.FightersName;
        }

        private void FillFighterComboBox(string[] fightersNames)
        {
            cbChoiceFighter.Items.Clear();

            foreach (string fighterName in fightersNames)
            {
                cbChoiceFighter.Items.Add(fighterName);
            }

            cbChoiceFighter.Text = string.Empty;
        }

        private void cbChoiceFighter_SelectedIndexChanged(object sender, EventArgs e)
        {
            string fighterName = (sender as ComboBox).Text;
            _factory?.CreateCharacter(fighterName);
            _fighter = _factory?.GetFighter;
        }

        private void btnFireball_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_fighter?.Fireball().Name);
        }

        private void btnAntiAir_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_fighter?.AntiAir().Name);
        }
    }
}