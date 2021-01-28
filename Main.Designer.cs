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
            this.changeLogFileLocationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.titlemenu = new System.Windows.Forms.ComboBox();
            this.lobbymenu = new System.Windows.Forms.ComboBox();
            this.victory = new System.Windows.Forms.ComboBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.status = new System.Windows.Forms.Timer(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.versionlabel = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.checkBox1 = new MaterialSkin.Controls.MaterialCheckBox();
            this.checkBox2 = new MaterialSkin.Controls.MaterialCheckBox();
            this.button2 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialFlatButton2 = new MaterialSkin.Controls.MaterialFlatButton();
            this.ytlink = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.volumelbl = new MaterialSkin.Controls.MaterialLabel();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DodgerBlue;
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
            this.launchOnPCStartupToolStripMenuItem,
            this.changeLogFileLocationToolStripMenuItem});
            this.optionsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // minimiseToTrayToolStripMenuItem
            // 
            this.minimiseToTrayToolStripMenuItem.Name = "minimiseToTrayToolStripMenuItem";
            this.minimiseToTrayToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.minimiseToTrayToolStripMenuItem.Text = "Minimise To Tray";
            this.minimiseToTrayToolStripMenuItem.Click += new System.EventHandler(this.minimiseToTrayToolStripMenuItem_Click);
            // 
            // reloadMusicToolStripMenuItem
            // 
            this.reloadMusicToolStripMenuItem.Name = "reloadMusicToolStripMenuItem";
            this.reloadMusicToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
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
            this.openSongsFolderToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
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
            this.checkForUpdateToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.checkForUpdateToolStripMenuItem.Text = "Check for Update";
            this.checkForUpdateToolStripMenuItem.Click += new System.EventHandler(this.checkForUpdateToolStripMenuItem_Click);
            // 
            // launchOnPCStartupToolStripMenuItem
            // 
            this.launchOnPCStartupToolStripMenuItem.CheckOnClick = true;
            this.launchOnPCStartupToolStripMenuItem.Name = "launchOnPCStartupToolStripMenuItem";
            this.launchOnPCStartupToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.launchOnPCStartupToolStripMenuItem.Text = "Launch on PC Startup";
            this.launchOnPCStartupToolStripMenuItem.Click += new System.EventHandler(this.launchOnPCStartupToolStripMenuItem_Click);
            // 
            // changeLogFileLocationToolStripMenuItem
            // 
            this.changeLogFileLocationToolStripMenuItem.Name = "changeLogFileLocationToolStripMenuItem";
            this.changeLogFileLocationToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.changeLogFileLocationToolStripMenuItem.Text = "Change Log File Location";
            this.changeLogFileLocationToolStripMenuItem.Click += new System.EventHandler(this.changeLogFileLocationToolStripMenuItem_Click);
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
            this.titlemenu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            this.lobbymenu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            this.victory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            this.notifyIcon1.Text = "Pro Swapper Music";
            this.notifyIcon1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseClick);
            // 
            // status
            // 
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
            // pictureBox1
            // 
            this.pictureBox1.ImageLocation = "https://cdn.discordapp.com/attachments/778776789866512394/804153539265429554/pict" +
    "ureBox1.Image.png";
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
            this.pictureBox2.ImageLocation = "https://cdn.discordapp.com/attachments/778776789866512394/804153537297645588/pict" +
    "ureBox2.Image.png";
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
            this.pictureBox3.ImageLocation = "https://cdn.discordapp.com/attachments/778776789866512394/804153536148668476/pict" +
    "ureBox3.Image.png";
            this.pictureBox3.Location = new System.Drawing.Point(16, 264);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(92, 74);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 25;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.AutoSize = true;
            this.materialRaisedButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialRaisedButton1.Icon = null;
            this.materialRaisedButton1.Location = new System.Drawing.Point(574, 436);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(142, 36);
            this.materialRaisedButton1.TabIndex = 27;
            this.materialRaisedButton1.Text = "Launch Fortnite";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            this.materialRaisedButton1.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox1.Depth = 0;
            this.checkBox1.Font = new System.Drawing.Font("Roboto", 10F);
            this.checkBox1.Location = new System.Drawing.Point(574, 364);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(0);
            this.checkBox1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.checkBox1.MouseState = MaterialSkin.MouseState.HOVER;
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Ripple = true;
            this.checkBox1.Size = new System.Drawing.Size(148, 30);
            this.checkBox1.TabIndex = 28;
            this.checkBox1.Text = "Play in Background";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.Click += new System.EventHandler(this.materialCheckBox1_Click);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox2.Depth = 0;
            this.checkBox2.Font = new System.Drawing.Font("Roboto", 10F);
            this.checkBox2.Location = new System.Drawing.Point(574, 403);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(0);
            this.checkBox2.MouseLocation = new System.Drawing.Point(-1, -1);
            this.checkBox2.MouseState = MaterialSkin.MouseState.HOVER;
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Ripple = true;
            this.checkBox2.Size = new System.Drawing.Size(154, 30);
            this.checkBox2.TabIndex = 29;
            this.checkBox2.Text = "Play Music in match";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.Click += new System.EventHandler(this.materialCheckBox2_Click);
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Depth = 0;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Icon = null;
            this.button2.Location = new System.Drawing.Point(604, 182);
            this.button2.MouseState = MaterialSkin.MouseState.HOVER;
            this.button2.Name = "button2";
            this.button2.Primary = true;
            this.button2.Size = new System.Drawing.Size(96, 36);
            this.button2.TabIndex = 30;
            this.button2.Text = "Download";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.materialRaisedButton2_Click);
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Icon = null;
            this.materialFlatButton1.Location = new System.Drawing.Point(794, 0);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(36, 36);
            this.materialFlatButton1.TabIndex = 32;
            this.materialFlatButton1.Text = "  X  ";
            this.materialFlatButton1.UseVisualStyleBackColor = true;
            this.materialFlatButton1.Click += new System.EventHandler(this.materialFlatButton1_Click);
            // 
            // materialFlatButton2
            // 
            this.materialFlatButton2.AutoSize = true;
            this.materialFlatButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialFlatButton2.Depth = 0;
            this.materialFlatButton2.ForeColor = System.Drawing.Color.White;
            this.materialFlatButton2.Icon = null;
            this.materialFlatButton2.Location = new System.Drawing.Point(771, 0);
            this.materialFlatButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton2.Name = "materialFlatButton2";
            this.materialFlatButton2.Primary = false;
            this.materialFlatButton2.Size = new System.Drawing.Size(32, 36);
            this.materialFlatButton2.TabIndex = 33;
            this.materialFlatButton2.Text = "  -  ";
            this.materialFlatButton2.UseVisualStyleBackColor = true;
            this.materialFlatButton2.Click += new System.EventHandler(this.materialFlatButton2_Click);
            // 
            // ytlink
            // 
            this.ytlink.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ytlink.Depth = 0;
            this.ytlink.Hint = "";
            this.ytlink.Location = new System.Drawing.Point(323, 182);
            this.ytlink.MaxLength = 32767;
            this.ytlink.MouseState = MaterialSkin.MouseState.HOVER;
            this.ytlink.Name = "ytlink";
            this.ytlink.PasswordChar = '\0';
            this.ytlink.SelectedText = "";
            this.ytlink.SelectionLength = 0;
            this.ytlink.SelectionStart = 0;
            this.ytlink.Size = new System.Drawing.Size(275, 23);
            this.ytlink.TabIndex = 34;
            this.ytlink.TabStop = false;
            this.ytlink.Text = "e.g: youtu.be/dQw4w9WgXcQ";
            this.ytlink.UseSystemPasswordChar = false;
            this.ytlink.Click += new System.EventHandler(this.ytlink_Click);
            // 
            // trackBar2
            // 
            this.trackBar2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trackBar2.Location = new System.Drawing.Point(337, 403);
            this.trackBar2.Maximum = 100;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(168, 45);
            this.trackBar2.TabIndex = 35;
            this.trackBar2.TickFrequency = 10;
            this.trackBar2.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBar2.Value = 50;
            this.trackBar2.ValueChanged += new System.EventHandler(this.trackBar2_ValueChanged);
            // 
            // volumelbl
            // 
            this.volumelbl.AutoSize = true;
            this.volumelbl.Depth = 0;
            this.volumelbl.Font = new System.Drawing.Font("Roboto", 11F);
            this.volumelbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.volumelbl.Location = new System.Drawing.Point(237, 414);
            this.volumelbl.MouseState = MaterialSkin.MouseState.HOVER;
            this.volumelbl.Name = "volumelbl";
            this.volumelbl.Size = new System.Drawing.Size(65, 19);
            this.volumelbl.TabIndex = 36;
            this.volumelbl.Text = "Volume:";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(821, 521);
            this.Controls.Add(this.volumelbl);
            this.Controls.Add(this.trackBar2);
            this.Controls.Add(this.ytlink);
            this.Controls.Add(this.materialFlatButton2);
            this.Controls.Add(this.materialFlatButton1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.materialRaisedButton1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.versionlabel);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.victory);
            this.Controls.Add(this.lobbymenu);
            this.Controls.Add(this.titlemenu);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pro Swapper Music";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
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
        private System.Windows.Forms.Timer status;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ToolStripMenuItem checkForUpdateToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label versionlabel;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.ToolStripMenuItem launchOnPCStartupToolStripMenuItem;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        private MaterialSkin.Controls.MaterialCheckBox checkBox1;
        private MaterialSkin.Controls.MaterialCheckBox checkBox2;
        private MaterialSkin.Controls.MaterialRaisedButton button2;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton2;
        private MaterialSkin.Controls.MaterialSingleLineTextField ytlink;
        private System.Windows.Forms.ToolStripMenuItem changeLogFileLocationToolStripMenuItem;
        private System.Windows.Forms.TrackBar trackBar2;
        private MaterialSkin.Controls.MaterialLabel volumelbl;
    }
}

