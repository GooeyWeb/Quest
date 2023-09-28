namespace The_Quest
{
    partial class QuestMaker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuestMaker));
            this.diff_easy = new System.Windows.Forms.RadioButton();
            this.diff_normal = new System.Windows.Forms.RadioButton();
            this.diff_hard = new System.Windows.Forms.RadioButton();
            this.diff_legendary = new System.Windows.Forms.RadioButton();
            this.submit = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.TextBox();
            this.title_label = new System.Windows.Forms.Label();
            this.description_label = new System.Windows.Forms.Label();
            this.description = new System.Windows.Forms.TextBox();
            this.error_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // diff_easy
            // 
            this.diff_easy.Appearance = System.Windows.Forms.Appearance.Button;
            this.diff_easy.BackColor = System.Drawing.Color.Bisque;
            this.diff_easy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.diff_easy.Location = new System.Drawing.Point(63, 289);
            this.diff_easy.Name = "diff_easy";
            this.diff_easy.Size = new System.Drawing.Size(70, 70);
            this.diff_easy.TabIndex = 1;
            this.diff_easy.TabStop = true;
            this.diff_easy.Text = "Easy";
            this.diff_easy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.diff_easy.UseVisualStyleBackColor = false;
            // 
            // diff_normal
            // 
            this.diff_normal.Appearance = System.Windows.Forms.Appearance.Button;
            this.diff_normal.BackColor = System.Drawing.Color.Bisque;
            this.diff_normal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.diff_normal.Location = new System.Drawing.Point(161, 289);
            this.diff_normal.Name = "diff_normal";
            this.diff_normal.Size = new System.Drawing.Size(70, 70);
            this.diff_normal.TabIndex = 2;
            this.diff_normal.TabStop = true;
            this.diff_normal.Text = "Normal";
            this.diff_normal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.diff_normal.UseVisualStyleBackColor = false;
            // 
            // diff_hard
            // 
            this.diff_hard.Appearance = System.Windows.Forms.Appearance.Button;
            this.diff_hard.BackColor = System.Drawing.Color.Bisque;
            this.diff_hard.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.diff_hard.Location = new System.Drawing.Point(261, 289);
            this.diff_hard.Name = "diff_hard";
            this.diff_hard.Size = new System.Drawing.Size(70, 70);
            this.diff_hard.TabIndex = 3;
            this.diff_hard.TabStop = true;
            this.diff_hard.Text = "Hard";
            this.diff_hard.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.diff_hard.UseVisualStyleBackColor = false;
            // 
            // diff_legendary
            // 
            this.diff_legendary.Appearance = System.Windows.Forms.Appearance.Button;
            this.diff_legendary.BackColor = System.Drawing.Color.Bisque;
            this.diff_legendary.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.diff_legendary.Location = new System.Drawing.Point(359, 289);
            this.diff_legendary.Name = "diff_legendary";
            this.diff_legendary.Size = new System.Drawing.Size(74, 70);
            this.diff_legendary.TabIndex = 4;
            this.diff_legendary.TabStop = true;
            this.diff_legendary.Text = "Legendary";
            this.diff_legendary.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.diff_legendary.UseVisualStyleBackColor = false;
            // 
            // submit
            // 
            this.submit.BackColor = System.Drawing.Color.Bisque;
            this.submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.submit.ForeColor = System.Drawing.Color.Firebrick;
            this.submit.Location = new System.Drawing.Point(141, 398);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(200, 60);
            this.submit.TabIndex = 4;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = false;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // title
            // 
            this.title.BackColor = System.Drawing.Color.Bisque;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.title.Location = new System.Drawing.Point(108, 41);
            this.title.MaxLength = 50;
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(284, 31);
            this.title.TabIndex = 5;
            this.title.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // title_label
            // 
            this.title_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.title_label.Image = global::The_Quest.Properties.Resources.questScrollBG2;
            this.title_label.Location = new System.Drawing.Point(167, 20);
            this.title_label.Name = "title_label";
            this.title_label.Size = new System.Drawing.Size(170, 19);
            this.title_label.TabIndex = 6;
            this.title_label.Text = "Title";
            this.title_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // description_label
            // 
            this.description_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.description_label.Image = global::The_Quest.Properties.Resources.questScrollBG2;
            this.description_label.Location = new System.Drawing.Point(160, 118);
            this.description_label.Name = "description_label";
            this.description_label.Size = new System.Drawing.Size(170, 40);
            this.description_label.TabIndex = 7;
            this.description_label.Text = "Description";
            this.description_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // description
            // 
            this.description.BackColor = System.Drawing.Color.Bisque;
            this.description.Location = new System.Drawing.Point(62, 161);
            this.description.MaxLength = 500;
            this.description.Multiline = true;
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(366, 119);
            this.description.TabIndex = 8;
            // 
            // error_label
            // 
            this.error_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.error_label.ForeColor = System.Drawing.Color.IndianRed;
            this.error_label.Image = global::The_Quest.Properties.Resources.questScrollBG4;
            this.error_label.Location = new System.Drawing.Point(65, 360);
            this.error_label.Name = "error_label";
            this.error_label.Size = new System.Drawing.Size(366, 40);
            this.error_label.TabIndex = 9;
            this.error_label.Text = "You have to fill title and description!";
            this.error_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.error_label.Visible = false;
            // 
            // QuestMaker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::The_Quest.Properties.Resources.questScroll;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.error_label);
            this.Controls.Add(this.description);
            this.Controls.Add(this.description_label);
            this.Controls.Add(this.title_label);
            this.Controls.Add(this.title);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.diff_legendary);
            this.Controls.Add(this.diff_hard);
            this.Controls.Add(this.diff_normal);
            this.Controls.Add(this.diff_easy);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(2, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "QuestMaker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "The Quest: Guild";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.QuestMaker_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.RadioButton diff_easy;
        public System.Windows.Forms.RadioButton diff_normal;
        public System.Windows.Forms.RadioButton diff_hard;
        public System.Windows.Forms.RadioButton diff_legendary;
        private System.Windows.Forms.Button submit;
        public System.Windows.Forms.TextBox title;
        private System.Windows.Forms.Label title_label;
        public System.Windows.Forms.Label description_label;
        private System.Windows.Forms.TextBox description;
        private System.Windows.Forms.Label error_label;
    }
}