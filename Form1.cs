using System;
using System.Diagnostics;
using System.Windows.Forms;
using TwitchLeagueQueueBot.Managers;
using TwitchLeagueQueueBot.Objects;

namespace TwitchLeagueQueueBot
{
    public partial class Form1 : Form
    {
        internal static Form1 Instance = null;
        private bool _isRunning;
        public IRC ChatEngine = new IRC();
        private SettingsForm settingsForm = new SettingsForm();

        public Form1()
        {
            InitializeComponent();
            Instance = this;
            FilterSetting.Text = Properties.Settings.Default["Filter"].ToString();
            var whitelist = Properties.Settings.Default["Whitelist"].ToString().Split(',');
            foreach (var username in whitelist)
            {
                if (string.IsNullOrEmpty(username)) continue;
                Whitelist.Rows.Add(username);
                Whitelist.Rows[Whitelist.Rows.Count - 1].ReadOnly = true;
            }
            var blacklist = Properties.Settings.Default["Blacklist"].ToString().Split(',');
            foreach (var username in blacklist)
            {
                if (string.IsNullOrEmpty(username)) continue;
                Blacklist.Rows.Add(username);
                Blacklist.Rows[Blacklist.Rows.Count - 1].ReadOnly = true;
            }
            var queuedUsers = Properties.Settings.Default["QueuedUsers"].ToString().Split(',');
            foreach (var queuedUser in queuedUsers)
            {
                var datas = queuedUser.Split(':');
                if (string.IsNullOrEmpty(datas[0])) continue;

                QueuedUsers.Rows.Add(datas[0], datas[1]);
                QueuedUsers.Rows[QueuedUsers.Rows.Count - 1].ReadOnly = true;
            }
            TwitchChatManager.QueuedUsers = QueuedUsers;
            TwitchChatManager.Blacklist = Blacklist;
            TwitchChatManager.Whitelist = Whitelist;
            TwitchChatManager.FilterMode = FilterSetting.Text;
        }

        public void AddToQueue(string twitchName, string ign)
        {
            if(InvokeRequired)
            {
                Invoke(new Action(() => AddToQueue(twitchName, ign)));
            }
            else
            {
                lock(QueuedUsers)
                {
                    foreach(DataGridViewRow row in QueuedUsers.Rows)
                    {
                        if(row.Cells[0].Value.ToString() == twitchName)
                        {
                            row.Cells[1].Value = ign;
                            TwitchChatManager.HandleChatMessage("", string.Format("@{0} your ign has been changed to '{1}, position #{2}'", twitchName, ign, row.Index + 1), false);
                            return;
                        }
                    }
                }
                QueuedUsers.Rows.Add(twitchName, ign);
                QueuedUsers.Rows[QueuedUsers.Rows.Count - 1].ReadOnly = true;
                TwitchChatManager.HandleChatMessage("", string.Format("@{0} your are now in queue with ign '{1}', position #{2}", twitchName, ign, QueuedUsers.Rows.Count), false);
            }
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://twitch.tv/TheHesa");
        }

        private void Button1_Click(object sender, System.EventArgs e)
        {
            Properties.Settings.Default["Filter"] = FilterSetting.Text;
            var whitelist = "";
            foreach (DataGridViewRow row in Whitelist.Rows)
            {
                //DataRow row = rowView.Row;
                if(Whitelist.Rows.IndexOf(row) == Whitelist.Rows.Count-1)
                    whitelist += row.Cells[0].Value;
                else
                    whitelist += row.Cells[0].Value + ",";
            }
            Properties.Settings.Default["Whitelist"] = whitelist;
            var blacklist = "";
            foreach (DataGridViewRow row in Blacklist.Rows)
            {
                //DataRow row = rowView.Row;
                if (Blacklist.Rows.IndexOf(row) == Blacklist.Rows.Count - 1)
                    blacklist += row.Cells[0].Value;
                else
                    blacklist += row.Cells[0].Value + ",";
            }
            Properties.Settings.Default["Blacklist"] = blacklist;
            var bannedwords = "";
            foreach (DataGridViewRow row in QueuedUsers.Rows)
            {
                //DataRow row = rowView.Row;
                if (QueuedUsers.Rows.IndexOf(row) == QueuedUsers.Rows.Count - 1)
                    bannedwords += row.Cells[0].Value + ":"+ row.Cells[1].Value;
                else
                    bannedwords += row.Cells[0].Value + ":" + row.Cells[1].Value + ",";
            }
            Properties.Settings.Default["QueuedUsers"] = bannedwords;

            Properties.Settings.Default.Save(); // Saves settings in application configuration file
            if(sender != null) MessageBox.Show(@"Settings have been saved successfully.");
        }

