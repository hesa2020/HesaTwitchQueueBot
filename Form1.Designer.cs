﻿namespace TwitchLeagueQueueBot
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonRun = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.ButtonWhitelistAdd = new System.Windows.Forms.Button();
            this.ButtonWhitelistRemove = new System.Windows.Forms.Button();
            this.Whitelist_username = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Whitelist = new System.Windows.Forms.DataGridView();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label10 = new System.Windows.Forms.Label();
            this.ButtonBlacklistAdd = new System.Windows.Forms.Button();
            this.ButtonBlacklistRemove = new System.Windows.Forms.Button();
            this.Blacklist_username = new System.Windows.Forms.TextBox();
            this.Blacklist = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FilterSetting = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.ButtonQueuedUsersRemove = new System.Windows.Forms.Button();
            this.QueuedUsers = new System.Windows.Forms.DataGridView();
            this.SettingsButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SpotifyTimer = new System.Windows.Forms.Timer(this.components);
            this.BannedText = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BannedPattern = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Whitelist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Blacklist)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QueuedUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonRun
            // 
            this.buttonRun.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRun.Location = new System.Drawing.Point(691, 429);
            this.buttonRun.Name = "buttonRun";
            this.buttonRun.Size = new System.Drawing.Size(75, 23);
            this.buttonRun.TabIndex = 4;
            this.buttonRun.Text = "Run";
            this.buttonRun.UseVisualStyleBackColor = true;
            this.buttonRun.Click += new System.EventHandler(this.ButtonRun_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.splitContainer1);
            this.groupBox3.Controls.Add(this.FilterSetting);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Location = new System.Drawing.Point(384, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(388, 411);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Blacklist / Whitelist Settings";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Location = new System.Drawing.Point(9, 46);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.ButtonWhitelistAdd);
            this.splitContainer1.Panel1.Controls.Add(this.ButtonWhitelistRemove);
            this.splitContainer1.Panel1.Controls.Add(this.Whitelist_username);
            this.splitContainer1.Panel1.Controls.Add(this.label9);
            this.splitContainer1.Panel1.Controls.Add(this.Whitelist);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.label10);
            this.splitContainer1.Panel2.Controls.Add(this.ButtonBlacklistAdd);
            this.splitContainer1.Panel2.Controls.Add(this.ButtonBlacklistRemove);
            this.splitContainer1.Panel2.Controls.Add(this.Blacklist_username);
            this.splitContainer1.Panel2.Controls.Add(this.Blacklist);
            this.splitContainer1.Size = new System.Drawing.Size(373, 359);
            this.splitContainer1.SplitterDistance = 184;
            this.splitContainer1.TabIndex = 12;
            // 
            // ButtonWhitelistAdd
            // 
            this.ButtonWhitelistAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonWhitelistAdd.Location = new System.Drawing.Point(215, 157);
            this.ButtonWhitelistAdd.Name = "ButtonWhitelistAdd";
            this.ButtonWhitelistAdd.Size = new System.Drawing.Size(75, 23);
            this.ButtonWhitelistAdd.TabIndex = 19;
            this.ButtonWhitelistAdd.Text = "Add";
            this.ButtonWhitelistAdd.UseVisualStyleBackColor = true;
            this.ButtonWhitelistAdd.Click += new System.EventHandler(this.ButtonWhitelistAdd_Click);
            // 
            // ButtonWhitelistRemove
            // 
            this.ButtonWhitelistRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonWhitelistRemove.Location = new System.Drawing.Point(296, 157);
            this.ButtonWhitelistRemove.Name = "ButtonWhitelistRemove";
            this.ButtonWhitelistRemove.Size = new System.Drawing.Size(75, 23);
            this.ButtonWhitelistRemove.TabIndex = 18;
            this.ButtonWhitelistRemove.Text = "Remove";
            this.ButtonWhitelistRemove.UseVisualStyleBackColor = true;
            this.ButtonWhitelistRemove.Click += new System.EventHandler(this.ButtonWhitelistRemove_Click);
            // 
            // Whitelist_username
            // 
            this.Whitelist_username.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Whitelist_username.Location = new System.Drawing.Point(3, 159);
            this.Whitelist_username.Name = "Whitelist_username";
            this.Whitelist_username.Size = new System.Drawing.Size(206, 20);
            this.Whitelist_username.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 6);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Whitelisted:";
            // 
            // Whitelist
            // 
            this.Whitelist.AllowUserToAddRows = false;
            this.Whitelist.AllowUserToDeleteRows = false;
            this.Whitelist.AllowUserToResizeColumns = false;
            this.Whitelist.AllowUserToResizeRows = false;
            this.Whitelist.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Whitelist.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.Whitelist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Whitelist.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Username});
            this.Whitelist.Location = new System.Drawing.Point(3, 22);
            this.Whitelist.Name = "Whitelist";
            this.Whitelist.RowHeadersVisible = false;
            this.Whitelist.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.Whitelist.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Whitelist.ShowCellErrors = false;
            this.Whitelist.ShowCellToolTips = false;
            this.Whitelist.ShowEditingIcon = false;
            this.Whitelist.ShowRowErrors = false;
            this.Whitelist.Size = new System.Drawing.Size(365, 129);
            this.Whitelist.TabIndex = 15;
            // 
            // Username
            // 
            this.Username.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Username.HeaderText = "Username";
            this.Username.Name = "Username";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 5);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "Blacklisted:";
            // 
            // ButtonBlacklistAdd
            // 
            this.ButtonBlacklistAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonBlacklistAdd.Location = new System.Drawing.Point(215, 143);
            this.ButtonBlacklistAdd.Name = "ButtonBlacklistAdd";
            this.ButtonBlacklistAdd.Size = new System.Drawing.Size(75, 23);
            this.ButtonBlacklistAdd.TabIndex = 23;
            this.ButtonBlacklistAdd.Text = "Add";
            this.ButtonBlacklistAdd.UseVisualStyleBackColor = true;
            this.ButtonBlacklistAdd.Click += new System.EventHandler(this.ButtonBlacklistAdd_Click);
            // 
            // ButtonBlacklistRemove
            // 
            this.ButtonBlacklistRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonBlacklistRemove.Location = new System.Drawing.Point(293, 143);
            this.ButtonBlacklistRemove.Name = "ButtonBlacklistRemove";
            this.ButtonBlacklistRemove.Size = new System.Drawing.Size(75, 23);
            this.ButtonBlacklistRemove.TabIndex = 22;
            this.ButtonBlacklistRemove.Text = "Remove";
            this.ButtonBlacklistRemove.UseVisualStyleBackColor = true;
            this.ButtonBlacklistRemove.Click += new System.EventHandler(this.ButtonBlacklistRemove_Click);
            // 
            // Blacklist_username
            // 
            this.Blacklist_username.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Blacklist_username.Location = new System.Drawing.Point(3, 145);
            this.Blacklist_username.Name = "Blacklist_username";
            this.Blacklist_username.Size = new System.Drawing.Size(206, 20);
            this.Blacklist_username.TabIndex = 21;
            // 
            // Blacklist
            // 
            this.Blacklist.AllowUserToAddRows = false;
            this.Blacklist.AllowUserToDeleteRows = false;
            this.Blacklist.AllowUserToResizeColumns = false;
            this.Blacklist.AllowUserToResizeRows = false;
            this.Blacklist.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Blacklist.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.Blacklist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Blacklist.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            this.Blacklist.Location = new System.Drawing.Point(3, 21);
            this.Blacklist.Name = "Blacklist";
            this.Blacklist.RowHeadersVisible = false;
            this.Blacklist.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Blacklist.Size = new System.Drawing.Size(362, 116);
            this.Blacklist.TabIndex = 20;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.HeaderText = "Username";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // FilterSetting
            // 
            this.FilterSetting.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FilterSetting.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FilterSetting.FormattingEnabled = true;
            this.FilterSetting.Items.AddRange(new object[] {
            "Blacklist Only",
            "None",
            "Whitelist Only"});
            this.FilterSetting.Location = new System.Drawing.Point(145, 19);
            this.FilterSetting.Name = "FilterSetting";
            this.FilterSetting.Size = new System.Drawing.Size(237, 21);
            this.FilterSetting.Sorted = true;
            this.FilterSetting.TabIndex = 9;
            this.FilterSetting.SelectedValueChanged += new System.EventHandler(this.FilterSetting_SelectedValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Filter:";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox4.Controls.Add(this.ButtonQueuedUsersRemove);
            this.groupBox4.Controls.Add(this.QueuedUsers);
            this.groupBox4.Location = new System.Drawing.Point(12, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(366, 411);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Queue";
            // 
            // ButtonQueuedUsersRemove
            // 
            this.ButtonQueuedUsersRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonQueuedUsersRemove.Location = new System.Drawing.Point(6, 382);
            this.ButtonQueuedUsersRemove.Name = "ButtonQueuedUsersRemove";
            this.ButtonQueuedUsersRemove.Size = new System.Drawing.Size(354, 23);
            this.ButtonQueuedUsersRemove.TabIndex = 24;
            this.ButtonQueuedUsersRemove.Text = "Remove";
            this.ButtonQueuedUsersRemove.UseVisualStyleBackColor = true;
            this.ButtonQueuedUsersRemove.Click += new System.EventHandler(this.ButtonQueuedUsersRemove_Click);
            // 
            // QueuedUsers
            // 
            this.QueuedUsers.AllowUserToAddRows = false;
            this.QueuedUsers.AllowUserToDeleteRows = false;
            this.QueuedUsers.AllowUserToResizeColumns = false;
            this.QueuedUsers.AllowUserToResizeRows = false;
            this.QueuedUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.QueuedUsers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.QueuedUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.QueuedUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BannedText,
            this.BannedPattern});
            this.QueuedUsers.Location = new System.Drawing.Point(6, 19);
            this.QueuedUsers.Name = "QueuedUsers";
            this.QueuedUsers.RowHeadersVisible = false;
            this.QueuedUsers.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.QueuedUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.QueuedUsers.ShowCellErrors = false;
            this.QueuedUsers.ShowCellToolTips = false;
            this.QueuedUsers.ShowEditingIcon = false;
            this.QueuedUsers.ShowRowErrors = false;
            this.QueuedUsers.Size = new System.Drawing.Size(354, 357);
            this.QueuedUsers.TabIndex = 16;
            // 
            // SettingsButton
            // 
            this.SettingsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SettingsButton.Location = new System.Drawing.Point(529, 429);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(75, 23);
            this.SettingsButton.TabIndex = 9;
            this.SettingsButton.Text = "Settings";
            this.SettingsButton.UseVisualStyleBackColor = true;
            this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(610, 429);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // BannedText
            // 
            this.BannedText.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BannedText.HeaderText = "Twitch Username";
            this.BannedText.Name = "BannedText";
            // 
            // BannedPattern
            // 
            this.BannedPattern.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BannedPattern.HeaderText = "In Game Name";
            this.BannedPattern.Name = "BannedPattern";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SettingsButton);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.buttonRun);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Twitch Queue Bot by Hesa <3";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Whitelist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Blacklist)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.QueuedUsers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonRun;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox FilterSetting;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button ButtonWhitelistAdd;
        private System.Windows.Forms.Button ButtonWhitelistRemove;
        private System.Windows.Forms.TextBox Whitelist_username;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.DataGridView Whitelist;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button ButtonBlacklistAdd;
        private System.Windows.Forms.Button ButtonBlacklistRemove;
        private System.Windows.Forms.TextBox Blacklist_username;
        public System.Windows.Forms.DataGridView Blacklist;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button ButtonQueuedUsersRemove;
        public System.Windows.Forms.DataGridView QueuedUsers;
        private System.Windows.Forms.Button SettingsButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer SpotifyTimer;
        private System.Windows.Forms.DataGridViewTextBoxColumn BannedText;
        private System.Windows.Forms.DataGridViewTextBoxColumn BannedPattern;
    }
}

