using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Quest
{
    public class Weapons
    {
        public int weaponID { get; set; }
        public int rarity { get; set; }
        public string name { get; set; }
        public float healthMultiplier { get; set; }
        public float attackMultiplier { get; set; }
        public float defenseMultiplier { get; set; }
        public float magicMultiplier { get; set; }
        public byte[] picture { get; set; }

        public Weapons()
        {
            weaponID = 0;
            rarity = 0;
            name = "Weapon";
            healthMultiplier = 1;
            attackMultiplier = 1;
            defenseMultiplier = 1;
            magicMultiplier = 1;
            picture = MainWindow.imageByteConverter(Properties.Resources.sword);
        }

        public Weapons(int weaponRarity)
        {
            Random rng = new Random();
            switch (MainWindow.person.player.classID)
            {
                case 1: //Warrior
                    switch (weaponRarity)
                    {
                        case 0:
                            weaponID = -1;
                            rarity = -1;
                            name = "Old Sword";
                            healthMultiplier = 1;
                            attackMultiplier = 1;
                            defenseMultiplier = 1;
                            magicMultiplier = 1;
                            picture = MainWindow.imageByteConverter(Properties.Resources.sword);
                            break;
                        case 1:
                            weaponID = 0;
                            rarity = 0;
                            name = "Hammer";
                            healthMultiplier = (float)rng.Next(12, 14) / 10;
                            attackMultiplier = (float)rng.Next(12, 15) / 10;
                            defenseMultiplier = (float)rng.Next(12, 13) / 10;
                            magicMultiplier = (float)rng.Next(8, 10) / 10;
                            picture = MainWindow.imageByteConverter(Properties.Resources.hammer);
                            break;
                        case 2:
                            weaponID = 1;
                            rarity = 1;
                            name = "Halberd";
                            healthMultiplier = (float)rng.Next(15, 20) / 10;
                            attackMultiplier = (float)rng.Next(17, 25) / 10;
                            defenseMultiplier = (float)rng.Next(14, 18) / 10;
                            magicMultiplier = (float)rng.Next(20, 30) / 10;
                            picture = MainWindow.imageByteConverter(Properties.Resources.halberd);
                            break;
                        case 3:
                            weaponID = 2;
                            rarity = 2;
                            name = "Battle Axe";
                            healthMultiplier = (float)rng.Next(22, 30) / 10;
                            attackMultiplier = (float)rng.Next(27, 35) / 10;
                            defenseMultiplier = (float)rng.Next(20, 25) / 10;
                            magicMultiplier = (float)rng.Next(10, 15) / 10;
                            picture = MainWindow.imageByteConverter(Properties.Resources.battleaxe);
                            break;
                        case 4:
                            weaponID = 3;
                            rarity = 3;
                            name = "Double Greatsword";
                            healthMultiplier = (float)rng.Next(32, 42) / 10;
                            attackMultiplier = (float)rng.Next(38, 45) / 10;
                            defenseMultiplier = (float)rng.Next(25, 30) / 10;
                            magicMultiplier = (float)rng.Next(28, 33) / 10;
                            picture = MainWindow.imageByteConverter(Properties.Resources.doubleGreatsword);
                            break;
                    }
                    break;
                case 2: //Mage
                    switch (weaponRarity)
                    {
                        case 0:
                            weaponID = -1;
                            rarity = -1;
                            name = "Old Staff";
                            healthMultiplier = 1;
                            attackMultiplier = 1;
                            defenseMultiplier = 1;
                            magicMultiplier = 1;
                            picture = MainWindow.imageByteConverter(Properties.Resources.oldStaff);
                            break;
                        case 1:
                            weaponID = 0;
                            rarity = 0;
                            name = "Wooden Wand";
                            healthMultiplier = (float)rng.Next(9, 10) / 10;
                            attackMultiplier = (float)rng.Next(7, 8) / 10;
                            defenseMultiplier = (float)rng.Next(11, 12) / 10;
                            magicMultiplier = (float)rng.Next(13, 15) / 10;
                            picture = MainWindow.imageByteConverter(Properties.Resources.woodenWand);
                            break;
                        case 2:
                            weaponID = 1;
                            rarity = 1;
                            name = "Royal Staff";
                            healthMultiplier = (float)rng.Next(15, 17) / 10;
                            attackMultiplier = (float)rng.Next(13, 15) / 10;
                            defenseMultiplier = (float)rng.Next(15, 20) / 10;
                            magicMultiplier = (float)rng.Next(20, 28) / 10;
                            picture = MainWindow.imageByteConverter(Properties.Resources.royalStaff);
                            break;
                        case 3:
                            weaponID = 2;
                            rarity = 2;
                            name = "Rose Wand";
                            healthMultiplier = (float)rng.Next(20, 25) / 10;
                            attackMultiplier = (float)rng.Next(10, 12) / 10;
                            defenseMultiplier = (float)rng.Next(17, 22) / 10;
                            magicMultiplier = (float)rng.Next(30, 35) / 10;
                            picture = MainWindow.imageByteConverter(Properties.Resources.roseWand);
                            break;
                        case 4:
                            weaponID = 3;
                            rarity = 3;
                            name = "Magical Orb";
                            healthMultiplier = (float)rng.Next(30, 35) / 10;
                            attackMultiplier = (float)rng.Next(20, 25) / 10;
                            defenseMultiplier = (float)rng.Next(20, 30) / 10;
                            magicMultiplier = (float)rng.Next(40, 50) / 10;
                            picture = MainWindow.imageByteConverter(Properties.Resources.orb);
                            break;
                    }
                    break;
                case 3: //Rogue
                    switch (weaponRarity)
                    {
                        case 0:
                            weaponID = -1;
                            rarity = -1;
                            name = "Old Dagger";
                            healthMultiplier = 1;
                            attackMultiplier = 1;
                            defenseMultiplier = 1;
                            magicMultiplier = 1;
                            picture = MainWindow.imageByteConverter(Properties.Resources.dagger);
                            break;
                        case 1:
                            weaponID = 0;
                            rarity = 0;
                            name = "Claws";
                            healthMultiplier = (float)rng.Next(10, 11) / 10;
                            attackMultiplier = (float)rng.Next(13, 16) / 10;
                            defenseMultiplier = (float)rng.Next(10, 11) / 10;
                            magicMultiplier = (float)rng.Next(11, 13) / 10;
                            picture = MainWindow.imageByteConverter(Properties.Resources.claws);
                            break;
                        case 2:
                            weaponID = 1;
                            rarity = 1;
                            name = "Sickle";
                            healthMultiplier = (float)rng.Next(11, 13) / 10;
                            attackMultiplier = (float)rng.Next(18, 23) / 10;
                            defenseMultiplier = (float)rng.Next(12, 15) / 10;
                            magicMultiplier = (float)rng.Next(13, 15) / 10;
                            picture = MainWindow.imageByteConverter(Properties.Resources.sickle);
                            break;
                        case 3:
                            weaponID = 2;
                            rarity = 2;
                            name = "Hidden Blade";
                            healthMultiplier = (float)rng.Next(15, 20) / 10;
                            attackMultiplier = (float)rng.Next(25, 33) / 10;
                            defenseMultiplier = (float)rng.Next(20, 27) / 10;
                            magicMultiplier = (float)rng.Next(20, 30) / 10;
                            picture = MainWindow.imageByteConverter(Properties.Resources.hiddenBlade);
                            break;
                        case 4:
                            weaponID = 3;
                            rarity = 3;
                            name = "Dual Daggers";
                            healthMultiplier = (float)rng.Next(20, 25) / 10;
                            attackMultiplier = (float)rng.Next(35, 45) / 10;
                            defenseMultiplier = (float)rng.Next(25, 35) / 10;
                            magicMultiplier = (float)rng.Next(35, 45) / 10;
                            picture = MainWindow.imageByteConverter(Properties.Resources.dualDaggers);
                            break;
                    }
                    break;
            }
        }

        public Weapons(int weaponRarity, int classID)
        {
            switch(classID) 
            {
                case 1:
                    weaponID = -1;
                    rarity = -1;
                    name = "Old Sword";
                    healthMultiplier = 1;
                    attackMultiplier = 1;
                    defenseMultiplier = 1;
                    magicMultiplier = 1;
                    picture = MainWindow.imageByteConverter(Properties.Resources.sword);
                    break;
                case 2:
                    weaponID = -1;
                    rarity = -1;
                    name = "Old Staff";
                    healthMultiplier = 1;
                    attackMultiplier = 1;
                    defenseMultiplier = 1;
                    magicMultiplier = 1;
                    picture = MainWindow.imageByteConverter(Properties.Resources.oldStaff);
                    break;
                case 3:
                    weaponID = -1;
                    rarity = -1;
                    name = "Old Dagger";
                    healthMultiplier = 1;
                    attackMultiplier = 1;
                    defenseMultiplier = 1;
                    magicMultiplier = 1;
                    picture = MainWindow.imageByteConverter(Properties.Resources.dagger);
                    break;
            }
        }
    }
}
