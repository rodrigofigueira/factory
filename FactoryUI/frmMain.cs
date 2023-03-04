using FactoryLib;
using FactoryLib.Factories;
using FactoryLib.Interfaces;

namespace FactoryUI
{
    public partial class frmMain : Form
    {
        //todo: rever refinamento        
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
                ClearDataFighter();
            }
        }

        private void ClearDataFighter()
        {
            lblMoveName.Text = string.Empty;
            pbFighter.ImageLocation = string.Empty;
        }

        private void loadFighterComboBox(string gameName)
        {
            string[]? fightersNames = GetFightersNames(gameName);

            if (fightersNames is not null)
                FillFighterComboBox(fightersNames);

            ClearDataFighter();
        }

        private string[]? GetFightersNames(string gameName)
        {
            Game? gameSelected = _games.Where(game => game.Name.Contains(gameName))
                                       .FirstOrDefault();
            return gameSelected?.FightersName;
        }

        private void FillFighterComboBox(string[] fightersNames)
        {
            ClearComboBox(cbChoiceFighter);

            foreach (string fighterName in fightersNames)
            {
                cbChoiceFighter.Items.Add(fighterName);
            }
            
        }

        private void ClearComboBox(ComboBox comboBox)
        {
            comboBox.Items.Clear();
        }

        private void cbChoiceFighter_SelectedIndexChanged(object sender, EventArgs e)
        {
            string fighterName = (sender as ComboBox).Text;
            _factory?.CreateCharacter(fighterName);
            _fighter = _factory?.GetFighter;            
            SetImage(_fighter?.ImgMain);
            ClearMoveName();
        }

        private void ClearMoveName()
        {
            lblMoveName.Text = string.Empty;
        }

        private void SetMoveName(string? imgPath)
        {
            lblMoveName.Text = imgPath;
        }

        private void SetImage(string? imgPath)
        {
            pbFighter.ImageLocation = imgPath;
        }

        private void btnFireball_Click(object sender, EventArgs e)
        {
            SetMoveName(_fighter?.Fireball().Name);
            SetImage(_fighter?.Fireball().ImagePath);
        }

        private void btnDragonPunch_Click(object sender, EventArgs e)
        {
            SetMoveName(_fighter?.DragonPunch().Name);
            SetImage(_fighter?.DragonPunch().ImagePath);
        }

        private void btnShowMainImage_Click(object sender, EventArgs e)
        {
            SetImage(_fighter?.ImgMain);
        }

    }
}