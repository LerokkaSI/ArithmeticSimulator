using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ArithmeticSimulatorV0
{
    public partial class Form1 : Form
    {
        private UserControl currentPage;
        private MainMenu mainMenu;
        public Form1()
        {
            InitializeComponent();
        }

        public void ShowPage(UserControl page)
        {
            // Очищаем текущее содержимое
            this.Controls.Clear();

            // Создаем новую страницу
            page.Dock = DockStyle.Fill;
            this.Controls.Add(page);

            currentPage = page;
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            this.buttonStart.Enabled = false;
            ShowPage(new MainMenu());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

    }
}
