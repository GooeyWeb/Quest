namespace The_Quest
{
    partial class MainWindow
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.btn_QM = new System.Windows.Forms.Button();
            this.Player = new System.Windows.Forms.PictureBox();
            this.btn_fullList = new System.Windows.Forms.Button();
            this.quest3 = new System.Windows.Forms.PictureBox();
            this.quest1 = new System.Windows.Forms.PictureBox();
            this.quest5 = new System.Windows.Forms.PictureBox();
            this.quest2 = new System.Windows.Forms.PictureBox();
            this.quest4 = new System.Windows.Forms.PictureBox();
            this.quest6 = new System.Windows.Forms.PictureBox();
            this.quest1diff = new System.Windows.Forms.PictureBox();
            this.quest2diff = new System.Windows.Forms.PictureBox();
            this.quest3diff = new System.Windows.Forms.PictureBox();
            this.quest4diff = new System.Windows.Forms.PictureBox();
            this.quest5diff = new System.Windows.Forms.PictureBox();
            this.quest6diff = new System.Windows.Forms.PictureBox();
            this.quest1title = new System.Windows.Forms.Label();
            this.quest2title = new System.Windows.Forms.Label();
            this.quest4title = new System.Windows.Forms.Label();
            this.quest3title = new System.Windows.Forms.Label();
            this.quest6title = new System.Windows.Forms.Label();
            this.quest5title = new System.Windows.Forms.Label();
            this.quest1claim = new System.Windows.Forms.Button();
            this.quest2claim = new System.Windows.Forms.Button();
            this.quest3claim = new System.Windows.Forms.Button();
            this.quest4claim = new System.Windows.Forms.Button();
            this.quest6claim = new System.Windows.Forms.Button();
            this.quest5claim = new System.Windows.Forms.Button();
            this.skill1_pic = new System.Windows.Forms.PictureBox();
            this.skill2_pic = new System.Windows.Forms.PictureBox();
            this.skill3_pic = new System.Windows.Forms.PictureBox();
            this.boss_pic = new System.Windows.Forms.PictureBox();
            this.enemy1_pic = new System.Windows.Forms.PictureBox();
            this.enemy3_pic = new System.Windows.Forms.PictureBox();
            this.enemy2_pic = new System.Windows.Forms.PictureBox();
            this.healthbar1 = new System.Windows.Forms.ProgressBar();
            this.healthbar2 = new System.Windows.Forms.ProgressBar();
            this.healthbar3 = new System.Windows.Forms.ProgressBar();
            this.bosshealthbar = new System.Windows.Forms.ProgressBar();
            this.nextFight_btn = new System.Windows.Forms.Button();
            this.playerhealtbar = new System.Windows.Forms.ProgressBar();
            this.run_pic = new System.Windows.Forms.PictureBox();
            this.info = new System.Windows.Forms.Label();
            this.guide_pic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quest3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quest1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quest5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quest2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quest4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quest6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quest1diff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quest2diff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quest3diff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quest4diff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quest5diff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quest6diff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skill1_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skill2_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skill3_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boss_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy1_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy3_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy2_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.run_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guide_pic)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_QM
            // 
            this.btn_QM.BackColor = System.Drawing.Color.Transparent;
            this.btn_QM.BackgroundImage = global::The_Quest.Properties.Resources.questScrollBG;
            this.btn_QM.FlatAppearance.BorderSize = 0;
            this.btn_QM.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_QM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_QM.Location = new System.Drawing.Point(255, 401);
            this.btn_QM.Name = "btn_QM";
            this.btn_QM.Size = new System.Drawing.Size(150, 50);
            this.btn_QM.TabIndex = 0;
            this.btn_QM.Text = "Add a Quest";
            this.btn_QM.UseVisualStyleBackColor = false;
            this.btn_QM.Click += new System.EventHandler(this.btn_QM_Click);
            // 
            // Player
            // 
            this.Player.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Player.Image = global::The_Quest.Properties.Resources.empty;
            this.Player.Location = new System.Drawing.Point(754, 247);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(99, 99);
            this.Player.TabIndex = 2;
            this.Player.TabStop = false;
            this.Player.Click += new System.EventHandler(this.Player_Click);
            // 
            // btn_fullList
            // 
            this.btn_fullList.BackColor = System.Drawing.Color.Transparent;
            this.btn_fullList.BackgroundImage = global::The_Quest.Properties.Resources.questScrollBG;
            this.btn_fullList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_fullList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_fullList.Location = new System.Drawing.Point(436, 400);
            this.btn_fullList.Name = "btn_fullList";
            this.btn_fullList.Size = new System.Drawing.Size(150, 50);
            this.btn_fullList.TabIndex = 3;
            this.btn_fullList.Text = "All Quests";
            this.btn_fullList.UseVisualStyleBackColor = false;
            this.btn_fullList.Click += new System.EventHandler(this.btn_fullList_Click);
            // 
            // quest3
            // 
            this.quest3.BackColor = System.Drawing.Color.Transparent;
            this.quest3.BackgroundImage = global::The_Quest.Properties.Resources.questScroll;
            this.quest3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.quest3.Location = new System.Drawing.Point(321, 69);
            this.quest3.Name = "quest3";
            this.quest3.Size = new System.Drawing.Size(89, 120);
            this.quest3.TabIndex = 5;
            this.quest3.TabStop = false;
            this.quest3.Tag = "";
            // 
            // quest1
            // 
            this.quest1.BackColor = System.Drawing.Color.Transparent;
            this.quest1.BackgroundImage = global::The_Quest.Properties.Resources.questScroll;
            this.quest1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.quest1.Location = new System.Drawing.Point(45, 123);
            this.quest1.Name = "quest1";
            this.quest1.Size = new System.Drawing.Size(89, 120);
            this.quest1.TabIndex = 6;
            this.quest1.TabStop = false;
            this.quest1.Tag = "";
            // 
            // quest5
            // 
            this.quest5.BackColor = System.Drawing.Color.Transparent;
            this.quest5.BackgroundImage = global::The_Quest.Properties.Resources.questScroll;
            this.quest5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.quest5.Location = new System.Drawing.Point(256, 223);
            this.quest5.Name = "quest5";
            this.quest5.Size = new System.Drawing.Size(89, 120);
            this.quest5.TabIndex = 7;
            this.quest5.TabStop = false;
            this.quest5.Tag = "";
            // 
            // quest2
            // 
            this.quest2.BackColor = System.Drawing.Color.Transparent;
            this.quest2.BackgroundImage = global::The_Quest.Properties.Resources.questScroll;
            this.quest2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.quest2.Location = new System.Drawing.Point(178, 91);
            this.quest2.Name = "quest2";
            this.quest2.Size = new System.Drawing.Size(89, 120);
            this.quest2.TabIndex = 8;
            this.quest2.TabStop = false;
            this.quest2.Tag = "";
            // 
            // quest4
            // 
            this.quest4.BackColor = System.Drawing.Color.Transparent;
            this.quest4.BackgroundImage = global::The_Quest.Properties.Resources.questScroll;
            this.quest4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.quest4.Location = new System.Drawing.Point(456, 91);
            this.quest4.Name = "quest4";
            this.quest4.Size = new System.Drawing.Size(89, 120);
            this.quest4.TabIndex = 9;
            this.quest4.TabStop = false;
            this.quest4.Tag = "";
            // 
            // quest6
            // 
            this.quest6.BackColor = System.Drawing.Color.Transparent;
            this.quest6.BackgroundImage = global::The_Quest.Properties.Resources.questScroll;
            this.quest6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.quest6.Location = new System.Drawing.Point(390, 244);
            this.quest6.Name = "quest6";
            this.quest6.Size = new System.Drawing.Size(89, 120);
            this.quest6.TabIndex = 10;
            this.quest6.TabStop = false;
            this.quest6.Tag = "";
            // 
            // quest1diff
            // 
            this.quest1diff.BackColor = System.Drawing.Color.Transparent;
            this.quest1diff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.quest1diff.Image = global::The_Quest.Properties.Resources.empty;
            this.quest1diff.Location = new System.Drawing.Point(73, 166);
            this.quest1diff.Name = "quest1diff";
            this.quest1diff.Size = new System.Drawing.Size(31, 31);
            this.quest1diff.TabIndex = 11;
            this.quest1diff.TabStop = false;
            this.quest1diff.Tag = "";
            // 
            // quest2diff
            // 
            this.quest2diff.BackColor = System.Drawing.Color.Transparent;
            this.quest2diff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.quest2diff.ErrorImage = global::The_Quest.Properties.Resources.empty;
            this.quest2diff.Location = new System.Drawing.Point(206, 134);
            this.quest2diff.Name = "quest2diff";
            this.quest2diff.Size = new System.Drawing.Size(31, 31);
            this.quest2diff.TabIndex = 12;
            this.quest2diff.TabStop = false;
            this.quest2diff.Tag = "";
            // 
            // quest3diff
            // 
            this.quest3diff.BackColor = System.Drawing.Color.Transparent;
            this.quest3diff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.quest3diff.Image = global::The_Quest.Properties.Resources.empty;
            this.quest3diff.Location = new System.Drawing.Point(349, 111);
            this.quest3diff.Name = "quest3diff";
            this.quest3diff.Size = new System.Drawing.Size(31, 31);
            this.quest3diff.TabIndex = 13;
            this.quest3diff.TabStop = false;
            this.quest3diff.Tag = "";
            // 
            // quest4diff
            // 
            this.quest4diff.BackColor = System.Drawing.Color.Transparent;
            this.quest4diff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.quest4diff.Image = global::The_Quest.Properties.Resources.empty;
            this.quest4diff.Location = new System.Drawing.Point(483, 134);
            this.quest4diff.Name = "quest4diff";
            this.quest4diff.Size = new System.Drawing.Size(31, 31);
            this.quest4diff.TabIndex = 14;
            this.quest4diff.TabStop = false;
            this.quest4diff.Tag = "";
            // 
            // quest5diff
            // 
            this.quest5diff.BackColor = System.Drawing.Color.Transparent;
            this.quest5diff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.quest5diff.Image = global::The_Quest.Properties.Resources.empty;
            this.quest5diff.Location = new System.Drawing.Point(284, 264);
            this.quest5diff.Name = "quest5diff";
            this.quest5diff.Size = new System.Drawing.Size(31, 31);
            this.quest5diff.TabIndex = 15;
            this.quest5diff.TabStop = false;
            this.quest5diff.Tag = "";
            // 
            // quest6diff
            // 
            this.quest6diff.BackColor = System.Drawing.Color.Transparent;
            this.quest6diff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.quest6diff.Image = global::The_Quest.Properties.Resources.empty;
            this.quest6diff.Location = new System.Drawing.Point(418, 288);
            this.quest6diff.Name = "quest6diff";
            this.quest6diff.Size = new System.Drawing.Size(31, 31);
            this.quest6diff.TabIndex = 16;
            this.quest6diff.TabStop = false;
            this.quest6diff.Tag = "";
            // 
            // quest1title
            // 
            this.quest1title.BackColor = System.Drawing.Color.Transparent;
            this.quest1title.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.quest1title.Image = global::The_Quest.Properties.Resources.questScrollBG2;
            this.quest1title.Location = new System.Drawing.Point(50, 144);
            this.quest1title.Name = "quest1title";
            this.quest1title.Size = new System.Drawing.Size(79, 23);
            this.quest1title.TabIndex = 17;
            this.quest1title.Tag = "";
            this.quest1title.Text = "Title";
            this.quest1title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // quest2title
            // 
            this.quest2title.BackColor = System.Drawing.Color.Transparent;
            this.quest2title.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.quest2title.Image = global::The_Quest.Properties.Resources.questScrollBG2;
            this.quest2title.Location = new System.Drawing.Point(184, 113);
            this.quest2title.Name = "quest2title";
            this.quest2title.Size = new System.Drawing.Size(78, 21);
            this.quest2title.TabIndex = 18;
            this.quest2title.Tag = "";
            this.quest2title.Text = "Title";
            this.quest2title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // quest4title
            // 
            this.quest4title.BackColor = System.Drawing.Color.Transparent;
            this.quest4title.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.quest4title.Image = global::The_Quest.Properties.Resources.questScrollBG2;
            this.quest4title.Location = new System.Drawing.Point(461, 113);
            this.quest4title.Name = "quest4title";
            this.quest4title.Size = new System.Drawing.Size(79, 22);
            this.quest4title.TabIndex = 19;
            this.quest4title.Tag = "";
            this.quest4title.Text = "Title";
            this.quest4title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // quest3title
            // 
            this.quest3title.BackColor = System.Drawing.Color.Transparent;
            this.quest3title.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.quest3title.Image = global::The_Quest.Properties.Resources.questScrollBG2;
            this.quest3title.Location = new System.Drawing.Point(325, 91);
            this.quest3title.Name = "quest3title";
            this.quest3title.Size = new System.Drawing.Size(81, 20);
            this.quest3title.TabIndex = 20;
            this.quest3title.Tag = "";
            this.quest3title.Text = "Title";
            this.quest3title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // quest6title
            // 
            this.quest6title.BackColor = System.Drawing.Color.Transparent;
            this.quest6title.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.quest6title.Image = global::The_Quest.Properties.Resources.questScrollBG2;
            this.quest6title.Location = new System.Drawing.Point(395, 266);
            this.quest6title.Name = "quest6title";
            this.quest6title.Size = new System.Drawing.Size(79, 22);
            this.quest6title.TabIndex = 21;
            this.quest6title.Text = "Title";
            this.quest6title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // quest5title
            // 
            this.quest5title.BackColor = System.Drawing.Color.Transparent;
            this.quest5title.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.quest5title.Image = global::The_Quest.Properties.Resources.questScrollBG2;
            this.quest5title.Location = new System.Drawing.Point(261, 244);
            this.quest5title.Name = "quest5title";
            this.quest5title.Size = new System.Drawing.Size(79, 21);
            this.quest5title.TabIndex = 22;
            this.quest5title.Text = "Title";
            this.quest5title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // quest1claim
            // 
            this.quest1claim.BackColor = System.Drawing.Color.Transparent;
            this.quest1claim.BackgroundImage = global::The_Quest.Properties.Resources.questScrollBG;
            this.quest1claim.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.quest1claim.FlatAppearance.BorderSize = 0;
            this.quest1claim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.quest1claim.Location = new System.Drawing.Point(52, 198);
            this.quest1claim.Name = "quest1claim";
            this.quest1claim.Size = new System.Drawing.Size(76, 32);
            this.quest1claim.TabIndex = 23;
            this.quest1claim.Tag = "";
            this.quest1claim.Text = "Claim";
            this.quest1claim.UseVisualStyleBackColor = false;
            this.quest1claim.Click += new System.EventHandler(this.quest1claim_Click);
            // 
            // quest2claim
            // 
            this.quest2claim.BackColor = System.Drawing.Color.Transparent;
            this.quest2claim.BackgroundImage = global::The_Quest.Properties.Resources.questScrollBG;
            this.quest2claim.FlatAppearance.BorderSize = 0;
            this.quest2claim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.quest2claim.Location = new System.Drawing.Point(185, 166);
            this.quest2claim.Name = "quest2claim";
            this.quest2claim.Size = new System.Drawing.Size(76, 32);
            this.quest2claim.TabIndex = 24;
            this.quest2claim.Tag = "";
            this.quest2claim.Text = "Claim";
            this.quest2claim.UseVisualStyleBackColor = false;
            this.quest2claim.Click += new System.EventHandler(this.quest2claim_Click);
            // 
            // quest3claim
            // 
            this.quest3claim.BackColor = System.Drawing.Color.Transparent;
            this.quest3claim.BackgroundImage = global::The_Quest.Properties.Resources.questScrollBG;
            this.quest3claim.FlatAppearance.BorderSize = 0;
            this.quest3claim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.quest3claim.Location = new System.Drawing.Point(328, 143);
            this.quest3claim.Name = "quest3claim";
            this.quest3claim.Size = new System.Drawing.Size(76, 32);
            this.quest3claim.TabIndex = 25;
            this.quest3claim.Tag = "";
            this.quest3claim.Text = "Claim";
            this.quest3claim.UseVisualStyleBackColor = false;
            this.quest3claim.Click += new System.EventHandler(this.quest3claim_Click);
            // 
            // quest4claim
            // 
            this.quest4claim.BackColor = System.Drawing.Color.Transparent;
            this.quest4claim.BackgroundImage = global::The_Quest.Properties.Resources.questScrollBG;
            this.quest4claim.FlatAppearance.BorderSize = 0;
            this.quest4claim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.quest4claim.Location = new System.Drawing.Point(462, 166);
            this.quest4claim.Name = "quest4claim";
            this.quest4claim.Size = new System.Drawing.Size(76, 32);
            this.quest4claim.TabIndex = 26;
            this.quest4claim.Tag = "";
            this.quest4claim.Text = "Claim";
            this.quest4claim.UseVisualStyleBackColor = false;
            this.quest4claim.Click += new System.EventHandler(this.quest4claim_Click);
            // 
            // quest6claim
            // 
            this.quest6claim.BackColor = System.Drawing.Color.Transparent;
            this.quest6claim.BackgroundImage = global::The_Quest.Properties.Resources.questScrollBG;
            this.quest6claim.FlatAppearance.BorderSize = 0;
            this.quest6claim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.quest6claim.Location = new System.Drawing.Point(397, 320);
            this.quest6claim.Name = "quest6claim";
            this.quest6claim.Size = new System.Drawing.Size(73, 32);
            this.quest6claim.TabIndex = 27;
            this.quest6claim.Tag = "";
            this.quest6claim.Text = "Claim";
            this.quest6claim.UseVisualStyleBackColor = false;
            this.quest6claim.Click += new System.EventHandler(this.quest6claim_Click);
            // 
            // quest5claim
            // 
            this.quest5claim.BackColor = System.Drawing.Color.Transparent;
            this.quest5claim.BackgroundImage = global::The_Quest.Properties.Resources.questScrollBG;
            this.quest5claim.FlatAppearance.BorderSize = 0;
            this.quest5claim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.quest5claim.Location = new System.Drawing.Point(263, 297);
            this.quest5claim.Name = "quest5claim";
            this.quest5claim.Size = new System.Drawing.Size(75, 32);
            this.quest5claim.TabIndex = 28;
            this.quest5claim.Tag = "";
            this.quest5claim.Text = "Claim";
            this.quest5claim.UseVisualStyleBackColor = false;
            this.quest5claim.Click += new System.EventHandler(this.quest5claim_Click);
            // 
            // skill1_pic
            // 
            this.skill1_pic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.skill1_pic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.skill1_pic.Location = new System.Drawing.Point(660, 402);
            this.skill1_pic.Name = "skill1_pic";
            this.skill1_pic.Size = new System.Drawing.Size(70, 70);
            this.skill1_pic.TabIndex = 29;
            this.skill1_pic.TabStop = false;
            this.skill1_pic.Click += new System.EventHandler(this.skill1_pic_Click);
            // 
            // skill2_pic
            // 
            this.skill2_pic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.skill2_pic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.skill2_pic.Location = new System.Drawing.Point(768, 402);
            this.skill2_pic.Name = "skill2_pic";
            this.skill2_pic.Size = new System.Drawing.Size(70, 70);
            this.skill2_pic.TabIndex = 30;
            this.skill2_pic.TabStop = false;
            this.skill2_pic.Click += new System.EventHandler(this.skill2_pic_Click);
            // 
            // skill3_pic
            // 
            this.skill3_pic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.skill3_pic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.skill3_pic.Location = new System.Drawing.Point(877, 402);
            this.skill3_pic.Name = "skill3_pic";
            this.skill3_pic.Size = new System.Drawing.Size(70, 70);
            this.skill3_pic.TabIndex = 31;
            this.skill3_pic.TabStop = false;
            this.skill3_pic.Click += new System.EventHandler(this.skill3_pic_Click);
            // 
            // boss_pic
            // 
            this.boss_pic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.boss_pic.Location = new System.Drawing.Point(705, 31);
            this.boss_pic.Name = "boss_pic";
            this.boss_pic.Size = new System.Drawing.Size(198, 198);
            this.boss_pic.TabIndex = 32;
            this.boss_pic.TabStop = false;
            this.boss_pic.Visible = false;
            this.boss_pic.Click += new System.EventHandler(this.boss_pic_Click);
            // 
            // enemy1_pic
            // 
            this.enemy1_pic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.enemy1_pic.Location = new System.Drawing.Point(631, 93);
            this.enemy1_pic.Name = "enemy1_pic";
            this.enemy1_pic.Size = new System.Drawing.Size(99, 99);
            this.enemy1_pic.TabIndex = 33;
            this.enemy1_pic.TabStop = false;
            this.enemy1_pic.Visible = false;
            this.enemy1_pic.Click += new System.EventHandler(this.enemy1_pic_Click);
            // 
            // enemy3_pic
            // 
            this.enemy3_pic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.enemy3_pic.Location = new System.Drawing.Point(877, 93);
            this.enemy3_pic.Name = "enemy3_pic";
            this.enemy3_pic.Size = new System.Drawing.Size(99, 99);
            this.enemy3_pic.TabIndex = 34;
            this.enemy3_pic.TabStop = false;
            this.enemy3_pic.Visible = false;
            this.enemy3_pic.Click += new System.EventHandler(this.enemy3_pic_Click);
            // 
            // enemy2_pic
            // 
            this.enemy2_pic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.enemy2_pic.Location = new System.Drawing.Point(754, 51);
            this.enemy2_pic.Name = "enemy2_pic";
            this.enemy2_pic.Size = new System.Drawing.Size(99, 99);
            this.enemy2_pic.TabIndex = 35;
            this.enemy2_pic.TabStop = false;
            this.enemy2_pic.Visible = false;
            this.enemy2_pic.Click += new System.EventHandler(this.enemy2_pic_Click);
            // 
            // healthbar1
            // 
            this.healthbar1.Location = new System.Drawing.Point(631, 75);
            this.healthbar1.Maximum = 0;
            this.healthbar1.Name = "healthbar1";
            this.healthbar1.Size = new System.Drawing.Size(99, 12);
            this.healthbar1.TabIndex = 36;
            this.healthbar1.Visible = false;
            // 
            // healthbar2
            // 
            this.healthbar2.Location = new System.Drawing.Point(754, 33);
            this.healthbar2.Maximum = 0;
            this.healthbar2.Name = "healthbar2";
            this.healthbar2.Size = new System.Drawing.Size(99, 12);
            this.healthbar2.TabIndex = 37;
            this.healthbar2.Visible = false;
            // 
            // healthbar3
            // 
            this.healthbar3.Location = new System.Drawing.Point(877, 75);
            this.healthbar3.Maximum = 0;
            this.healthbar3.Name = "healthbar3";
            this.healthbar3.Size = new System.Drawing.Size(99, 12);
            this.healthbar3.TabIndex = 38;
            this.healthbar3.Visible = false;
            // 
            // bosshealthbar
            // 
            this.bosshealthbar.Location = new System.Drawing.Point(678, 7);
            this.bosshealthbar.Maximum = 0;
            this.bosshealthbar.Name = "bosshealthbar";
            this.bosshealthbar.Size = new System.Drawing.Size(250, 18);
            this.bosshealthbar.TabIndex = 39;
            this.bosshealthbar.Visible = false;
            // 
            // nextFight_btn
            // 
            this.nextFight_btn.Location = new System.Drawing.Point(717, 51);
            this.nextFight_btn.Name = "nextFight_btn";
            this.nextFight_btn.Size = new System.Drawing.Size(171, 32);
            this.nextFight_btn.TabIndex = 40;
            this.nextFight_btn.Tag = "";
            this.nextFight_btn.Text = "Go ahead...";
            this.nextFight_btn.UseVisualStyleBackColor = true;
            this.nextFight_btn.Click += new System.EventHandler(this.nextFight_btn_Click);
            // 
            // playerhealtbar
            // 
            this.playerhealtbar.Location = new System.Drawing.Point(754, 234);
            this.playerhealtbar.Maximum = 1;
            this.playerhealtbar.Name = "playerhealtbar";
            this.playerhealtbar.Size = new System.Drawing.Size(99, 12);
            this.playerhealtbar.TabIndex = 41;
            this.playerhealtbar.Value = 1;
            // 
            // run_pic
            // 
            this.run_pic.BackgroundImage = global::The_Quest.Properties.Resources.run;
            this.run_pic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.run_pic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.run_pic.Location = new System.Drawing.Point(941, 337);
            this.run_pic.Name = "run_pic";
            this.run_pic.Size = new System.Drawing.Size(40, 40);
            this.run_pic.TabIndex = 42;
            this.run_pic.TabStop = false;
            this.run_pic.Visible = false;
            this.run_pic.Click += new System.EventHandler(this.run_pic_Click);
            // 
            // info
            // 
            this.info.BackColor = System.Drawing.Color.Transparent;
            this.info.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.info.Location = new System.Drawing.Point(236, 487);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(362, 49);
            this.info.TabIndex = 43;
            this.info.Text = "info text";
            this.info.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // guide_pic
            // 
            this.guide_pic.BackgroundImage = global::The_Quest.Properties.Resources.guidebook;
            this.guide_pic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.guide_pic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guide_pic.Location = new System.Drawing.Point(922, 504);
            this.guide_pic.Name = "guide_pic";
            this.guide_pic.Size = new System.Drawing.Size(40, 40);
            this.guide_pic.TabIndex = 44;
            this.guide_pic.TabStop = false;
            this.guide_pic.Click += new System.EventHandler(this.guide_pic_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.BackgroundImage = global::The_Quest.Properties.Resources.TYMCZASOWE_MainWindow1;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.guide_pic);
            this.Controls.Add(this.info);
            this.Controls.Add(this.run_pic);
            this.Controls.Add(this.playerhealtbar);
            this.Controls.Add(this.nextFight_btn);
            this.Controls.Add(this.bosshealthbar);
            this.Controls.Add(this.healthbar3);
            this.Controls.Add(this.healthbar2);
            this.Controls.Add(this.healthbar1);
            this.Controls.Add(this.enemy2_pic);
            this.Controls.Add(this.enemy3_pic);
            this.Controls.Add(this.enemy1_pic);
            this.Controls.Add(this.boss_pic);
            this.Controls.Add(this.skill3_pic);
            this.Controls.Add(this.skill2_pic);
            this.Controls.Add(this.skill1_pic);
            this.Controls.Add(this.quest5claim);
            this.Controls.Add(this.quest6claim);
            this.Controls.Add(this.quest4claim);
            this.Controls.Add(this.quest3claim);
            this.Controls.Add(this.quest2claim);
            this.Controls.Add(this.quest1claim);
            this.Controls.Add(this.quest5title);
            this.Controls.Add(this.quest6title);
            this.Controls.Add(this.quest3title);
            this.Controls.Add(this.quest4title);
            this.Controls.Add(this.quest2title);
            this.Controls.Add(this.quest1title);
            this.Controls.Add(this.quest6diff);
            this.Controls.Add(this.quest5diff);
            this.Controls.Add(this.quest4diff);
            this.Controls.Add(this.quest3diff);
            this.Controls.Add(this.quest2diff);
            this.Controls.Add(this.quest1diff);
            this.Controls.Add(this.quest6);
            this.Controls.Add(this.quest4);
            this.Controls.Add(this.quest2);
            this.Controls.Add(this.quest5);
            this.Controls.Add(this.quest1);
            this.Controls.Add(this.quest3);
            this.Controls.Add(this.btn_fullList);
            this.Controls.Add(this.Player);
            this.Controls.Add(this.btn_QM);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "The Quest";
            this.Activated += new System.EventHandler(this.MainWindow_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainWindow_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quest3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quest1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quest5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quest2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quest4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quest6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quest1diff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quest2diff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quest3diff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quest4diff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quest5diff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quest6diff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skill1_pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skill2_pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skill3_pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boss_pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy1_pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy3_pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy2_pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.run_pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guide_pic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_QM;
        private System.Windows.Forms.PictureBox Player;
        private System.Windows.Forms.Button btn_fullList;
        public System.Windows.Forms.PictureBox quest1;
        public System.Windows.Forms.PictureBox quest1diff;
        public System.Windows.Forms.PictureBox quest2diff;
        public System.Windows.Forms.PictureBox quest3diff;
        public System.Windows.Forms.PictureBox quest4diff;
        public System.Windows.Forms.PictureBox quest5diff;
        public System.Windows.Forms.PictureBox quest6diff;
        public System.Windows.Forms.Label quest1title;
        public System.Windows.Forms.Label quest2title;
        public System.Windows.Forms.Label quest4title;
        public System.Windows.Forms.Label quest3title;
        public System.Windows.Forms.Label quest6title;
        public System.Windows.Forms.Label quest5title;
        public System.Windows.Forms.PictureBox quest3;
        public System.Windows.Forms.PictureBox quest5;
        public System.Windows.Forms.PictureBox quest2;
        public System.Windows.Forms.PictureBox quest4;
        public System.Windows.Forms.PictureBox quest6;
        public System.Windows.Forms.Button quest1claim;
        public System.Windows.Forms.Button quest2claim;
        public System.Windows.Forms.Button quest3claim;
        public System.Windows.Forms.Button quest4claim;
        public System.Windows.Forms.Button quest6claim;
        public System.Windows.Forms.Button quest5claim;
        public System.Windows.Forms.PictureBox skill1_pic;
        public System.Windows.Forms.PictureBox skill2_pic;
        public System.Windows.Forms.PictureBox skill3_pic;
        public System.Windows.Forms.PictureBox boss_pic;
        public System.Windows.Forms.PictureBox enemy1_pic;
        public System.Windows.Forms.PictureBox enemy3_pic;
        public System.Windows.Forms.PictureBox enemy2_pic;
        public System.Windows.Forms.ProgressBar healthbar1;
        public System.Windows.Forms.ProgressBar healthbar2;
        public System.Windows.Forms.ProgressBar healthbar3;
        public System.Windows.Forms.ProgressBar bosshealthbar;
        public System.Windows.Forms.Button nextFight_btn;
        public System.Windows.Forms.ProgressBar playerhealtbar;
        public System.Windows.Forms.PictureBox run_pic;
        public System.Windows.Forms.Label info;
        public System.Windows.Forms.PictureBox guide_pic;
    }
}

