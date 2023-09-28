using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace The_Quest
{
    public class Armor
    {
        public int armorID { get; set; }
        public int rarity { get; set; }
        public string name { get; set; }
        public float healthMultiplier { get; set; }
        public float attackMultiplier { get; set; }
        public float defenseMultiplier { get; set; }
        public float magicMultiplier { get; set; }
        public byte[] picture { get; set; }

        public Armor()
        {
            armorID = 0;
            rarity = 0;
            name = "Armor";
            healthMultiplier = 1;
            attackMultiplier = 1;
            defenseMultiplier = 1;
            magicMultiplier = 1;
            picture = MainWindow.imageByteConverter(Properties.Resources.rustyArmor);
        }

        public Armor(int armorRarity)
        {
            Random rng = new Random();
            switch (MainWindow.person.player.classID)
            {
                case 1: //Warrior
                    switch (armorRarity)
                    {
                        case 0:
                            armorID = -1;
                            rarity = -1;
                            name = "Rusty Armor";
                            healthMultiplier = 1;
                            attackMultiplier = 1;
                            defenseMultiplier = 1;
                            magicMultiplier = 1;
                            picture = MainWindow.imageByteConverter(Properties.Resources.rustyArmor);
                            break;
                        case 1:
                            armorID = 0;
                            rarity = 0;
                            name = "Plate Armor";
                            healthMultiplier = (float)rng.Next(12, 14) / 10;
                            attackMultiplier = (float)rng.Next(10, 11) / 10;
                            defenseMultiplier = (float)rng.Next(15, 17) / 10;
                            magicMultiplier = (float)rng.Next(10, 10) / 10;
                            picture = MainWindow.imageByteConverter(Properties.Resources.plateArmor);
                            break;
                        case 2:
                            armorID = 1;
                            rarity = 1;
                            name = "Chainmail";
                            healthMultiplier = (float)rng.Next(15, 19) / 10;
                            attackMultiplier = (float)rng.Next(12, 13) / 10;
                            defenseMultiplier = (float)rng.Next(16, 20) / 10;
                            magicMultiplier = (float)rng.Next(10, 11) / 10;
                            picture = MainWindow.imageByteConverter(Properties.Resources.chainmail);
                            break;
                        case 3:
                            armorID = 2;
                            rarity = 2;
                            name = "Light Armor";
                            healthMultiplier = (float)rng.Next(13, 17) / 10;
                            attackMultiplier = (float)rng.Next(18, 25) / 10;
                            defenseMultiplier = (float)rng.Next(13, 17) / 10;
                            magicMultiplier = (float)rng.Next(13, 17) / 10;
                            picture = MainWindow.imageByteConverter(Properties.Resources.lightArmor);
                            break;
                        case 4:
                            armorID = 3;
                            rarity = 3;
                            name = "Achilles' Chestplate";
                            healthMultiplier = (float)rng.Next(20, 23) / 10;
                            attackMultiplier = (float)rng.Next(20, 28) / 10;
                            defenseMultiplier = (float)rng.Next(25, 30) / 10;
                            magicMultiplier = (float)rng.Next(20, 23) / 10;
                            picture = MainWindow.imageByteConverter(Properties.Resources.achillesChestplate);
                            break;
                    }
                    break;
                case 2: //Mage
                    switch (armorRarity)
                    {
                        case 0:
                            armorID = -1;
                            rarity = -1;
                            name = "Old Cape";
                            healthMultiplier = 1;
                            attackMultiplier = 1;
                            defenseMultiplier = 1;
                            magicMultiplier = 1;
                            picture = MainWindow.imageByteConverter(Properties.Resources.oldCape);
                            break;
                        case 1:
                            armorID = 0;
                            rarity = 0;
                            name = "Practitioner Cloak";
                            healthMultiplier = (float)rng.Next(10, 11) / 10;
                            attackMultiplier = (float)rng.Next(10, 11) / 10;
                            defenseMultiplier = (float)rng.Next(10, 11) / 10;
                            magicMultiplier = (float)rng.Next(12, 16) / 10;
                            picture = MainWindow.imageByteConverter(Properties.Resources.practitionerCloak);
                            break;
                        case 2:
                            armorID = 1;
                            rarity = 1;
                            name = "Reinforced Cloak";
                            healthMultiplier = (float)rng.Next(12, 15) / 10;
                            attackMultiplier = (float)rng.Next(12, 15) / 10;
                            defenseMultiplier = (float)rng.Next(15, 20) / 10;
                            magicMultiplier = (float)rng.Next(15, 17) / 10;
                            picture = MainWindow.imageByteConverter(Properties.Resources.reinforcedCloak);
                            break;
                        case 3:
                            armorID = 2;
                            rarity = 2;
                            name = "Archmage Cloak";
                            healthMultiplier = (float)rng.Next(13, 16) / 10;
                            attackMultiplier = (float)rng.Next(10, 12) / 10;
                            defenseMultiplier = (float)rng.Next(13, 16) / 10;
                            magicMultiplier = (float)rng.Next(20, 23) / 10;
                            picture = MainWindow.imageByteConverter(Properties.Resources.archmageCloak);
                            break;
                        case 4:
                            armorID = 3;
                            rarity = 3;
                            name = "Tarnkappe";
                            healthMultiplier = (float)rng.Next(15, 17) / 10;
                            attackMultiplier = (float)rng.Next(20, 25) / 10;
                            defenseMultiplier = (float)rng.Next(7, 10) / 10;
                            magicMultiplier = (float)rng.Next(25, 30) / 10;
                            picture = MainWindow.imageByteConverter(Properties.Resources.tarnkappe);
                            break;
                    }
                    break;
                case 3: //Rogue
                    switch (armorRarity)
                    {
                        case 0:
                            armorID = -1;
                            rarity = -1;
                            name = "Old Cape";
                            healthMultiplier = 1;
                            attackMultiplier = 1;
                            defenseMultiplier = 1;
                            magicMultiplier = 1;
                            picture = MainWindow.imageByteConverter(Properties.Resources.oldCape);
                            break;
                        case 1:
                            armorID = 0;
                            rarity = 0;
                            name = "Leather Cape";
                            healthMultiplier = (float)rng.Next(10, 11) / 10;
                            attackMultiplier = (float)rng.Next(12, 14) / 10;
                            defenseMultiplier = (float)rng.Next(10, 11) / 10;
                            magicMultiplier = (float)rng.Next(11, 13) / 10;
                            picture = MainWindow.imageByteConverter(Properties.Resources.leatherCape);
                            break;
                        case 2:
                            armorID = 1;
                            rarity = 1;
                            name = "Long Mantle";
                            healthMultiplier = (float)rng.Next(13, 15) / 10;
                            attackMultiplier = (float)rng.Next(13, 18) / 10;
                            defenseMultiplier = (float)rng.Next(13, 15) / 10;
                            magicMultiplier = (float)rng.Next(12, 16) / 10;
                            picture = MainWindow.imageByteConverter(Properties.Resources.longMantle);
                            break;
                        case 3:
                            armorID = 2;
                            rarity = 2;
                            name = "Dark Cloak";
                            healthMultiplier = (float)rng.Next(13, 18) / 10;
                            attackMultiplier = (float)rng.Next(15, 20) / 10;
                            defenseMultiplier = (float)rng.Next(11, 13) / 10;
                            magicMultiplier = (float)rng.Next(15, 20) / 10;
                            picture = MainWindow.imageByteConverter(Properties.Resources.darkCloak);
                            break;
                        case 4:
                            armorID = 3;
                            rarity = 3;
                            name = "Tarnkappe";
                            healthMultiplier = (float)rng.Next(15, 18) / 10;
                            attackMultiplier = (float)rng.Next(22, 30) / 10;
                            defenseMultiplier = (float)rng.Next(6, 10) / 10;
                            magicMultiplier = (float)rng.Next(22, 30) / 10;
                            picture = MainWindow.imageByteConverter(Properties.Resources.tarnkappe);
                            break;
                    }
                    break;
            }
        }

        public Armor(int armorRarity, int classID)
        {
            switch (classID)
            {
                case 1:
                    armorID = -1;
                    rarity = -1;
                    name = "Armor";
                    healthMultiplier = 1;
                    attackMultiplier = 1;
                    defenseMultiplier = 1;
                    magicMultiplier = 1;
                    picture = MainWindow.imageByteConverter(Properties.Resources.rustyArmor);
                    break;
                case 2:
                    armorID = -1;
                    rarity = -1;
                    name = "Armor";
                    healthMultiplier = 1;
                    attackMultiplier = 1;
                    defenseMultiplier = 1;
                    magicMultiplier = 1;
                    picture = MainWindow.imageByteConverter(Properties.Resources.oldCape);
                    break;
                case 3:
                    armorID = -1;
                    rarity = -1;
                    name = "Armor";
                    healthMultiplier = 1;
                    attackMultiplier = 1;
                    defenseMultiplier = 1;
                    magicMultiplier = 1;
                    picture = MainWindow.imageByteConverter(Properties.Resources.oldCape);
                    break;
            }
        }
    }
}
