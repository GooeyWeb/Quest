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
    public partial class GuideBook : Form
    {
        public static List<TabPage> tabs = new List<TabPage>();
        public GuideBook()
        {
            InitializeComponent();
            downloadTabs();
            deleteTabsFromControl();

            if(MainWindow.person.player.classID == 2)
            {
                insideFury_label.Text = "Fell the infinite energy, increase your magic power for the rest of the fight";
            }    
        }
        public void loadTab(int number)
        {
            deleteTabsFromControl();
            tabControl1.TabPages.Add(tabs[number]);
            tabControl1.SelectTab(tabs[number]);
        }
        public void downloadTabs()
        {
            tabs.Add(tabPage1);
            tabs.Add(tabPage2);
            tabs.Add(tabPage3);
            tabs.Add(tabPage4);
            tabs.Add(tabPage5);
            tabs.Add(tabPage6);
        }
        public void deleteTabsFromControl()
        {
            tabControl1.TabPages.Remove(tabPage1);
            tabControl1.TabPages.Remove(tabPage2);
            tabControl1.TabPages.Remove(tabPage3);
            tabControl1.TabPages.Remove(tabPage4);
            tabControl1.TabPages.Remove(tabPage5);
            tabControl1.TabPages.Remove(tabPage6);
        }
        public void updatePics()
        {
            if (MainWindow.person.player.bossClear > 1)
            {
                stage2_pic.BackgroundImage = Properties.Resources.wolf;
            }
            else if (MainWindow.person.player.bossClear > 0)
            {
                stage3_pic.BackgroundImage = Properties.Resources.skeleton;
            }
        }
        public void changeSkill(string skill)
        {
            SkillChanger.skillName = skill;
            SkillChanger changer = new SkillChanger();
            changer.ShowDialog();
        }

        private void GuideBook_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainWindow.isGuideOpen = false;
        }

        private void attack_pic_Click(object sender, EventArgs e)
        {
            loadTab(0);
        }
        private void defense_pic_Click(object sender, EventArgs e)
        {
            loadTab(1);
        }
        private void magic_pic_Click(object sender, EventArgs e)
        {
            loadTab(2);
        }
        private void stage1_pic_Click(object sender, EventArgs e)
        {
            loadTab(3);
        }
        private void stage2_pic_Click(object sender, EventArgs e)
        {
            if(MainWindow.person.player.bossClear > 0)
            {
                loadTab(4);
            }
        }
        private void stage3_pic_Click(object sender, EventArgs e)
        {
            if (MainWindow.person.player.bossClear > 1)
            {
                loadTab(5);
            }
        }



        private void directAttack_btn_Click(object sender, EventArgs e)
        {
            changeSkill("Direct Attack");
        }
        private void swing_btn_Click(object sender, EventArgs e)
        {
            changeSkill("Swing");
        }
        private void shieldAside_btn_Click(object sender, EventArgs e)
        {
            changeSkill("Shield Aside");
        }
        private void shieldBash_btn_Click(object sender, EventArgs e)
        {
            changeSkill("Shield Bash");
        }
        private void guardUp_btn_Click(object sender, EventArgs e)
        {
            changeSkill("Guard Up");
        }
        private void meditation_btn_Click(object sender, EventArgs e)
        {
            changeSkill("Meditation");
        }
        private void fireball_btn_Click(object sender, EventArgs e)
        {
            changeSkill("Fireball");
        }
        private void healPulse_btn_Click(object sender, EventArgs e)
        {
            changeSkill("Heal Pulse");
        }
        private void insideFury_btn_Click(object sender, EventArgs e)
        {
            changeSkill("Inside Fury");
        }
    }
}