        private void ButtonRun_Click(object sender, System.EventArgs e)
        {
            if (settingsForm == null || settingsForm.Disposing) settingsForm = new SettingsForm();
            if (string.IsNullOrEmpty(settingsForm.TwitchBotUsername.Text)
                || string.IsNullOrEmpty(settingsForm.TwitchBotKey.Text)
                || string.IsNullOrEmpty(settingsForm.TwitchMinimumLevel.Text)
            )
            {
                MessageBox.Show(@"Please fill all settings correctly.");
                return;
            }
            Button1_Click(null, e);
            _isRunning = !_isRunning;
            buttonRun.Text = _isRunning ? "Stop" : "Run";
            if (_isRunning)
            {
                TwitchChatManager.Initialize();

                ChatEngine = new IRC();
                ChatEngine.Initialize();
            }
            else
            {
                ChatEngine.Stop();
                ChatEngine = null;
                TwitchChatManager.Stop();
                //GC.Collect();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            string queuedUsers = "";
            foreach (DataGridViewRow row in QueuedUsers.Rows)
            {
                queuedUsers += row.Cells[0].Value.ToString() + ":" + row.Cells[1].Value.ToString() + ",";
            }
            if(queuedUsers.EndsWith(","))
            {
                queuedUsers.Remove(queuedUsers.Length - 1, 1);
            }
            Properties.Settings.Default["QueuedUsers"] = queuedUsers;
            Properties.Settings.Default.Save();
            Application.ExitThread();
            Application.Exit();
            Environment.Exit(0);
        }

        private void ButtonWhitelistAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Whitelist_username.Text)) return;
            Whitelist.Rows.Add(Whitelist_username.Text);
            Whitelist_username.Text = "";
            Whitelist.Rows[Whitelist.Rows.Count - 1].ReadOnly = true;

            if(string.IsNullOrEmpty(Whitelist.Rows[0].Cells[0].Value.ToString()))
                Whitelist.Rows.RemoveAt(0);
            TwitchChatManager.Whitelist = Whitelist;
        }

        private void ButtonWhitelistRemove_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow row in Whitelist.SelectedRows)
            {
                Whitelist.Rows.Remove(row);
            }
            TwitchChatManager.Whitelist = Whitelist;
        }

        private void ButtonBlacklistAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Blacklist_username.Text)) return;
            Blacklist.Rows.Add(Blacklist_username.Text);
            Blacklist_username.Text = "";
            Blacklist.Rows[Blacklist.Rows.Count - 1].ReadOnly = true;

            if (string.IsNullOrEmpty(Blacklist.Rows[0].Cells[0].Value.ToString()))
                Blacklist.Rows.RemoveAt(0);
            TwitchChatManager.Blacklist = Blacklist;
        }

        private void ButtonBlacklistRemove_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in Blacklist.SelectedRows)
            {
                Blacklist.Rows.Remove(row);
            }
            TwitchChatManager.Blacklist = Blacklist;
        }

        private void ButtonQueuedUsersRemove_Click(object sender, EventArgs e)
        {
            if(QueuedUsers.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Are you sure you want to remove the selected users?", "Are you sure?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in QueuedUsers.SelectedRows)
                    {
                        QueuedUsers.Rows.Remove(row);
                    }
                    TwitchChatManager.QueuedUsers = QueuedUsers;
                }
            }
        }

        private void FilterSetting_SelectedValueChanged(object sender, EventArgs e)
        {
            TwitchChatManager.FilterMode = FilterSetting.Text;
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            if (settingsForm == null || settingsForm.Disposing) settingsForm = new SettingsForm();
            settingsForm.ShowDialog();
        }
    }
}