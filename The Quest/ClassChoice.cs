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
    public partial class Classes : Form
    {
        public Classes()
        {
            InitializeComponent();
        }
        void CreatePlayer(int classID)
        {
            MainWindow.person = new Person(classID);
            MainWindow.characterExist = true;
            this.Close();
        }
        private void warrior_pic_Click(object sender, EventArgs e)
        {
            CreatePlayer(1);
        }

        private void mage_pic_Click(object sender, EventArgs e)
        {
            CreatePlayer(2);
        }

        private void rogue_pic_Click(object sender, EventArgs e)
        {
            CreatePlayer(3);
        }

        private void Classes_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(!MainWindow.characterExist)
                Application.Exit();
        }
    }
}
