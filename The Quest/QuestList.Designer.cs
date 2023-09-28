namespace The_Quest
{
    partial class QuestList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuestList));
            this.quest_list = new System.Windows.Forms.ListBox();
            this.claim_btn = new System.Windows.Forms.Button();
            this.questlist_label = new System.Windows.Forms.Label();
            this.gold_label = new System.Windows.Forms.Label();
            this.gold_pic = new System.Windows.Forms.PictureBox();
            this.description_label = new System.Windows.Forms.Label();
            this.diff_pic = new System.Windows.Forms.PictureBox();
            this.title_label = new System.Windows.Forms.Label();
            this.questBG_pic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.gold_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diff_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.questBG_pic)).BeginInit();
            this.SuspendLayout();
            // 
            // quest_list
            // 
            this.quest_list.BackColor = System.Drawing.Color.Sienna;
            this.quest_list.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.quest_list.ForeColor = System.Drawing.Color.White;
            this.quest_list.FormattingEnabled = true;
            this.quest_list.ItemHeight = 16;
            this.quest_list.Location = new System.Drawing.Point(12, 38);
            this.quest_list.Name = "quest_list";
            this.quest_list.Size = new System.Drawing.Size(136, 388);
            this.quest_list.TabIndex = 0;
            this.quest_list.SelectedIndexChanged += new System.EventHandler(this.quest_list_SelectedIndexChanged);
            // 
            // claim_btn
            // 
            this.claim_btn.BackColor = System.Drawing.Color.Bisque;
            this.claim_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.claim_btn.Location = new System.Drawing.Point(213, 386);
            this.claim_btn.Name = "claim_btn";
            this.claim_btn.Size = new System.Drawing.Size(211, 59);
            this.claim_btn.TabIndex = 6;
            this.claim_btn.Text = "Claim reward";
            this.claim_btn.UseVisualStyleBackColor = false;
            this.claim_btn.Click += new System.EventHandler(this.claim_btn_Click);
            // 
            // questlist_label
            // 
            this.questlist_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.questlist_label.Location = new System.Drawing.Point(12, 9);
            this.questlist_label.Name = "questlist_label";
            this.questlist_label.Size = new System.Drawing.Size(136, 26);
            this.questlist_label.TabIndex = 10;
            this.questlist_label.Text = "Your quests:";
            this.questlist_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gold_label
            // 
            this.gold_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gold_label.Image = global::The_Quest.Properties.Resources.questScrollBG2;
            this.gold_label.Location = new System.Drawing.Point(224, 335);
            this.gold_label.Name = "gold_label";
            this.gold_label.Size = new System.Drawing.Size(187, 25);
            this.gold_label.TabIndex = 9;
            this.gold_label.Text = "0";
            this.gold_label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gold_pic
            // 
            this.gold_pic.BackgroundImage = global::The_Quest.Properties.Resources.moneyStackIcon;
            this.gold_pic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gold_pic.Location = new System.Drawing.Point(412, 331);
            this.gold_pic.Name = "gold_pic";
            this.gold_pic.Size = new System.Drawing.Size(33, 31);
            this.gold_pic.TabIndex = 8;
            this.gold_pic.TabStop = false;
            // 
            // description_label
            // 
            this.description_label.Image = global::The_Quest.Properties.Resources.questScrollBG4;
            this.description_label.Location = new System.Drawing.Point(172, 193);
            this.description_label.Name = "description_label";
            this.description_label.Size = new System.Drawing.Size(282, 134);
            this.description_label.TabIndex = 7;
            this.description_label.Text = "Quest description";
            this.description_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // diff_pic
            // 
            this.diff_pic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.diff_pic.Location = new System.Drawing.Point(278, 128);
            this.diff_pic.Name = "diff_pic";
            this.diff_pic.Size = new System.Drawing.Size(63, 60);
            this.diff_pic.TabIndex = 5;
            this.diff_pic.TabStop = false;
            // 
            // title_label
            // 
            this.title_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.title_label.Image = global::The_Quest.Properties.Resources.questScrollBG4;
            this.title_label.Location = new System.Drawing.Point(172, 92);
            this.title_label.Name = "title_label";
            this.title_label.Size = new System.Drawing.Size(279, 38);
            this.title_label.TabIndex = 4;
            this.title_label.Text = "Quest title";
            this.title_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // questBG_pic
            // 
            this.questBG_pic.BackgroundImage = global::The_Quest.Properties.Resources.questScroll;
            this.questBG_pic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.questBG_pic.Location = new System.Drawing.Point(154, 12);
            this.questBG_pic.Name = "questBG_pic";
            this.questBG_pic.Size = new System.Drawing.Size(318, 368);
            this.questBG_pic.TabIndex = 3;
            this.questBG_pic.TabStop = false;
            // 
            // QuestList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.questlist_label);
            this.Controls.Add(this.gold_label);
            this.Controls.Add(this.gold_pic);
            this.Controls.Add(this.description_label);
            this.Controls.Add(this.claim_btn);
            this.Controls.Add(this.diff_pic);
            this.Controls.Add(this.title_label);
            this.Controls.Add(this.questBG_pic);
            this.Controls.Add(this.quest_list);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "QuestList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "The Quest: Guild Board";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.QuestList_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.gold_pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diff_pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.questBG_pic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox quest_list;
        private System.Windows.Forms.PictureBox questBG_pic;
        public System.Windows.Forms.Label title_label;
        public System.Windows.Forms.PictureBox diff_pic;
        private System.Windows.Forms.Button claim_btn;
        public System.Windows.Forms.Label description_label;
        public System.Windows.Forms.PictureBox gold_pic;
        public System.Windows.Forms.Label gold_label;
        public System.Windows.Forms.Label questlist_label;
    }
}