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
    public partial class Loot : Form
    {
        public static int rarityOfLoot = 0;
        public static int lootType = 0;
        Weapons newWeapon;
        Helmets newHelmet;
        Armor newArmor;
        Boots newBoots;

        public Loot()
        {
            InitializeComponent();
            currentItem();
            newItem();
        }

        public void currentItem()
        {
            switch (lootType) 
            {
                case 0:
                    currentItem_pic.BackgroundImage = MainWindow.byteImageConverter(MainWindow.person.weapon.picture);
                    currentItem_label.Text = MainWindow.person.weapon.name;
                    health1.Text = "×" + MainWindow.person.weapon.healthMultiplier.ToString();
                    attack1.Text = "×" + MainWindow.person.weapon.attackMultiplier.ToString();
                    defense1.Text = "×" + MainWindow.person.weapon.defenseMultiplier.ToString();
                    magic1.Text = "×" + MainWindow.person.weapon.magicMultiplier.ToString();
                    break;
                case 1:
                    currentItem_pic.BackgroundImage = MainWindow.byteImageConverter(MainWindow.person.helmet.picture);
                    currentItem_label.Text = MainWindow.person.helmet.name;
                    health1.Text = "×" + MainWindow.person.helmet.healthMultiplier.ToString();
                    attack1.Text = "×" + MainWindow.person.helmet.attackMultiplier.ToString();
                    defense1.Text = "×" + MainWindow.person.helmet.defenseMultiplier.ToString();
                    magic1.Text = "×" + MainWindow.person.helmet.magicMultiplier.ToString();
                    break;
                case 2:
                    currentItem_pic.BackgroundImage = MainWindow.byteImageConverter(MainWindow.person.armor.picture);
                    currentItem_label.Text = MainWindow.person.armor.name;
                    health1.Text = "×" + MainWindow.person.armor.healthMultiplier.ToString();
                    attack1.Text = "×" + MainWindow.person.armor.attackMultiplier.ToString();
                    defense1.Text = "×" + MainWindow.person.armor.defenseMultiplier.ToString();
                    magic1.Text = "×" + MainWindow.person.armor.magicMultiplier.ToString();
                    break;
                case 3:
                    currentItem_pic.BackgroundImage = MainWindow.byteImageConverter(MainWindow.person.boots.picture);
                    currentItem_label.Text = MainWindow.person.boots.name;
                    health1.Text = "×" + MainWindow.person.boots.healthMultiplier.ToString();
                    attack1.Text = "×" + MainWindow.person.boots.attackMultiplier.ToString();
                    defense1.Text = "×" + MainWindow.person.boots.defenseMultiplier.ToString();
                    magic1.Text = "×" + MainWindow.person.boots.magicMultiplier.ToString();
                    break;  
            }
        }
        public void newItem()
        {
            switch (lootType) 
            {
                case 0:
                    newWeapon = new Weapons(rarityOfLoot);
                    newItem_pic.BackgroundImage = MainWindow.byteImageConverter(newWeapon.picture);
                    newItem_label.Text = newWeapon.name;
                    health2.Text = "×" + newWeapon.healthMultiplier.ToString();
                    attack2.Text = "×" + newWeapon.attackMultiplier.ToString();
                    defense2.Text = "×" + newWeapon.defenseMultiplier.ToString();
                    magic2.Text = "×" + newWeapon.magicMultiplier.ToString();
                    break;
                case 1:
                    newHelmet = new Helmets(rarityOfLoot);
                    newItem_pic.BackgroundImage = MainWindow.byteImageConverter(newHelmet.picture);
                    newItem_label.Text = newHelmet.name;
                    health2.Text = "×" + newHelmet.healthMultiplier.ToString();
                    attack2.Text = "×" + newHelmet.attackMultiplier.ToString();
                    defense2.Text = "×" + newHelmet.defenseMultiplier.ToString();
                    magic2.Text = "×" + newHelmet.magicMultiplier.ToString();
                    break;
                case 2:
                    newArmor = new Armor(rarityOfLoot);
                    newItem_pic.BackgroundImage = MainWindow.byteImageConverter(newArmor.picture);
                    newItem_label.Text = newArmor.name;
                    health2.Text = "×" + newArmor.healthMultiplier.ToString();
                    attack2.Text = "×" + newArmor.attackMultiplier.ToString();
                    defense2.Text = "×" + newArmor.defenseMultiplier.ToString();
                    magic2.Text = "×" + newArmor.magicMultiplier.ToString();
                    break;
                case 3:
                    newBoots = new Boots(rarityOfLoot);
                    newItem_pic.BackgroundImage = MainWindow.byteImageConverter(newBoots.picture);
                    newItem_label.Text = newBoots.name;
                    health2.Text = "×" + newBoots.healthMultiplier.ToString();
                    attack2.Text = "×" + newBoots.attackMultiplier.ToString();
                    defense2.Text = "×" + newBoots.defenseMultiplier.ToString();
                    magic2.Text = "×" + newBoots.magicMultiplier.ToString();
                    break;
            }
        }
        public void moneyReward(int rarity)
        {
            MainWindow.person.player.money += (rarity + 1) * 30;
            if (rarity > 1)
                MainWindow.person.player.money += rarity * 80;
        }

        private void btn_current_Click(object sender, EventArgs e)
        {
            moneyReward(rarityOfLoot);
            this.Close();
        }
        private void btn_new_Click(object sender, EventArgs e)
        {
            switch (lootType) 
            {
                case 0:
                    moneyReward(MainWindow.person.weapon.rarity);

                    MainWindow.person.player.health /= MainWindow.person.weapon.healthMultiplier;
                    MainWindow.person.player.health *= newWeapon.healthMultiplier;
                    MainWindow.person.player.attack /= MainWindow.person.weapon.attackMultiplier;
                    MainWindow.person.player.attack *= newWeapon.attackMultiplier;
                    MainWindow.person.player.defense /= MainWindow.person.weapon.defenseMultiplier;
                    MainWindow.person.player.defense *= newWeapon.defenseMultiplier;
                    MainWindow.person.player.magic /= MainWindow.person.weapon.magicMultiplier;
                    MainWindow.person.player.magic *= newWeapon.magicMultiplier;

                    MainWindow.person.weapon = newWeapon;
                    break;
                case 1:
                    moneyReward(MainWindow.person.helmet.rarity);

                    MainWindow.person.player.health /= MainWindow.person.helmet.healthMultiplier;
                    MainWindow.person.player.health *= newHelmet.healthMultiplier;
                    MainWindow.person.player.attack /= MainWindow.person.helmet.attackMultiplier;
                    MainWindow.person.player.attack *= newHelmet.attackMultiplier;
                    MainWindow.person.player.defense /= MainWindow.person.helmet.defenseMultiplier;
                    MainWindow.person.player.defense *= newHelmet.defenseMultiplier;
                    MainWindow.person.player.magic /= MainWindow.person.helmet.magicMultiplier;
                    MainWindow.person.player.magic *= newHelmet.magicMultiplier;

                    MainWindow.person.helmet = newHelmet;
                    break;
                case 2:
                    moneyReward(MainWindow.person.armor.rarity);

                    MainWindow.person.player.health /= MainWindow.person.armor.healthMultiplier;
                    MainWindow.person.player.health *= newArmor.healthMultiplier;
                    MainWindow.person.player.attack /= MainWindow.person.armor.attackMultiplier;
                    MainWindow.person.player.attack *= newArmor.attackMultiplier;
                    MainWindow.person.player.defense /= MainWindow.person.armor.defenseMultiplier;
                    MainWindow.person.player.defense *= newArmor.defenseMultiplier;
                    MainWindow.person.player.magic /= MainWindow.person.armor.magicMultiplier;
                    MainWindow.person.player.magic *= newArmor.magicMultiplier;

                    MainWindow.person.armor = newArmor;
                    break;
                case 3:
                    moneyReward(MainWindow.person.boots.rarity);

                    MainWindow.person.player.health /= MainWindow.person.boots.healthMultiplier;
                    MainWindow.person.player.health *= newBoots.healthMultiplier;
                    MainWindow.person.player.attack /= MainWindow.person.boots.attackMultiplier;
                    MainWindow.person.player.attack *= newBoots.attackMultiplier;
                    MainWindow.person.player.defense /= MainWindow.person.boots.defenseMultiplier;
                    MainWindow.person.player.defense *= newBoots.defenseMultiplier;
                    MainWindow.person.player.magic /= MainWindow.person.boots.magicMultiplier;
                    MainWindow.person.player.magic *= newBoots.magicMultiplier;

                    MainWindow.person.boots = newBoots;
                    break;
            }
            this.Close();
        }

        private void Loot_FormClosed(object sender, FormClosedEventArgs e)
        {
            moneyReward(rarityOfLoot);
        }
    }
}
