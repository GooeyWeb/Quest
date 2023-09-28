using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_Quest
{
    public partial class SkillChanger : Form
    {
        public static string skillName;

        public SkillChanger()
        {
            InitializeComponent();

            skill1_pic.BackgroundImage = MainWindow.getSkillPic(MainWindow.person.player.skill1);
            skill2_pic.BackgroundImage = MainWindow.getSkillPic(MainWindow.person.player.skill2);
            skill3_pic.BackgroundImage = MainWindow.getSkillPic(MainWindow.person.player.skill3);
        }

        private void skill1_pic_Click(object sender, EventArgs e)
        {
            MainWindow.person.player.skill1 = skillName;
            this.Close();
        }

        private void skill2_pic_Click(object sender, EventArgs e)
        {
            MainWindow.person.player.skill2 = skillName;
            this.Close();
        }

        private void skill3_pic_Click(object sender, EventArgs e)
        {
            MainWindow.person.player.skill3 = skillName;
            this.Close();
        }

        private void goBack_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
