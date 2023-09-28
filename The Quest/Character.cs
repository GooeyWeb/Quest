using System;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;

namespace The_Quest
{
    public partial class Character : Form
    {
        static float healthMult, attackMult, defenseMult, magicMult;
        public Character()
        {
            InitializeComponent();
            statsInitialization();
            loadSkills();
        }
        
        public void statsInitialization()
        {
            switch (MainWindow.person.player.classID) //Player Image
            {
                case 1:
                    Player.BackgroundImage = Properties.Resources.warrior;
                    class_label.Text = "Warrior";
                    break;
                case 2:
                    Player.BackgroundImage = Properties.Resources.mage;
                    class_label.Text = "Mage";
                    break;
                case 3:
                    Player.BackgroundImage = Properties.Resources.rogue;
                    class_label.Text = "Rogue";
                    break;
                default:
                    Player.BackgroundImage = Properties.Resources.warrior;
                    class_label.Text = "???";
                    break;
            }

            weapon_label.Text = MainWindow.person.weapon.name;
            helmet_label.Text = MainWindow.person.helmet.name;
            armor_label.Text = MainWindow.person.armor.name;
            boots_label.Text = MainWindow.person.boots.name;

            weapon_pic.BackgroundImage = MainWindow.byteImageConverter(MainWindow.person.weapon.picture);
            helmet_pic.BackgroundImage = MainWindow.byteImageConverter(MainWindow.person.helmet.picture);
            armor_pic.BackgroundImage = MainWindow.byteImageConverter(MainWindow.person.armor.picture);
            boots_pic.BackgroundImage = MainWindow.byteImageConverter(MainWindow.person.boots.picture);

            money.Text = MainWindow.person.player.money.ToString();
            health.Text = ((int)MainWindow.person.player.health).ToString();
            attack.Text = ((int)MainWindow.person.player.attack).ToString();
            defense.Text = ((int)MainWindow.person.player.defense).ToString();
            magic.Text = ((int)MainWindow.person.player.magic).ToString();

            health_cost.Text = MainWindow.person.player.upgCost1.ToString();
            attack_cost.Text = MainWindow.person.player.upgCost2.ToString();
            defense_cost.Text = MainWindow.person.player.upgCost3.ToString();
            magic_cost.Text = MainWindow.person.player.upgCost4.ToString();
        }
        public void loadSkills()
        {
            skill1_label.Text = MainWindow.person.player.skill1;
            skill1_pic.BackgroundImage = getSkillPic(MainWindow.person.player.skill1);

            skill2_label.Text = MainWindow.person.player.skill2;
            skill2_pic.BackgroundImage = getSkillPic(MainWindow.person.player.skill2);

            skill3_label.Text = MainWindow.person.player.skill3;
            skill3_pic.BackgroundImage = getSkillPic(MainWindow.person.player.skill3);
        }
        private void Character_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainWindow.isCharacterOpen = false;
        }
        public Image getSkillPic(string skill)
        {
            switch (skill) 
            {
                case "Direct Attack":
                    return Properties.Resources.attack;
                case "Swing":
                    return Properties.Resources.swing;
                case "Shield Aside":
                    return Properties.Resources.shieldAside;
                case "Shield Bash":
                    return Properties.Resources.shieldBash;
                case "Guard Up":
                    return Properties.Resources.guard;
                case "Meditation":
                    return Properties.Resources.meditation;
                case "Fireball":
                    return Properties.Resources.fireball;
                case "Heal Pulse":
                    return Properties.Resources.heal;
                case "Inside Fury":
                    return Properties.Resources.fury;
                default:
                    return Properties.Resources.attack;
            }
        }
        public void getMultipliers()
        {
            healthMult = MainWindow.person.weapon.healthMultiplier * MainWindow.person.helmet.healthMultiplier * MainWindow.person.armor.healthMultiplier * MainWindow.person.boots.healthMultiplier;
            attackMult = MainWindow.person.weapon.attackMultiplier * MainWindow.person.helmet.attackMultiplier * MainWindow.person.armor.attackMultiplier * MainWindow.person.boots.attackMultiplier;
            defenseMult = MainWindow.person.weapon.defenseMultiplier * MainWindow.person.helmet.defenseMultiplier * MainWindow.person.armor.defenseMultiplier * MainWindow.person.boots.defenseMultiplier;
            magicMult = MainWindow.person.weapon.magicMultiplier * MainWindow.person.helmet.magicMultiplier * MainWindow.person.armor.magicMultiplier * MainWindow.person.boots.magicMultiplier;
        }
        private void goBack_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void upgHealth_btn_Click(object sender, EventArgs e)
        {
            double x;
            if(int.Parse(health_cost.Text) <= MainWindow.person.player.money)
            {
                getMultipliers();
                x = (MainWindow.person.player.health / healthMult);
                if (MainWindow.person.player.upgCost1 < 50)
                    x += 2;
                else if (MainWindow.person.player.upgCost1 < 125)
                    x += 4;
                else if (MainWindow.person.player.upgCost1 < 250)
                    x += 8;
                else if (MainWindow.person.player.upgCost1 < 375)
                    x += 12;
                else if (MainWindow.person.player.upgCost1 < 500)
                    x += 16;
                else
                    x += 20;
                MainWindow.person.player.health = (x*healthMult);
                MainWindow.person.player.money -= MainWindow.person.player.upgCost1;
                MainWindow.person.player.upgCost1 += 5;

                money.Text = MainWindow.person.player.money.ToString();
                health_cost.Text = MainWindow.person.player.upgCost1.ToString();
                health.Text = ((int)MainWindow.person.player.health).ToString();
            }
        }

