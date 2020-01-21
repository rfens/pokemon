namespace MonsterBattle
{
    partial class BattleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BattleForm));
            this.attackTimer = new System.Windows.Forms.Timer(this.components);
            this.screenShakeTimer = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.gif_timer = new System.Windows.Forms.Timer(this.components);
            this.Feckermongroupbox = new System.Windows.Forms.GroupBox();
            this.Feckermon6RadioButton = new System.Windows.Forms.RadioButton();
            this.Feckermon2RadioButton = new System.Windows.Forms.RadioButton();
            this.Feckermon3RadioButton = new System.Windows.Forms.RadioButton();
            this.Feckermon4RadioButton = new System.Windows.Forms.RadioButton();
            this.Feckermon5RadioButton = new System.Windows.Forms.RadioButton();
            this.Feckermon1RadioButton = new System.Windows.Forms.RadioButton();
            this.attackButton = new System.Windows.Forms.Button();
            this.EnemyGroupBox = new System.Windows.Forms.GroupBox();
            this.attacker6radiobutton = new System.Windows.Forms.RadioButton();
            this.attacker5radiobutton = new System.Windows.Forms.RadioButton();
            this.attacker4radiobutton = new System.Windows.Forms.RadioButton();
            this.attacker3radiobutton = new System.Windows.Forms.RadioButton();
            this.attacker2radiobutton = new System.Windows.Forms.RadioButton();
            this.attacker1radiobutton = new System.Windows.Forms.RadioButton();
            this.feckermon2groupbox = new System.Windows.Forms.GroupBox();
            this.feckermon2_6radbuttn = new System.Windows.Forms.RadioButton();
            this.feckermon2_2radbuttn = new System.Windows.Forms.RadioButton();
            this.feckermon2_3radbuttn = new System.Windows.Forms.RadioButton();
            this.feckermon2_4radbuttn = new System.Windows.Forms.RadioButton();
            this.feckermon2_5radbuttn = new System.Windows.Forms.RadioButton();
            this.Feckermon2_1radbuttn = new System.Windows.Forms.RadioButton();
            this.feckermon3groupbox = new System.Windows.Forms.GroupBox();
            this.feckermon6Button = new System.Windows.Forms.RadioButton();
            this.feckermon2Button = new System.Windows.Forms.RadioButton();
            this.feckermon3Button = new System.Windows.Forms.RadioButton();
            this.feckermon4Button = new System.Windows.Forms.RadioButton();
            this.feckermon5Button = new System.Windows.Forms.RadioButton();
            this.feckermon1Button = new System.Windows.Forms.RadioButton();
            this.groupBoxDeck4 = new System.Windows.Forms.GroupBox();
            this.deck4R6 = new System.Windows.Forms.RadioButton();
            this.deck4R5 = new System.Windows.Forms.RadioButton();
            this.deck4R4 = new System.Windows.Forms.RadioButton();
            this.deck4R3 = new System.Windows.Forms.RadioButton();
            this.deck4R2 = new System.Windows.Forms.RadioButton();
            this.deck4R1 = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Feckermonnamelabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.enemynamelabel = new System.Windows.Forms.Label();
            this.enemyLevel = new System.Windows.Forms.Label();
            this.enemyHealthPictureBox = new System.Windows.Forms.PictureBox();
            this.enemyPictureBox = new System.Windows.Forms.PictureBox();
            this.friendlyPictureBox = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chooseDeckToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deck1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deck2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deck3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deck4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeAttackSetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.attackSet1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.attackSet2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.attackSet1GroupBox = new System.Windows.Forms.GroupBox();
            this.attackSet2GroupBox = new System.Windows.Forms.GroupBox();
            this.Feckermongroupbox.SuspendLayout();
            this.EnemyGroupBox.SuspendLayout();
            this.feckermon2groupbox.SuspendLayout();
            this.feckermon3groupbox.SuspendLayout();
            this.groupBoxDeck4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.enemyHealthPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.friendlyPictureBox)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.attackSet1GroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // attackTimer
            // 
            this.attackTimer.Interval = 1000;
            this.attackTimer.Tick += new System.EventHandler(this.attackTimer_Tick);
            // 
            // screenShakeTimer
            // 
            this.screenShakeTimer.Interval = 50;
            this.screenShakeTimer.Tick += new System.EventHandler(this.screenShakeTimer_Tick);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(316, 16);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 36);
            this.button1.TabIndex = 2;
            this.button1.Text = "rocket ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(423, 16);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(155, 36);
            this.button2.TabIndex = 3;
            this.button2.Text = "sniper shot";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(150, 16);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(158, 36);
            this.button3.TabIndex = 4;
            this.button3.Text = "Gass attack";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // gif_timer
            // 
            this.gif_timer.Interval = 1500;
            this.gif_timer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Feckermongroupbox
            // 
            this.Feckermongroupbox.Controls.Add(this.Feckermon6RadioButton);
            this.Feckermongroupbox.Controls.Add(this.Feckermon2RadioButton);
            this.Feckermongroupbox.Controls.Add(this.Feckermon3RadioButton);
            this.Feckermongroupbox.Controls.Add(this.Feckermon4RadioButton);
            this.Feckermongroupbox.Controls.Add(this.Feckermon5RadioButton);
            this.Feckermongroupbox.Controls.Add(this.Feckermon1RadioButton);
            this.Feckermongroupbox.Location = new System.Drawing.Point(13, 382);
            this.Feckermongroupbox.Margin = new System.Windows.Forms.Padding(4);
            this.Feckermongroupbox.Name = "Feckermongroupbox";
            this.Feckermongroupbox.Padding = new System.Windows.Forms.Padding(4);
            this.Feckermongroupbox.Size = new System.Drawing.Size(313, 85);
            this.Feckermongroupbox.TabIndex = 5;
            this.Feckermongroupbox.TabStop = false;
            this.Feckermongroupbox.Text = "Feckermons";
            this.Feckermongroupbox.Visible = false;
            // 
            // Feckermon6RadioButton
            // 
            this.Feckermon6RadioButton.AutoSize = true;
            this.Feckermon6RadioButton.Location = new System.Drawing.Point(193, 48);
            this.Feckermon6RadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.Feckermon6RadioButton.Name = "Feckermon6RadioButton";
            this.Feckermon6RadioButton.Size = new System.Drawing.Size(61, 21);
            this.Feckermon6RadioButton.TabIndex = 5;
            this.Feckermon6RadioButton.TabStop = true;
            this.Feckermon6RadioButton.Text = "Kirby";
            this.Feckermon6RadioButton.UseVisualStyleBackColor = true;
            this.Feckermon6RadioButton.CheckedChanged += new System.EventHandler(this.Feckermon6RadioButton_CheckedChanged);
            // 
            // Feckermon2RadioButton
            // 
            this.Feckermon2RadioButton.AutoSize = true;
            this.Feckermon2RadioButton.Location = new System.Drawing.Point(4, 48);
            this.Feckermon2RadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.Feckermon2RadioButton.Name = "Feckermon2RadioButton";
            this.Feckermon2RadioButton.Size = new System.Drawing.Size(92, 21);
            this.Feckermon2RadioButton.TabIndex = 4;
            this.Feckermon2RadioButton.TabStop = true;
            this.Feckermon2RadioButton.Text = "Tachanka";
            this.Feckermon2RadioButton.UseVisualStyleBackColor = true;
            this.Feckermon2RadioButton.CheckedChanged += new System.EventHandler(this.Feckermon2RadioButton_CheckedChanged);
            // 
            // Feckermon3RadioButton
            // 
            this.Feckermon3RadioButton.AutoSize = true;
            this.Feckermon3RadioButton.Location = new System.Drawing.Point(108, 19);
            this.Feckermon3RadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.Feckermon3RadioButton.Name = "Feckermon3RadioButton";
            this.Feckermon3RadioButton.Size = new System.Drawing.Size(64, 21);
            this.Feckermon3RadioButton.TabIndex = 3;
            this.Feckermon3RadioButton.TabStop = true;
            this.Feckermon3RadioButton.Text = "Sanic";
            this.Feckermon3RadioButton.UseVisualStyleBackColor = true;
            this.Feckermon3RadioButton.CheckedChanged += new System.EventHandler(this.Feckermon3RadioButton_CheckedChanged);
            // 
            // Feckermon4RadioButton
            // 
            this.Feckermon4RadioButton.AutoSize = true;
            this.Feckermon4RadioButton.Location = new System.Drawing.Point(108, 50);
            this.Feckermon4RadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.Feckermon4RadioButton.Name = "Feckermon4RadioButton";
            this.Feckermon4RadioButton.Size = new System.Drawing.Size(67, 21);
            this.Feckermon4RadioButton.TabIndex = 2;
            this.Feckermon4RadioButton.TabStop = true;
            this.Feckermon4RadioButton.Text = "Ghost";
            this.Feckermon4RadioButton.UseVisualStyleBackColor = true;
            this.Feckermon4RadioButton.CheckedChanged += new System.EventHandler(this.Feckermon4RadioButton_CheckedChanged);
            // 
            // Feckermon5RadioButton
            // 
            this.Feckermon5RadioButton.AutoSize = true;
            this.Feckermon5RadioButton.Location = new System.Drawing.Point(193, 19);
            this.Feckermon5RadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.Feckermon5RadioButton.Name = "Feckermon5RadioButton";
            this.Feckermon5RadioButton.Size = new System.Drawing.Size(108, 21);
            this.Feckermon5RadioButton.TabIndex = 1;
            this.Feckermon5RadioButton.TabStop = true;
            this.Feckermon5RadioButton.Text = "Master Chief";
            this.Feckermon5RadioButton.UseVisualStyleBackColor = true;
            this.Feckermon5RadioButton.CheckedChanged += new System.EventHandler(this.Feckermon5RadioButton_CheckedChanged);
            // 
            // Feckermon1RadioButton
            // 
            this.Feckermon1RadioButton.AutoSize = true;
            this.Feckermon1RadioButton.Checked = true;
            this.Feckermon1RadioButton.Location = new System.Drawing.Point(4, 20);
            this.Feckermon1RadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.Feckermon1RadioButton.Name = "Feckermon1RadioButton";
            this.Feckermon1RadioButton.Size = new System.Drawing.Size(62, 21);
            this.Feckermon1RadioButton.TabIndex = 0;
            this.Feckermon1RadioButton.TabStop = true;
            this.Feckermon1RadioButton.Text = "Hitler";
            this.Feckermon1RadioButton.UseVisualStyleBackColor = true;
            this.Feckermon1RadioButton.CheckedChanged += new System.EventHandler(this.Feckermon1RadioButton_CheckedChanged);
            // 
            // attackButton
            // 
            this.attackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attackButton.Location = new System.Drawing.Point(0, 16);
            this.attackButton.Margin = new System.Windows.Forms.Padding(4);
            this.attackButton.Name = "attackButton";
            this.attackButton.Size = new System.Drawing.Size(142, 36);
            this.attackButton.TabIndex = 1;
            this.attackButton.Text = "Explosion";
            this.attackButton.UseVisualStyleBackColor = true;
            this.attackButton.Click += new System.EventHandler(this.attackButton_Click);
            // 
            // EnemyGroupBox
            // 
            this.EnemyGroupBox.Controls.Add(this.attacker6radiobutton);
            this.EnemyGroupBox.Controls.Add(this.attacker5radiobutton);
            this.EnemyGroupBox.Controls.Add(this.attacker4radiobutton);
            this.EnemyGroupBox.Controls.Add(this.attacker3radiobutton);
            this.EnemyGroupBox.Controls.Add(this.attacker2radiobutton);
            this.EnemyGroupBox.Controls.Add(this.attacker1radiobutton);
            this.EnemyGroupBox.Location = new System.Drawing.Point(347, 381);
            this.EnemyGroupBox.Name = "EnemyGroupBox";
            this.EnemyGroupBox.Size = new System.Drawing.Size(368, 86);
            this.EnemyGroupBox.TabIndex = 7;
            this.EnemyGroupBox.TabStop = false;
            this.EnemyGroupBox.Text = "Enemy";
            // 
            // attacker6radiobutton
            // 
            this.attacker6radiobutton.AutoSize = true;
            this.attacker6radiobutton.Location = new System.Drawing.Point(249, 51);
            this.attacker6radiobutton.Name = "attacker6radiobutton";
            this.attacker6radiobutton.Size = new System.Drawing.Size(69, 21);
            this.attacker6radiobutton.TabIndex = 5;
            this.attacker6radiobutton.TabStop = true;
            this.attacker6radiobutton.Text = "Wall-e";
            this.attacker6radiobutton.UseVisualStyleBackColor = true;
            this.attacker6radiobutton.CheckedChanged += new System.EventHandler(this.attacker6radiobutton_CheckedChanged);
            // 
            // attacker5radiobutton
            // 
            this.attacker5radiobutton.AutoSize = true;
            this.attacker5radiobutton.Location = new System.Drawing.Point(250, 24);
            this.attacker5radiobutton.Name = "attacker5radiobutton";
            this.attacker5radiobutton.Size = new System.Drawing.Size(55, 21);
            this.attacker5radiobutton.TabIndex = 4;
            this.attacker5radiobutton.TabStop = true;
            this.attacker5radiobutton.Text = "Link";
            this.attacker5radiobutton.UseVisualStyleBackColor = true;
            this.attacker5radiobutton.CheckedChanged += new System.EventHandler(this.attacker5radiobutton_CheckedChanged);
            // 
            // attacker4radiobutton
            // 
            this.attacker4radiobutton.AutoSize = true;
            this.attacker4radiobutton.Location = new System.Drawing.Point(133, 51);
            this.attacker4radiobutton.Name = "attacker4radiobutton";
            this.attacker4radiobutton.Size = new System.Drawing.Size(83, 21);
            this.attacker4radiobutton.TabIndex = 3;
            this.attacker4radiobutton.TabStop = true;
            this.attacker4radiobutton.Text = "Goomba";
            this.attacker4radiobutton.UseVisualStyleBackColor = true;
            this.attacker4radiobutton.CheckedChanged += new System.EventHandler(this.attacker4radiobutton_CheckedChanged);
            // 
            // attacker3radiobutton
            // 
            this.attacker3radiobutton.AutoSize = true;
            this.attacker3radiobutton.Location = new System.Drawing.Point(133, 24);
            this.attacker3radiobutton.Name = "attacker3radiobutton";
            this.attacker3radiobutton.Size = new System.Drawing.Size(59, 21);
            this.attacker3radiobutton.TabIndex = 2;
            this.attacker3radiobutton.TabStop = true;
            this.attacker3radiobutton.Text = "T-14";
            this.attacker3radiobutton.UseVisualStyleBackColor = true;
            this.attacker3radiobutton.CheckedChanged += new System.EventHandler(this.attacker3radiobutton_CheckedChanged);
            // 
            // attacker2radiobutton
            // 
            this.attacker2radiobutton.AutoSize = true;
            this.attacker2radiobutton.Location = new System.Drawing.Point(17, 51);
            this.attacker2radiobutton.Name = "attacker2radiobutton";
            this.attacker2radiobutton.Size = new System.Drawing.Size(79, 21);
            this.attacker2radiobutton.TabIndex = 1;
            this.attacker2radiobutton.TabStop = true;
            this.attacker2radiobutton.Text = "Chicken";
            this.attacker2radiobutton.UseVisualStyleBackColor = true;
            this.attacker2radiobutton.CheckedChanged += new System.EventHandler(this.attacker2radiobutton_CheckedChanged);
            // 
            // attacker1radiobutton
            // 
            this.attacker1radiobutton.AutoSize = true;
            this.attacker1radiobutton.Location = new System.Drawing.Point(17, 24);
            this.attacker1radiobutton.Name = "attacker1radiobutton";
            this.attacker1radiobutton.Size = new System.Drawing.Size(64, 21);
            this.attacker1radiobutton.TabIndex = 0;
            this.attacker1radiobutton.TabStop = true;
            this.attacker1radiobutton.Text = "Dipsy";
            this.attacker1radiobutton.UseVisualStyleBackColor = true;
            this.attacker1radiobutton.CheckedChanged += new System.EventHandler(this.attacker1radiobutton_CheckedChanged);
            // 
            // feckermon2groupbox
            // 
            this.feckermon2groupbox.Controls.Add(this.feckermon2_6radbuttn);
            this.feckermon2groupbox.Controls.Add(this.feckermon2_2radbuttn);
            this.feckermon2groupbox.Controls.Add(this.feckermon2_3radbuttn);
            this.feckermon2groupbox.Controls.Add(this.feckermon2_4radbuttn);
            this.feckermon2groupbox.Controls.Add(this.feckermon2_5radbuttn);
            this.feckermon2groupbox.Controls.Add(this.Feckermon2_1radbuttn);
            this.feckermon2groupbox.Location = new System.Drawing.Point(13, 381);
            this.feckermon2groupbox.Margin = new System.Windows.Forms.Padding(4);
            this.feckermon2groupbox.Name = "feckermon2groupbox";
            this.feckermon2groupbox.Padding = new System.Windows.Forms.Padding(4);
            this.feckermon2groupbox.Size = new System.Drawing.Size(313, 85);
            this.feckermon2groupbox.TabIndex = 6;
            this.feckermon2groupbox.TabStop = false;
            this.feckermon2groupbox.Text = "Feckermons";
            this.feckermon2groupbox.Visible = false;
            // 
            // feckermon2_6radbuttn
            // 
            this.feckermon2_6radbuttn.AutoSize = true;
            this.feckermon2_6radbuttn.Location = new System.Drawing.Point(193, 50);
            this.feckermon2_6radbuttn.Margin = new System.Windows.Forms.Padding(4);
            this.feckermon2_6radbuttn.Name = "feckermon2_6radbuttn";
            this.feckermon2_6radbuttn.Size = new System.Drawing.Size(78, 21);
            this.feckermon2_6radbuttn.TabIndex = 5;
            this.feckermon2_6radbuttn.TabStop = true;
            this.feckermon2_6radbuttn.Text = "Cleaner";
            this.feckermon2_6radbuttn.UseVisualStyleBackColor = true;
            this.feckermon2_6radbuttn.CheckedChanged += new System.EventHandler(this.feckermon2_6radbuttn_CheckedChanged);
            // 
            // feckermon2_2radbuttn
            // 
            this.feckermon2_2radbuttn.AutoSize = true;
            this.feckermon2_2radbuttn.Location = new System.Drawing.Point(4, 48);
            this.feckermon2_2radbuttn.Margin = new System.Windows.Forms.Padding(4);
            this.feckermon2_2radbuttn.Name = "feckermon2_2radbuttn";
            this.feckermon2_2radbuttn.Size = new System.Drawing.Size(63, 21);
            this.feckermon2_2radbuttn.TabIndex = 4;
            this.feckermon2_2radbuttn.TabStop = true;
            this.feckermon2_2radbuttn.Text = "Perry";
            this.feckermon2_2radbuttn.UseVisualStyleBackColor = true;
            this.feckermon2_2radbuttn.CheckedChanged += new System.EventHandler(this.feckermon2_2radbuttn_CheckedChanged);
            // 
            // feckermon2_3radbuttn
            // 
            this.feckermon2_3radbuttn.AutoSize = true;
            this.feckermon2_3radbuttn.Location = new System.Drawing.Point(108, 19);
            this.feckermon2_3radbuttn.Margin = new System.Windows.Forms.Padding(4);
            this.feckermon2_3radbuttn.Name = "feckermon2_3radbuttn";
            this.feckermon2_3radbuttn.Size = new System.Drawing.Size(61, 21);
            this.feckermon2_3radbuttn.TabIndex = 3;
            this.feckermon2_3radbuttn.TabStop = true;
            this.feckermon2_3radbuttn.Text = "Jerry";
            this.feckermon2_3radbuttn.UseVisualStyleBackColor = true;
            this.feckermon2_3radbuttn.CheckedChanged += new System.EventHandler(this.feckermon2_3radbuttn_CheckedChanged);
            // 
            // feckermon2_4radbuttn
            // 
            this.feckermon2_4radbuttn.AutoSize = true;
            this.feckermon2_4radbuttn.Location = new System.Drawing.Point(108, 50);
            this.feckermon2_4radbuttn.Margin = new System.Windows.Forms.Padding(4);
            this.feckermon2_4radbuttn.Name = "feckermon2_4radbuttn";
            this.feckermon2_4radbuttn.Size = new System.Drawing.Size(86, 21);
            this.feckermon2_4radbuttn.TabIndex = 2;
            this.feckermon2_4radbuttn.TabStop = true;
            this.feckermon2_4radbuttn.Text = "Knuckles";
            this.feckermon2_4radbuttn.UseVisualStyleBackColor = true;
            this.feckermon2_4radbuttn.CheckedChanged += new System.EventHandler(this.feckermon2_4radbuttn_CheckedChanged);
            // 
            // feckermon2_5radbuttn
            // 
            this.feckermon2_5radbuttn.AutoSize = true;
            this.feckermon2_5radbuttn.Location = new System.Drawing.Point(193, 19);
            this.feckermon2_5radbuttn.Margin = new System.Windows.Forms.Padding(4);
            this.feckermon2_5radbuttn.Name = "feckermon2_5radbuttn";
            this.feckermon2_5radbuttn.Size = new System.Drawing.Size(102, 21);
            this.feckermon2_5radbuttn.TabIndex = 1;
            this.feckermon2_5radbuttn.TabStop = true;
            this.feckermon2_5radbuttn.Text = "Spongebob";
            this.feckermon2_5radbuttn.UseVisualStyleBackColor = true;
            this.feckermon2_5radbuttn.CheckedChanged += new System.EventHandler(this.feckermon2_5radbuttn_CheckedChanged);
            // 
            // Feckermon2_1radbuttn
            // 
            this.Feckermon2_1radbuttn.AutoSize = true;
            this.Feckermon2_1radbuttn.Checked = true;
            this.Feckermon2_1radbuttn.Location = new System.Drawing.Point(4, 20);
            this.Feckermon2_1radbuttn.Margin = new System.Windows.Forms.Padding(4);
            this.Feckermon2_1radbuttn.Name = "Feckermon2_1radbuttn";
            this.Feckermon2_1radbuttn.Size = new System.Drawing.Size(74, 21);
            this.Feckermon2_1radbuttn.TabIndex = 0;
            this.Feckermon2_1radbuttn.TabStop = true;
            this.Feckermon2_1radbuttn.Text = "Eeyore";
            this.Feckermon2_1radbuttn.UseVisualStyleBackColor = true;
            this.Feckermon2_1radbuttn.CheckedChanged += new System.EventHandler(this.Feckermon2_1radbuttn_CheckedChanged);
            // 
            // feckermon3groupbox
            // 
            this.feckermon3groupbox.Controls.Add(this.feckermon6Button);
            this.feckermon3groupbox.Controls.Add(this.feckermon2Button);
            this.feckermon3groupbox.Controls.Add(this.feckermon3Button);
            this.feckermon3groupbox.Controls.Add(this.feckermon4Button);
            this.feckermon3groupbox.Controls.Add(this.feckermon5Button);
            this.feckermon3groupbox.Controls.Add(this.feckermon1Button);
            this.feckermon3groupbox.Location = new System.Drawing.Point(13, 382);
            this.feckermon3groupbox.Margin = new System.Windows.Forms.Padding(4);
            this.feckermon3groupbox.Name = "feckermon3groupbox";
            this.feckermon3groupbox.Padding = new System.Windows.Forms.Padding(4);
            this.feckermon3groupbox.Size = new System.Drawing.Size(313, 85);
            this.feckermon3groupbox.TabIndex = 7;
            this.feckermon3groupbox.TabStop = false;
            this.feckermon3groupbox.Text = "Feckermons";
            this.feckermon3groupbox.Visible = false;
            // 
            // feckermon6Button
            // 
            this.feckermon6Button.AutoSize = true;
            this.feckermon6Button.Location = new System.Drawing.Point(183, 50);
            this.feckermon6Button.Margin = new System.Windows.Forms.Padding(4);
            this.feckermon6Button.Name = "feckermon6Button";
            this.feckermon6Button.Size = new System.Drawing.Size(118, 21);
            this.feckermon6Button.TabIndex = 5;
            this.feckermon6Button.TabStop = true;
            this.feckermon6Button.Text = "Cultleider Bart";
            this.feckermon6Button.UseVisualStyleBackColor = true;
            this.feckermon6Button.CheckedChanged += new System.EventHandler(this.feckermon6Button_CheckedChanged);
            // 
            // feckermon2Button
            // 
            this.feckermon2Button.AutoSize = true;
            this.feckermon2Button.Location = new System.Drawing.Point(4, 48);
            this.feckermon2Button.Margin = new System.Windows.Forms.Padding(4);
            this.feckermon2Button.Name = "feckermon2Button";
            this.feckermon2Button.Size = new System.Drawing.Size(62, 21);
            this.feckermon2Button.TabIndex = 4;
            this.feckermon2Button.TabStop = true;
            this.feckermon2Button.Text = "Toad";
            this.feckermon2Button.UseVisualStyleBackColor = true;
            this.feckermon2Button.CheckedChanged += new System.EventHandler(this.feckermon2Button_CheckedChanged);
            // 
            // feckermon3Button
            // 
            this.feckermon3Button.AutoSize = true;
            this.feckermon3Button.Location = new System.Drawing.Point(95, 19);
            this.feckermon3Button.Margin = new System.Windows.Forms.Padding(4);
            this.feckermon3Button.Name = "feckermon3Button";
            this.feckermon3Button.Size = new System.Drawing.Size(87, 21);
            this.feckermon3Button.TabIndex = 3;
            this.feckermon3Button.TabStop = true;
            this.feckermon3Button.Text = "Hitler Cat";
            this.feckermon3Button.UseVisualStyleBackColor = true;
            this.feckermon3Button.CheckedChanged += new System.EventHandler(this.feckermon3Button_CheckedChanged);
            // 
            // feckermon4Button
            // 
            this.feckermon4Button.AutoSize = true;
            this.feckermon4Button.Location = new System.Drawing.Point(95, 50);
            this.feckermon4Button.Margin = new System.Windows.Forms.Padding(4);
            this.feckermon4Button.Name = "feckermon4Button";
            this.feckermon4Button.Size = new System.Drawing.Size(90, 21);
            this.feckermon4Button.TabIndex = 2;
            this.feckermon4Button.TabStop = true;
            this.feckermon4Button.Text = "Bob Ross";
            this.feckermon4Button.UseVisualStyleBackColor = true;
            this.feckermon4Button.CheckedChanged += new System.EventHandler(this.feckermon4Button_CheckedChanged);
            // 
            // feckermon5Button
            // 
            this.feckermon5Button.AutoSize = true;
            this.feckermon5Button.Location = new System.Drawing.Point(183, 18);
            this.feckermon5Button.Margin = new System.Windows.Forms.Padding(4);
            this.feckermon5Button.Name = "feckermon5Button";
            this.feckermon5Button.Size = new System.Drawing.Size(84, 21);
            this.feckermon5Button.TabIndex = 1;
            this.feckermon5Button.TabStop = true;
            this.feckermon5Button.Text = "Iron Man";
            this.feckermon5Button.UseVisualStyleBackColor = true;
            this.feckermon5Button.CheckedChanged += new System.EventHandler(this.feckermon5Button_CheckedChanged);
            // 
            // feckermon1Button
            // 
            this.feckermon1Button.AutoSize = true;
            this.feckermon1Button.Checked = true;
            this.feckermon1Button.Location = new System.Drawing.Point(4, 20);
            this.feckermon1Button.Margin = new System.Windows.Forms.Padding(4);
            this.feckermon1Button.Name = "feckermon1Button";
            this.feckermon1Button.Size = new System.Drawing.Size(90, 21);
            this.feckermon1Button.TabIndex = 0;
            this.feckermon1Button.TabStop = true;
            this.feckermon1Button.Text = "Deadpool";
            this.feckermon1Button.UseVisualStyleBackColor = true;
            this.feckermon1Button.CheckedChanged += new System.EventHandler(this.feckermon1Button_CheckedChanged);
            // 
            // groupBoxDeck4
            // 
            this.groupBoxDeck4.Controls.Add(this.deck4R6);
            this.groupBoxDeck4.Controls.Add(this.deck4R5);
            this.groupBoxDeck4.Controls.Add(this.deck4R4);
            this.groupBoxDeck4.Controls.Add(this.deck4R3);
            this.groupBoxDeck4.Controls.Add(this.deck4R2);
            this.groupBoxDeck4.Controls.Add(this.deck4R1);
            this.groupBoxDeck4.Location = new System.Drawing.Point(12, 381);
            this.groupBoxDeck4.Name = "groupBoxDeck4";
            this.groupBoxDeck4.Size = new System.Drawing.Size(313, 85);
            this.groupBoxDeck4.TabIndex = 7;
            this.groupBoxDeck4.TabStop = false;
            this.groupBoxDeck4.Text = "Feckermons";
            this.groupBoxDeck4.Visible = false;
            // 
            // deck4R6
            // 
            this.deck4R6.AutoSize = true;
            this.deck4R6.Location = new System.Drawing.Point(183, 49);
            this.deck4R6.Name = "deck4R6";
            this.deck4R6.Size = new System.Drawing.Size(61, 21);
            this.deck4R6.TabIndex = 5;
            this.deck4R6.Text = "Kaos";
            this.deck4R6.UseVisualStyleBackColor = true;
            this.deck4R6.CheckedChanged += new System.EventHandler(this.Deck4R6_CheckedChanged);
            // 
            // deck4R5
            // 
            this.deck4R5.AutoSize = true;
            this.deck4R5.Location = new System.Drawing.Point(183, 21);
            this.deck4R5.Name = "deck4R5";
            this.deck4R5.Size = new System.Drawing.Size(55, 21);
            this.deck4R5.TabIndex = 4;
            this.deck4R5.Text = "Olaf";
            this.deck4R5.UseVisualStyleBackColor = true;
            this.deck4R5.CheckedChanged += new System.EventHandler(this.Deck4R5_CheckedChanged);
            // 
            // deck4R4
            // 
            this.deck4R4.AutoSize = true;
            this.deck4R4.Location = new System.Drawing.Point(104, 48);
            this.deck4R4.Name = "deck4R4";
            this.deck4R4.Size = new System.Drawing.Size(66, 21);
            this.deck4R4.TabIndex = 3;
            this.deck4R4.Text = "Nemo";
            this.deck4R4.UseVisualStyleBackColor = true;
            this.deck4R4.CheckedChanged += new System.EventHandler(this.Deck4R4_CheckedChanged);
            // 
            // deck4R3
            // 
            this.deck4R3.AutoSize = true;
            this.deck4R3.Location = new System.Drawing.Point(104, 21);
            this.deck4R3.Name = "deck4R3";
            this.deck4R3.Size = new System.Drawing.Size(72, 21);
            this.deck4R3.TabIndex = 2;
            this.deck4R3.Text = "Patrick";
            this.deck4R3.UseVisualStyleBackColor = true;
            this.deck4R3.CheckedChanged += new System.EventHandler(this.Deck4R3_CheckedChanged);
            // 
            // deck4R2
            // 
            this.deck4R2.AutoSize = true;
            this.deck4R2.Location = new System.Drawing.Point(0, 49);
            this.deck4R2.Name = "deck4R2";
            this.deck4R2.Size = new System.Drawing.Size(66, 21);
            this.deck4R2.TabIndex = 1;
            this.deck4R2.Text = "Spyro";
            this.deck4R2.UseVisualStyleBackColor = true;
            this.deck4R2.CheckedChanged += new System.EventHandler(this.Deck4R2_CheckedChanged);
            // 
            // deck4R1
            // 
            this.deck4R1.AutoSize = true;
            this.deck4R1.Checked = true;
            this.deck4R1.Location = new System.Drawing.Point(0, 21);
            this.deck4R1.Name = "deck4R1";
            this.deck4R1.Size = new System.Drawing.Size(98, 21);
            this.deck4R1.TabIndex = 0;
            this.deck4R1.TabStop = true;
            this.deck4R1.Text = "Baby Yoda";
            this.deck4R1.UseVisualStyleBackColor = true;
            this.deck4R1.CheckedChanged += new System.EventHandler(this.Deck4R1_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.enemyPictureBox);
            this.panel1.Controls.Add(this.friendlyPictureBox);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(728, 324);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.Feckermonnamelabel);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(377, 259);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(337, 65);
            this.panel3.TabIndex = 3;
            // 
            // Feckermonnamelabel
            // 
            this.Feckermonnamelabel.AutoSize = true;
            this.Feckermonnamelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Feckermonnamelabel.Location = new System.Drawing.Point(112, 6);
            this.Feckermonnamelabel.Name = "Feckermonnamelabel";
            this.Feckermonnamelabel.Size = new System.Drawing.Size(0, 20);
            this.Feckermonnamelabel.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(290, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(157, 29);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.MaximumSize = new System.Drawing.Size(150, 6);
            this.pictureBox1.MinimumSize = new System.Drawing.Size(0, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 6);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.enemynamelabel);
            this.panel2.Controls.Add(this.enemyLevel);
            this.panel2.Controls.Add(this.enemyHealthPictureBox);
            this.panel2.Location = new System.Drawing.Point(129, 28);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(319, 60);
            this.panel2.TabIndex = 2;
            // 
            // enemynamelabel
            // 
            this.enemynamelabel.AutoSize = true;
            this.enemynamelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enemynamelabel.Location = new System.Drawing.Point(81, 7);
            this.enemynamelabel.Name = "enemynamelabel";
            this.enemynamelabel.Size = new System.Drawing.Size(0, 20);
            this.enemynamelabel.TabIndex = 5;
            // 
            // enemyLevel
            // 
            this.enemyLevel.AutoSize = true;
            this.enemyLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enemyLevel.Location = new System.Drawing.Point(258, 9);
            this.enemyLevel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.enemyLevel.Name = "enemyLevel";
            this.enemyLevel.Size = new System.Drawing.Size(17, 17);
            this.enemyLevel.TabIndex = 4;
            this.enemyLevel.Text = "1";
            // 
            // enemyHealthPictureBox
            // 
            this.enemyHealthPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.enemyHealthPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.enemyHealthPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("enemyHealthPictureBox.Image")));
            this.enemyHealthPictureBox.Location = new System.Drawing.Point(125, 33);
            this.enemyHealthPictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.enemyHealthPictureBox.MaximumSize = new System.Drawing.Size(150, 6);
            this.enemyHealthPictureBox.MinimumSize = new System.Drawing.Size(0, 6);
            this.enemyHealthPictureBox.Name = "enemyHealthPictureBox";
            this.enemyHealthPictureBox.Size = new System.Drawing.Size(150, 6);
            this.enemyHealthPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemyHealthPictureBox.TabIndex = 4;
            this.enemyHealthPictureBox.TabStop = false;
            // 
            // enemyPictureBox
            // 
            this.enemyPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.enemyPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.enemyPictureBox.Location = new System.Drawing.Point(456, 37);
            this.enemyPictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.enemyPictureBox.Name = "enemyPictureBox";
            this.enemyPictureBox.Size = new System.Drawing.Size(171, 153);
            this.enemyPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemyPictureBox.TabIndex = 1;
            this.enemyPictureBox.TabStop = false;
            // 
            // friendlyPictureBox
            // 
            this.friendlyPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.friendlyPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.friendlyPictureBox.Location = new System.Drawing.Point(50, 164);
            this.friendlyPictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.friendlyPictureBox.Name = "friendlyPictureBox";
            this.friendlyPictureBox.Size = new System.Drawing.Size(242, 193);
            this.friendlyPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.friendlyPictureBox.TabIndex = 0;
            this.friendlyPictureBox.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.chooseDeckToolStripMenuItem,
            this.changeAttackSetToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(728, 28);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resetToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.resetToolStripMenuItem.Text = "Reset";
            this.resetToolStripMenuItem.Click += new System.EventHandler(this.resetToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.closeToolStripMenuItem.Text = "close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // chooseDeckToolStripMenuItem
            // 
            this.chooseDeckToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deck1ToolStripMenuItem,
            this.deck2ToolStripMenuItem,
            this.deck3ToolStripMenuItem,
            this.deck4ToolStripMenuItem});
            this.chooseDeckToolStripMenuItem.Name = "chooseDeckToolStripMenuItem";
            this.chooseDeckToolStripMenuItem.Size = new System.Drawing.Size(108, 24);
            this.chooseDeckToolStripMenuItem.Text = "Change deck";
            // 
            // deck1ToolStripMenuItem
            // 
            this.deck1ToolStripMenuItem.Name = "deck1ToolStripMenuItem";
            this.deck1ToolStripMenuItem.Size = new System.Drawing.Size(137, 26);
            this.deck1ToolStripMenuItem.Text = "Deck 1";
            this.deck1ToolStripMenuItem.Click += new System.EventHandler(this.deck1ToolStripMenuItem_Click);
            // 
            // deck2ToolStripMenuItem
            // 
            this.deck2ToolStripMenuItem.Name = "deck2ToolStripMenuItem";
            this.deck2ToolStripMenuItem.Size = new System.Drawing.Size(137, 26);
            this.deck2ToolStripMenuItem.Text = "Deck 2";
            this.deck2ToolStripMenuItem.Click += new System.EventHandler(this.deck2ToolStripMenuItem_Click);
            // 
            // deck3ToolStripMenuItem
            // 
            this.deck3ToolStripMenuItem.Name = "deck3ToolStripMenuItem";
            this.deck3ToolStripMenuItem.Size = new System.Drawing.Size(137, 26);
            this.deck3ToolStripMenuItem.Text = "Deck 3";
            this.deck3ToolStripMenuItem.Click += new System.EventHandler(this.deck3ToolStripMenuItem_Click);
            // 
            // deck4ToolStripMenuItem
            // 
            this.deck4ToolStripMenuItem.Name = "deck4ToolStripMenuItem";
            this.deck4ToolStripMenuItem.Size = new System.Drawing.Size(137, 26);
            this.deck4ToolStripMenuItem.Text = "Deck 4";
            this.deck4ToolStripMenuItem.Click += new System.EventHandler(this.Deck4ToolStripMenuItem_Click);
            // 
            // changeAttackSetToolStripMenuItem
            // 
            this.changeAttackSetToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.attackSet1ToolStripMenuItem,
            this.attackSet2ToolStripMenuItem});
            this.changeAttackSetToolStripMenuItem.Name = "changeAttackSetToolStripMenuItem";
            this.changeAttackSetToolStripMenuItem.Size = new System.Drawing.Size(144, 24);
            this.changeAttackSetToolStripMenuItem.Text = "Change Attack Set";
            // 
            // attackSet1ToolStripMenuItem
            // 
            this.attackSet1ToolStripMenuItem.Name = "attackSet1ToolStripMenuItem";
            this.attackSet1ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.attackSet1ToolStripMenuItem.Text = "Attack Set 1";
            this.attackSet1ToolStripMenuItem.Click += new System.EventHandler(this.AttackSet1ToolStripMenuItem_Click);
            // 
            // attackSet2ToolStripMenuItem
            // 
            this.attackSet2ToolStripMenuItem.Name = "attackSet2ToolStripMenuItem";
            this.attackSet2ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.attackSet2ToolStripMenuItem.Text = "Attack Set 2";
            this.attackSet2ToolStripMenuItem.Click += new System.EventHandler(this.AttackSet2ToolStripMenuItem_Click);
            // 
            // attackSet1GroupBox
            // 
            this.attackSet1GroupBox.Controls.Add(this.attackButton);
            this.attackSet1GroupBox.Controls.Add(this.button3);
            this.attackSet1GroupBox.Controls.Add(this.button1);
            this.attackSet1GroupBox.Controls.Add(this.button2);
            this.attackSet1GroupBox.Controls.Add(this.attackSet2GroupBox);
            this.attackSet1GroupBox.Location = new System.Drawing.Point(0, 324);
            this.attackSet1GroupBox.Name = "attackSet1GroupBox";
            this.attackSet1GroupBox.Size = new System.Drawing.Size(728, 59);
            this.attackSet1GroupBox.TabIndex = 6;
            this.attackSet1GroupBox.TabStop = false;
            this.attackSet1GroupBox.Text = "Attack Set 1";
            // 
            // attackSet2GroupBox
            // 
            this.attackSet2GroupBox.Location = new System.Drawing.Point(0, 1);
            this.attackSet2GroupBox.Name = "attackSet2GroupBox";
            this.attackSet2GroupBox.Size = new System.Drawing.Size(614, 52);
            this.attackSet2GroupBox.TabIndex = 5;
            this.attackSet2GroupBox.TabStop = false;
            this.attackSet2GroupBox.Text = "Attack Set 2";
            // 
            // BattleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 470);
            this.Controls.Add(this.attackSet1GroupBox);
            this.Controls.Add(this.groupBoxDeck4);
            this.Controls.Add(this.feckermon3groupbox);
            this.Controls.Add(this.EnemyGroupBox);
            this.Controls.Add(this.feckermon2groupbox);
            this.Controls.Add(this.Feckermongroupbox);
            this.Controls.Add(this.panel1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BattleForm";
            this.Text = "Feckermon duols";
            this.Feckermongroupbox.ResumeLayout(false);
            this.Feckermongroupbox.PerformLayout();
            this.EnemyGroupBox.ResumeLayout(false);
            this.EnemyGroupBox.PerformLayout();
            this.feckermon2groupbox.ResumeLayout(false);
            this.feckermon2groupbox.PerformLayout();
            this.feckermon3groupbox.ResumeLayout(false);
            this.feckermon3groupbox.PerformLayout();
            this.groupBoxDeck4.ResumeLayout(false);
            this.groupBoxDeck4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.enemyHealthPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.friendlyPictureBox)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.attackSet1GroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox friendlyPictureBox;
        private System.Windows.Forms.PictureBox enemyPictureBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox enemyHealthPictureBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button attackButton;
        private System.Windows.Forms.Timer attackTimer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label enemyLevel;
        private System.Windows.Forms.Timer screenShakeTimer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Timer gif_timer;
        private System.Windows.Forms.GroupBox Feckermongroupbox;
        private System.Windows.Forms.RadioButton Feckermon6RadioButton;
        private System.Windows.Forms.RadioButton Feckermon2RadioButton;
        private System.Windows.Forms.RadioButton Feckermon3RadioButton;
        private System.Windows.Forms.RadioButton Feckermon4RadioButton;
        private System.Windows.Forms.RadioButton Feckermon5RadioButton;
        private System.Windows.Forms.RadioButton Feckermon1RadioButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.GroupBox EnemyGroupBox;
        private System.Windows.Forms.RadioButton attacker4radiobutton;
        private System.Windows.Forms.RadioButton attacker3radiobutton;
        private System.Windows.Forms.RadioButton attacker2radiobutton;
        private System.Windows.Forms.RadioButton attacker1radiobutton;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
        private System.Windows.Forms.RadioButton attacker6radiobutton;
        private System.Windows.Forms.RadioButton attacker5radiobutton;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.Label Feckermonnamelabel;
        private System.Windows.Forms.Label enemynamelabel;
        private System.Windows.Forms.ToolStripMenuItem chooseDeckToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deck1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deck2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deck3ToolStripMenuItem;
        private System.Windows.Forms.GroupBox feckermon2groupbox;
        private System.Windows.Forms.RadioButton feckermon2_6radbuttn;
        private System.Windows.Forms.RadioButton feckermon2_2radbuttn;
        private System.Windows.Forms.RadioButton feckermon2_3radbuttn;
        private System.Windows.Forms.RadioButton feckermon2_4radbuttn;
        private System.Windows.Forms.RadioButton feckermon2_5radbuttn;
        private System.Windows.Forms.RadioButton Feckermon2_1radbuttn;
        private System.Windows.Forms.GroupBox feckermon3groupbox;
        private System.Windows.Forms.RadioButton feckermon6Button;
        private System.Windows.Forms.RadioButton feckermon2Button;
        private System.Windows.Forms.RadioButton feckermon3Button;
        private System.Windows.Forms.RadioButton feckermon4Button;
        private System.Windows.Forms.RadioButton feckermon5Button;
        private System.Windows.Forms.RadioButton feckermon1Button;
        private System.Windows.Forms.ToolStripMenuItem deck4ToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBoxDeck4;
        private System.Windows.Forms.RadioButton deck4R6;
        private System.Windows.Forms.RadioButton deck4R5;
        private System.Windows.Forms.RadioButton deck4R4;
        private System.Windows.Forms.RadioButton deck4R3;
        private System.Windows.Forms.RadioButton deck4R2;
        private System.Windows.Forms.RadioButton deck4R1;
        private System.Windows.Forms.GroupBox attackSet1GroupBox;
        private System.Windows.Forms.ToolStripMenuItem changeAttackSetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem attackSet1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem attackSet2ToolStripMenuItem;
        private System.Windows.Forms.GroupBox attackSet2GroupBox;
    }
}

