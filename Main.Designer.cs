namespace ProSwapperMusic
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minimiseToTrayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reloadMusicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openSongsFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.songsFolderInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openSongsFolderToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteAllSongsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkForUpdateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.launchOnPCStartupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ytlink = new System.Windows.Forms.TextBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.titlemenu = new System.Windows.Forms.ComboBox();
            this.lobbymenu = new System.Windows.Forms.ComboBox();
            this.victory = new System.Windows.Forms.ComboBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.vid = new System.ComponentModel.BackgroundWorker();
            this.status = new System.Windows.Forms.Timer(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.versionlabel = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(821, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.minimiseToTrayToolStripMenuItem,
            this.reloadMusicToolStripMenuItem,
            this.openSongsFolderToolStripMenuItem,
            this.checkForUpdateToolStripMenuItem,
            this.launchOnPCStartupToolStripMenuItem});
            this.optionsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // minimiseToTrayToolStripMenuItem
            // 
            this.minimiseToTrayToolStripMenuItem.Name = "minimiseToTrayToolStripMenuItem";
            this.minimiseToTrayToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.minimiseToTrayToolStripMenuItem.Text = "Minimise To Tray";
            this.minimiseToTrayToolStripMenuItem.Click += new System.EventHandler(this.minimiseToTrayToolStripMenuItem_Click);
            // 
            // reloadMusicToolStripMenuItem
            // 
            this.reloadMusicToolStripMenuItem.Name = "reloadMusicToolStripMenuItem";
            this.reloadMusicToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.reloadMusicToolStripMenuItem.Text = "Reload Music";
            this.reloadMusicToolStripMenuItem.Click += new System.EventHandler(this.reloadMusicToolStripMenuItem_Click);
            // 
            // openSongsFolderToolStripMenuItem
            // 
            this.openSongsFolderToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.songsFolderInfoToolStripMenuItem,
            this.openSongsFolderToolStripMenuItem1,
            this.deleteAllSongsToolStripMenuItem});
            this.openSongsFolderToolStripMenuItem.Name = "openSongsFolderToolStripMenuItem";
            this.openSongsFolderToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.openSongsFolderToolStripMenuItem.Text = "Songs Option";
            // 
            // songsFolderInfoToolStripMenuItem
            // 
            this.songsFolderInfoToolStripMenuItem.Name = "songsFolderInfoToolStripMenuItem";
            this.songsFolderInfoToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.songsFolderInfoToolStripMenuItem.Text = "Songs Folder Info";
            this.songsFolderInfoToolStripMenuItem.Click += new System.EventHandler(this.songsFolderInfoToolStripMenuItem_Click);
            // 
            // openSongsFolderToolStripMenuItem1
            // 
            this.openSongsFolderToolStripMenuItem1.Name = "openSongsFolderToolStripMenuItem1";
            this.openSongsFolderToolStripMenuItem1.Size = new System.Drawing.Size(174, 22);
            this.openSongsFolderToolStripMenuItem1.Text = "Open Songs Folder";
            this.openSongsFolderToolStripMenuItem1.Click += new System.EventHandler(this.openSongsFolderToolStripMenuItem1_Click);
            // 
            // deleteAllSongsToolStripMenuItem
            // 
            this.deleteAllSongsToolStripMenuItem.Name = "deleteAllSongsToolStripMenuItem";
            this.deleteAllSongsToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.deleteAllSongsToolStripMenuItem.Text = "Delete All Songs";
            this.deleteAllSongsToolStripMenuItem.Click += new System.EventHandler(this.deleteAllSongsToolStripMenuItem_Click);
            // 
            // checkForUpdateToolStripMenuItem
            // 
            this.checkForUpdateToolStripMenuItem.Name = "checkForUpdateToolStripMenuItem";
            this.checkForUpdateToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.checkForUpdateToolStripMenuItem.Text = "Check for Update";
            this.checkForUpdateToolStripMenuItem.Click += new System.EventHandler(this.checkForUpdateToolStripMenuItem_Click);
            // 
            // launchOnPCStartupToolStripMenuItem
            // 
            this.launchOnPCStartupToolStripMenuItem.CheckOnClick = true;
            this.launchOnPCStartupToolStripMenuItem.Name = "launchOnPCStartupToolStripMenuItem";
            this.launchOnPCStartupToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.launchOnPCStartupToolStripMenuItem.Text = "Launch on PC Startup";
            this.launchOnPCStartupToolStripMenuItem.Click += new System.EventHandler(this.launchOnPCStartupToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(121, 222);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Title Menu Music:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(121, 266);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Lobby Music:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(121, 319);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Victory Music:";
            // 
            // ytlink
            // 
            this.ytlink.BackColor = System.Drawing.Color.White;
            this.ytlink.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ytlink.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ytlink.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ytlink.Location = new System.Drawing.Point(323, 175);
            this.ytlink.Multiline = true;
            this.ytlink.Name = "ytlink";
            this.ytlink.Size = new System.Drawing.Size(289, 30);
            this.ytlink.TabIndex = 4;
            // 
            // trackBar1
            // 
            this.trackBar1.BackColor = System.Drawing.Color.DodgerBlue;
            this.trackBar1.Location = new System.Drawing.Point(464, 346);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(104, 45);
            this.trackBar1.TabIndex = 7;
            this.trackBar1.TickFrequency = 10;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBar1.Value = 10;
            this.trackBar1.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(361, 355);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Volume:";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.Color.White;
            this.checkBox1.Location = new System.Drawing.Point(574, 346);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(209, 34);
            this.checkBox1.TabIndex = 9;
            this.checkBox1.Text = "Play in Background";
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.Click += new System.EventHandler(this.checkBox1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(584, 446);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 45);
            this.button1.TabIndex = 10;
            this.button1.Text = "Launch Fortnite";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(142, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(339, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "You can change the music without closing Fortnite!";
            this.label5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DodgerBlue;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(618, 175);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(141, 30);
            this.button2.TabIndex = 12;
            this.button2.Text = "Download";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(121, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(185, 25);
            this.label6.TabIndex = 13;
            this.label6.Text = "YouTube To Mp3:";
            // 
            // titlemenu
            // 
            this.titlemenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.titlemenu.FormattingEnabled = true;
            this.titlemenu.Location = new System.Drawing.Point(323, 222);
            this.titlemenu.Name = "titlemenu";
            this.titlemenu.Size = new System.Drawing.Size(460, 21);
            this.titlemenu.TabIndex = 14;
            this.titlemenu.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.titlemenu.MouseEnter += new System.EventHandler(this.comboBox1_MouseEnter);
            // 
            // lobbymenu
            // 
            this.lobbymenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lobbymenu.FormattingEnabled = true;
            this.lobbymenu.Location = new System.Drawing.Point(323, 266);
            this.lobbymenu.Name = "lobbymenu";
            this.lobbymenu.Size = new System.Drawing.Size(460, 21);
            this.lobbymenu.TabIndex = 15;
            this.lobbymenu.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            this.lobbymenu.MouseEnter += new System.EventHandler(this.comboBox2_MouseEnter);
            // 
            // victory
            // 
            this.victory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.victory.FormattingEnabled = true;
            this.victory.Location = new System.Drawing.Point(323, 319);
            this.victory.Name = "victory";
            this.victory.Size = new System.Drawing.Size(460, 21);
            this.victory.TabIndex = 16;
            this.victory.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            this.victory.MouseEnter += new System.EventHandler(this.comboBox3_MouseEnter);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Pro Swapper Music";
            this.notifyIcon1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseClick);
            // 
            // vid
            // 
            this.vid.DoWork += new System.ComponentModel.DoWorkEventHandler(this.vid_DoWork);
            this.vid.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.vid_RunWorkerCompleted);
            // 
            // status
            // 
            this.status.Interval = 1;
            this.status.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(66, 545);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 25);
            this.label7.TabIndex = 17;
            this.label7.Text = "State:";
            this.label7.Visible = false;
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button3.Location = new System.Drawing.Point(747, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(36, 32);
            this.button3.TabIndex = 19;
            this.button3.Text = "-";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button4.Location = new System.Drawing.Point(783, 0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(36, 32);
            this.button4.TabIndex = 18;
            this.button4.Text = "X";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(8, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(126, 125);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(140, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(205, 25);
            this.label8.TabIndex = 21;
            this.label8.Text = "Pro Swapper Music";
            this.label8.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(140, 70);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(268, 17);
            this.label9.TabIndex = 22;
            this.label9.Text = "Get any custom lobby music for Fortnite!";
            this.label9.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(8, 166);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(115, 92);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 23;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // versionlabel
            // 
            this.versionlabel.AutoSize = true;
            this.versionlabel.BackColor = System.Drawing.Color.Transparent;
            this.versionlabel.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.versionlabel.ForeColor = System.Drawing.Color.White;
            this.versionlabel.Location = new System.Drawing.Point(12, 488);
            this.versionlabel.Name = "versionlabel";
            this.versionlabel.Size = new System.Drawing.Size(88, 24);
            this.versionlabel.TabIndex = 24;
            this.versionlabel.Text = "Version:";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(16, 264);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(92, 74);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 25;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(821, 521);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.versionlabel);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.victory);
            this.Controls.Add(this.lobbymenu);
            this.Controls.Add(this.titlemenu);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.ytlink);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pro Swapper Music";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ytlink;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox titlemenu;
        private System.Windows.Forms.ComboBox lobbymenu;
        private System.Windows.Forms.ComboBox victory;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem minimiseToTrayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reloadMusicToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openSongsFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem songsFolderInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openSongsFolderToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem deleteAllSongsToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker vid;
        private System.Windows.Forms.Timer status;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ToolStripMenuItem checkForUpdateToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label versionlabel;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.ToolStripMenuItem launchOnPCStartupToolStripMenuItem;
    }
}