        private void upgAttack_btn_Click(object sender, EventArgs e)
        {
            double x;
            if (int.Parse(attack_cost.Text) <= MainWindow.person.player.money)
            {
                getMultipliers();
                x = (MainWindow.person.player.attack / attackMult);
                if (MainWindow.person.player.upgCost2 < 50)
                    x += 1;
                else if (MainWindow.person.player.upgCost2 < 125)
                    x += 2;
                else if (MainWindow.person.player.upgCost2 < 250)
                    x += 4;
                else if (MainWindow.person.player.upgCost2 < 375)
                    x += 6;
                else if (MainWindow.person.player.upgCost2 < 500)
                    x += 8;
                else
                    x += 10;
                MainWindow.person.player.attack = (x * attackMult);
                MainWindow.person.player.money -= MainWindow.person.player.upgCost2;
                MainWindow.person.player.upgCost2 += 5;

                money.Text = MainWindow.person.player.money.ToString();
                attack_cost.Text = MainWindow.person.player.upgCost2.ToString();
                attack.Text = ((int)MainWindow.person.player.attack).ToString();
            }
        }
        private void upgDefense_btn_Click(object sender, EventArgs e)
        {
            double x;
            if (int.Parse(defense_cost.Text) <= MainWindow.person.player.money)
            {
                getMultipliers();
                x = (MainWindow.person.player.defense / defenseMult);
                if (MainWindow.person.player.upgCost3 < 50)
                    x += 1;
                else if (MainWindow.person.player.upgCost3 < 125)
                    x += 2;
                else if (MainWindow.person.player.upgCost3 < 250)
                    x += 4;
                else if (MainWindow.person.player.upgCost3 < 375)
                    x += 6;
                else if (MainWindow.person.player.upgCost3 < 500)
                    x += 8;
                else
                    x += 10;
                MainWindow.person.player.defense = (x * defenseMult);
                MainWindow.person.player.money -= MainWindow.person.player.upgCost3;
                MainWindow.person.player.upgCost3 += 5;

                money.Text = MainWindow.person.player.money.ToString();
                defense_cost.Text = MainWindow.person.player.upgCost3.ToString();
                defense.Text = ((int)MainWindow.person.player.defense).ToString();
            }
        }
        private void upgMagic_btn_Click(object sender, EventArgs e)
        {
            double x;
            if (int.Parse(magic_cost.Text) <= MainWindow.person.player.money)
            {
                getMultipliers();
                x = (MainWindow.person.player.magic / magicMult);
                if (MainWindow.person.player.upgCost4 < 50)
                    x += 1;
                else if (MainWindow.person.player.upgCost4 < 125)
                    x += 2;
                else if (MainWindow.person.player.upgCost4 < 250)
                    x += 4;
                else if (MainWindow.person.player.upgCost4 < 375)
                    x += 6;
                else if (MainWindow.person.player.upgCost4 < 500)
                    x += 8;
                else
                    x += 10;
                MainWindow.person.player.magic = (x * magicMult);
                MainWindow.person.player.money -= MainWindow.person.player.upgCost4;
                MainWindow.person.player.upgCost4 += 5;

                money.Text = MainWindow.person.player.money.ToString();
                magic_cost.Text = MainWindow.person.player.upgCost4.ToString();
                magic.Text = ((int)MainWindow.person.player.magic).ToString();
            }
        }
    }
}
