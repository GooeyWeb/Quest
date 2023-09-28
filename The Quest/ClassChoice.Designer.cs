namespace The_Quest
{
    partial class Classes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Classes));
            this.classes_label = new System.Windows.Forms.Label();
            this.warrior_label = new System.Windows.Forms.Label();
            this.mage_label = new System.Windows.Forms.Label();
            this.rogue_label = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.warrior_pic = new System.Windows.Forms.PictureBox();
            this.rogue_pic = new System.Windows.Forms.PictureBox();
            this.mage_pic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.warrior_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rogue_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mage_pic)).BeginInit();
            this.SuspendLayout();
            // 
            // classes_label
            // 
            this.classes_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.classes_label.ForeColor = System.Drawing.Color.White;
            this.classes_label.Location = new System.Drawing.Point(12, 9);
            this.classes_label.Name = "classes_label";
            this.classes_label.Size = new System.Drawing.Size(360, 82);
            this.classes_label.TabIndex = 0;
            this.classes_label.Text = "Choose your class:";
            this.classes_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // warrior_label
            // 
            this.warrior_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.warrior_label.ForeColor = System.Drawing.Color.White;
            this.warrior_label.Location = new System.Drawing.Point(15, 108);
            this.warrior_label.Name = "warrior_label";
            this.warrior_label.Size = new System.Drawing.Size(99, 39);
            this.warrior_label.TabIndex = 4;
            this.warrior_label.Text = "Warrior";
            this.warrior_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mage_label
            // 
            this.mage_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.mage_label.ForeColor = System.Drawing.Color.White;
            this.mage_label.Location = new System.Drawing.Point(144, 108);
            this.mage_label.Name = "mage_label";
            this.mage_label.Size = new System.Drawing.Size(99, 39);
            this.mage_label.TabIndex = 5;
            this.mage_label.Text = "Mage";
            this.mage_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rogue_label
            // 
            this.rogue_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rogue_label.ForeColor = System.Drawing.Color.White;
            this.rogue_label.Location = new System.Drawing.Point(273, 108);
            this.rogue_label.Name = "rogue_label";
            this.rogue_label.Size = new System.Drawing.Size(99, 39);
            this.rogue_label.TabIndex = 6;
            this.rogue_label.Text = "Rogue";
            this.rogue_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // warrior_pic
            // 
            this.warrior_pic.BackgroundImage = global::The_Quest.Properties.Resources.warrior;
            this.warrior_pic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.warrior_pic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.warrior_pic.Location = new System.Drawing.Point(15, 150);
            this.warrior_pic.Name = "warrior_pic";
            this.warrior_pic.Size = new System.Drawing.Size(99, 99);
            this.warrior_pic.TabIndex = 3;
            this.warrior_pic.TabStop = false;
            this.warrior_pic.Click += new System.EventHandler(this.warrior_pic_Click);
            // 
            // rogue_pic
            // 
            this.rogue_pic.BackgroundImage = global::The_Quest.Properties.Resources.rogue;
            this.rogue_pic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rogue_pic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rogue_pic.Location = new System.Drawing.Point(273, 150);
            this.rogue_pic.Name = "rogue_pic";
            this.rogue_pic.Size = new System.Drawing.Size(99, 99);
            this.rogue_pic.TabIndex = 2;
            this.rogue_pic.TabStop = false;
            this.rogue_pic.Click += new System.EventHandler(this.rogue_pic_Click);
            // 
            // mage_pic
            // 
            this.mage_pic.BackgroundImage = global::The_Quest.Properties.Resources.mage;
            this.mage_pic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mage_pic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mage_pic.Location = new System.Drawing.Point(144, 150);
            this.mage_pic.Name = "mage_pic";
            this.mage_pic.Size = new System.Drawing.Size(99, 99);
            this.mage_pic.TabIndex = 1;
            this.mage_pic.TabStop = false;
            this.mage_pic.Click += new System.EventHandler(this.mage_pic_Click);
            // 
            // Classes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.rogue_label);
            this.Controls.Add(this.mage_label);
            this.Controls.Add(this.warrior_label);
            this.Controls.Add(this.warrior_pic);
            this.Controls.Add(this.rogue_pic);
            this.Controls.Add(this.mage_pic);
            this.Controls.Add(this.classes_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Classes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "The Quest: Class choice";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Classes_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.warrior_pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rogue_pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mage_pic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label classes_label;
        private System.Windows.Forms.PictureBox mage_pic;
        private System.Windows.Forms.PictureBox rogue_pic;
        private System.Windows.Forms.PictureBox warrior_pic;
        private System.Windows.Forms.Label warrior_label;
        private System.Windows.Forms.Label mage_label;
        private System.Windows.Forms.Label rogue_label;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}