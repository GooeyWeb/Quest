using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace The_Quest
{
    public partial class QuestMaker : Form
    {
        public QuestMaker()
        {
            InitializeComponent();
        }

        private void QuestMaker_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainWindow.isGuildOpen = false;
        }

        private void submit_Click(object sender, EventArgs e)
        {
            if (title.Text != "" && description.Text != "")
            {
                int diff = 1;
                error_label.Hide();
                if (diff_easy.Checked == true)
                    diff = diff_easy.TabIndex;
                else if (diff_normal.Checked == true)
                    diff = diff_normal.TabIndex;
                else if (diff_hard.Checked == true)
                    diff = diff_hard.TabIndex;
                else if (diff_legendary.Checked == true)
                    diff = diff_legendary.TabIndex;

                MainWindow.tasks.Add(new Quests(title.Text, description.Text, diff));

                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Quests>));
                using (FileStream fileStream = new FileStream("tasks.xml",FileMode.Create))
                {
                    xmlSerializer.Serialize(fileStream, MainWindow.tasks);
                }
                
                MainWindow.person.player.questsQuantity++;
                this.Close();
            }
            else
                error_label.Show();
        }
    }
}
