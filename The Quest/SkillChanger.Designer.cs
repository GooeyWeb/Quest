namespace The_Quest
{
    partial class SkillChanger
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SkillChanger));
            this.currentItem_label = new System.Windows.Forms.Label();
            this.goBack_btn = new System.Windows.Forms.Button();
            this.skill3_pic = new System.Windows.Forms.PictureBox();
            this.skill1_pic = new System.Windows.Forms.PictureBox();
            this.skill2_pic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.skill3_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skill1_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skill2_pic)).BeginInit();
            this.SuspendLayout();
            // 
            // currentItem_label
            // 
            this.currentItem_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.currentItem_label.Location = new System.Drawing.Point(12, 9);
            this.currentItem_label.Name = "currentItem_label";
            this.currentItem_label.Size = new System.Drawing.Size(460, 30);
            this.currentItem_label.TabIndex = 4;
            this.currentItem_label.Text = "Which skill should I forget?";
            this.currentItem_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // goBack_btn
            // 
            this.goBack_btn.BackColor = System.Drawing.Color.Bisque;
            this.goBack_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.goBack_btn.Location = new System.Drawing.Point(168, 149);
            this.goBack_btn.Name = "goBack_btn";
            this.goBack_btn.Size = new System.Drawing.Size(147, 50);
            this.goBack_btn.TabIndex = 9;
            this.goBack_btn.Text = "Go Back";
            this.goBack_btn.UseVisualStyleBackColor = false;
            this.goBack_btn.Click += new System.EventHandler(this.goBack_btn_Click);
            // 
            // skill3_pic
            // 
            this.skill3_pic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.skill3_pic.Location = new System.Drawing.Point(336, 51);
            this.skill3_pic.Name = "skill3_pic";
            this.skill3_pic.Size = new System.Drawing.Size(81, 81);
            this.skill3_pic.TabIndex = 8;
            this.skill3_pic.TabStop = false;
            this.skill3_pic.Click += new System.EventHandler(this.skill3_pic_Click);
            // 
            // skill1_pic
            // 
            this.skill1_pic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.skill1_pic.Location = new System.Drawing.Point(68, 51);
            this.skill1_pic.Name = "skill1_pic";
            this.skill1_pic.Size = new System.Drawing.Size(81, 81);
            this.skill1_pic.TabIndex = 7;
            this.skill1_pic.TabStop = false;
            this.skill1_pic.Click += new System.EventHandler(this.skill1_pic_Click);
            // 
            // skill2_pic
            // 
            this.skill2_pic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.skill2_pic.Location = new System.Drawing.Point(202, 51);
            this.skill2_pic.Name = "skill2_pic";
            this.skill2_pic.Size = new System.Drawing.Size(81, 81);
            this.skill2_pic.TabIndex = 6;
            this.skill2_pic.TabStop = false;
            this.skill2_pic.Click += new System.EventHandler(this.skill2_pic_Click);
            // 
            // SkillChanger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(484, 211);
            this.Controls.Add(this.goBack_btn);
            this.Controls.Add(this.skill3_pic);
            this.Controls.Add(this.skill1_pic);
            this.Controls.Add(this.skill2_pic);
            this.Controls.Add(this.currentItem_label);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SkillChanger";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "The Quest: Change skill";
            ((System.ComponentModel.ISupportInitialize)(this.skill3_pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skill1_pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skill2_pic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label currentItem_label;
        public System.Windows.Forms.PictureBox skill2_pic;
        public System.Windows.Forms.PictureBox skill1_pic;
        public System.Windows.Forms.PictureBox skill3_pic;
        private System.Windows.Forms.Button goBack_btn;
    }
}