using FactoryLib;
using FactoryLib.Factories;
using FactoryLib.Interfaces;

namespace FactoryUI
{
    public partial class frmMain : Form
    {
        private Game[] _games;
        private ShotoFighter _fighter = null!;
        private ShotoFactory _factory = null!;

        public frmMain(Game[] games)
        {
            InitializeComponent();
            _games = games;
            LoadGamesComboBox();
        }

        private void LoadGamesComboBox()
        {
            cbChoiceGame.DataSource = _games.Select(g => g.Name).ToList();
        }

        private void cbChoiceGame_SelectedIndexChanged(object sender, EventArgs e)
        {
            string gameName = cbChoiceGame.Text;

            cbChoiceFighter.ClearItemAndText();
            LoadFighterComboBox(gameName);
            CreateFactory(gameName);
            ClearMoveName();
            ClearImage();
        }

        private void CreateFactory(string _gameName)
        {
            _factory = SimpleShotoFighterFactory.Create(_gameName);
        }

        private void LoadFighterComboBox(string gameName)
        {
            string[] fightersNames = GetFightersNames(gameName);

            if (fightersNames is not null)
                FillFighterComboBox(fightersNames);

            ClearImage();
            ClearMoveName();
        }

        private void ClearImage()
        {
            pbFighter.ImageLocation = string.Empty;
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
            cbChoiceFighter.ClearItemAndText();
            foreach (string fighterName in fightersNames)
            {
                cbChoiceFighter.AddItem(fighterName);
            }

        }

        private void cbChoiceFighter_SelectedIndexChanged(object sender, EventArgs e)
        {
            string fighterName = cbChoiceFighter.Text;
            CreateFighter(fighterName);
            SetImage(_fighter.ImgMain);
            ClearMoveName();
        }

        private void CreateFighter(string fighterName)
        {
            _factory.CreateCharacter(fighterName);
            _fighter = _factory.GetFighter;
        }

        private void ClearMoveName()
        {
            lblMoveName.Clear();
        }

        private void SetMoveName(string imgPath)
        {
            lblMoveName.Text = imgPath;
        }

        private void SetImage(string imgPath)
        {
            pbFighter.ImageLocation = imgPath;
        }

        private void btnFireball_Click(object sender, EventArgs e)
        {
            Move fireball = _fighter.Fireball();
            SetMoveName(fireball.Name);
            SetImage(fireball.ImagePath);
        }

        private void btnDragonPunch_Click(object sender, EventArgs e)
        {
            Move dragonPunch = _fighter.DragonPunch();
            SetMoveName(dragonPunch.Name);
            SetImage(dragonPunch.ImagePath);
        }

        private void btnShowMainImage_Click(object sender, EventArgs e)
        {
            SetImage(_fighter.ImgMain);
            lblMoveName.Clear();
        }

    }
}