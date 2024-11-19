namespace HowToUseControls
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            // Hide all controls
            exampleControl.Hide();
            homeControl.Hide();
            settingsControl.Hide();
        }

        private void exampleButton_Click(object sender, EventArgs e)
        {
            exampleControl.Show();
            homeControl.Hide();
            settingsControl.Hide();
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            exampleControl.Hide();
            homeControl.Show();
            settingsControl.Hide();
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            exampleControl.Hide();
            homeControl.Hide();
            settingsControl.Show();
        }
    }
}
