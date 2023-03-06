using FactoryLib;
using FactoryLib.Factories;
using FactoryLib.Interfaces;

namespace FactoryUI
{
    public partial class FrmMain : Form
    {
        private Game[] _games = null!;
        private ShotoFighter _fighter = null!;
        private ShotoFactory _factory = null!;

        public FrmMain(Game[] games)
        {
            InitializeComponent();
            SetArrayOfGames(games);
            LoadGamesComboBox();
        }

        private void SetArrayOfGames(Game[] games)
        {
            _games = games;
        }

        private void LoadGamesComboBox()
        {
            foreach (var game in _games)
            {
                CbChoiceGame.AddItem(game.Name);
            }
        }

        private void CbChoiceGame_SelectedIndexChanged(object sender, EventArgs e)
        {
            string gameName = CbChoiceGame.Text;

            CbChoiceFighter.ClearItemsAndText();
            LoadFighterComboBox(gameName);
            CreateFactory(gameName);
            ClearMoveName();
            ClearImage();
        }

        private void LoadFighterComboBox(string gameName)
        {
            string[] fightersNames = GetFightersNames(gameName);
            FillFighterComboBox(fightersNames);
            ClearImage();
            ClearMoveName();
        }

        private string[] GetFightersNames(string gameName)
        {
            Game? gameSelected = _games.Where(game => game.Name is not null &&
                                                      game.Name.Contains(gameName))
                                       .FirstOrDefault();

            if (gameSelected is null || gameSelected.FightersName is null)
                return new string[] { "Not found" };

            return gameSelected.FightersName;
        }

        private void FillFighterComboBox(string[] fightersNames)
        {
            CbChoiceFighter.ClearItemsAndText();

            foreach (string fighterName in fightersNames)
            {
                CbChoiceFighter.AddItem(fighterName);
            }

        }

        private void CreateFactory(string _gameName)
        {
            _factory = SimpleShotoFighterFactory.Create(_gameName);
        }

        private void ClearImage()
        {
            PbFighter.ImageLocation = string.Empty;
        }

        private void ClearMoveName()
        {
            LblMoveName.Clear();
        }

        private void CbChoiceFighter_SelectedIndexChanged(object sender, EventArgs e)
        {
            string fighterName = CbChoiceFighter.Text;
            CreateFighter(fighterName);
            SetImage(_fighter.ImgMain);
            ClearMoveName();
        }

        private void CreateFighter(string fighterName)
        {
            _factory.CreateCharacter(fighterName);
            _fighter = _factory.GetFighter;
        }

        private void SetImage(string imgPath)
        {
            PbFighter.ImageLocation = imgPath;
        }

        private void SetMoveName(string imgPath)
        {
            LblMoveName.Text = imgPath;
        }

        private void BtnFireball_Click(object sender, EventArgs e)
        {
            Move fireball = _fighter.Fireball();
            SetDataFighter(fireball);
        }

        private void BtnDragonPunch_Click(object sender, EventArgs e)
        {
            Move dragonPunch = _fighter.DragonPunch();
            SetDataFighter(dragonPunch);
        }
        
        private void SetDataFighter(Move move)
        {
            SetMoveName(move.Name);
            SetImage(move.ImagePath);
        }

        private void BtnShowMainImage_Click(object sender, EventArgs e)
        {
            SetImage(_fighter.ImgMain);
            LblMoveName.Clear();
        }

    }

}