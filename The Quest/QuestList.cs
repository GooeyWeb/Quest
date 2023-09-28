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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace The_Quest
{
    public partial class QuestList : Form
    {
        public static int[] quests = new int[MainWindow.tasks.Count()+1];
        Quests task;
        public QuestList()
        {
            InitializeComponent();
            getQuests();
            noQuestChosen();
            quest_list.SelectedItem = -1;
        }

        public void getQuests()
        {
            int i = 0;
            foreach (Quests x in MainWindow.tasks)
            {
                quest_list.Items.Add(x.title);
                quests[i] = x.questID;
                i++;
            }
        }
        public void noQuestChosen()
        {
            description_label.Text = "No quest chosen";
            title_label.Hide();
            diff_pic.Hide();
            claim_btn.Hide();
            questBG_pic.Hide();
            gold_label.Hide();
            gold_pic.Hide();
        }
        private void QuestList_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainWindow.isListOpen = false;
        }

        private void quest_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = 0;

            if(quest_list.SelectedIndex != -1)
            {
                title_label.Show();
                diff_pic.Show();
                claim_btn.Show();
                questBG_pic.Show();
                gold_label.Show();
                gold_pic.Show();
            }

            foreach (Quests x in MainWindow.tasks)
            {
                if (quest_list.SelectedIndex != -1 && quests[quest_list.SelectedIndex] == x.questID)
                {

                    gold_label.Text = x.coins.ToString();
                    title_label.Text = x.title;
                    description_label.Text = x.description;
                    switch (x.difficulty)
                    {
                        case 1:
                            diff_pic.BackgroundImage = Properties.Resources.easy;
                            break;
                        case 2:
                            diff_pic.BackgroundImage = Properties.Resources.medium;
                            break;
                        case 3:
                            diff_pic.BackgroundImage = Properties.Resources.hard;
                            break;
                        case 4:
                            diff_pic.BackgroundImage = Properties.Resources.legendary;
                            break;
                    }
                    task = x;
                    break;
                }
                i++;
            }
        }

        private void claim_btn_Click(object sender, EventArgs e)
        {
            quest_list.SelectedItem = -1;
            MainWindow.person.player.money += task.coins;
            if (task.loot)
                MainWindow.claimLoot(task.difficulty);
            MainWindow.tasks.Remove(task);
            quest_list.Items.Clear();

            getQuests();
            noQuestChosen();
        }
    }
}
