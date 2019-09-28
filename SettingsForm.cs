using System;
using System.Windows.Forms;

namespace TwitchLeagueQueueBot
{
    public partial class SettingsForm : Form
    {
        private BrowserForm _browserForm;

        public SettingsForm()
        {
            InitializeComponent();
            TwitchBotUsername.Text = Properties.Settings.Default["TwitchBotUsername"].ToString();
            TwitchBotKey.Text = Properties.Settings.Default["TwitchBotKey"].ToString();
            TwitchMinimumLevel.Text = Properties.Settings.Default["TwitchMinimumLevel"].ToString();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default["TwitchBotUsername"] = TwitchBotUsername.Text;
            Properties.Settings.Default["TwitchBotKey"] = TwitchBotKey.Text;
            Properties.Settings.Default["TwitchMinimumLevel"] = TwitchMinimumLevel.Text;
            Properties.Settings.Default.Save(); // Saves settings in application configuration file
            if (sender != null) MessageBox.Show(@"Settings have been saved successfully.");
            Hide();
        }

        private void ButtonGrabKey_Click(object sender, EventArgs e)
        {
            _browserForm = new BrowserForm { AccessKeyTextBox = TwitchBotKey };
            _browserForm.ShowDialog();
        }
    }
}
