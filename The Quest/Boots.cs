using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Quest
{
    public class Boots
    {
        public int bootsID { get; set; }
        public int rarity { get; set; }
        public string name { get; set; }
        public float healthMultiplier { get; set; }
        public float attackMultiplier { get; set; }
        public float defenseMultiplier { get; set; }
        public float magicMultiplier { get; set; }
        public byte[] picture { get; set; }

        public Boots()
        {
            bootsID = 0;
            rarity = 0;
            name = "Boots";
            healthMultiplier = 1;
            attackMultiplier = 1;
            defenseMultiplier = 1;
            magicMultiplier = 1;
            picture = MainWindow.imageByteConverter(Properties.Resources.scrappyShoes);
        }
        
        public Boots(int bootsRarity)
        {
            Random rng = new Random();
            switch (MainWindow.person.player.classID)
            {
                case 1: //Warrior
                    switch (bootsRarity)
                    {
                        case 0:
                            bootsID = -1;
                            rarity = -1;
                            name = "Scrappy Shoes";
                            healthMultiplier = 1;
                            attackMultiplier = 1;
                            defenseMultiplier = 1;
                            magicMultiplier = 1;
                            picture = MainWindow.imageByteConverter(Properties.Resources.scrappyShoes);
                            break;
                        case 1:
                            bootsID = 0;
                            rarity = 0;
                            name = "Leather Shoes";
                            healthMultiplier = (float)rng.Next(11, 12) / 10;
                            attackMultiplier = (float)rng.Next(11, 12) / 10;
                            defenseMultiplier = (float)rng.Next(12, 13) / 10;
                            magicMultiplier = (float)rng.Next(10, 11) / 10;
                            picture = MainWindow.imageByteConverter(Properties.Resources.leatherShoes);
                            break;
                        case 2:
                            bootsID = 1;
                            rarity = 1;
                            name = "Sabaton";
                            healthMultiplier = (float)rng.Next(15, 18) / 10;
                            attackMultiplier = (float)rng.Next(10, 10) / 10;
                            defenseMultiplier = (float)rng.Next(16, 20) / 10;
                            magicMultiplier = (float)rng.Next(10, 10) / 10;
                            picture = MainWindow.imageByteConverter(Properties.Resources.sabaton);
                            break;
                        case 3:
                            bootsID = 2;
                            rarity = 2;
                            name = "Light Shoes";
                            healthMultiplier = (float)rng.Next(11, 12) / 10;
                            attackMultiplier = (float)rng.Next(18, 21) / 10;
                            defenseMultiplier = (float)rng.Next(11, 12) / 10;
                            magicMultiplier = (float)rng.Next(16, 18) / 10;
                            picture = MainWindow.imageByteConverter(Properties.Resources.lightShoes);
                            break;
                        case 4:
                            bootsID = 3;
                            rarity = 3;
                            name = "Seven-league Boots";
                            healthMultiplier = (float)rng.Next(31, 40) / 10;
                            attackMultiplier = (float)rng.Next(11, 12) / 10;
                            defenseMultiplier = (float)rng.Next(20, 23) / 10;
                            magicMultiplier = (float)rng.Next(3, 5) / 10;
                            picture = MainWindow.imageByteConverter(Properties.Resources.sevenBoots);
                            break;
                    }
                    break;
                case 2: //Mage
                    switch (bootsRarity)
                    {
                        case 0:
                            bootsID = -1;
                            rarity = -1;
                            name = "Scrappy Shoes";
                            healthMultiplier = 1;
                            attackMultiplier = 1;
                            defenseMultiplier = 1;
                            magicMultiplier = 1;
                            picture = MainWindow.imageByteConverter(Properties.Resources.scrappyShoes);
                            break;
                        case 1:
                            bootsID = 0;
                            rarity = 0;
                            name = "Leather Shoes";
                            healthMultiplier = (float)rng.Next(11, 12) / 10;
                            attackMultiplier = (float)rng.Next(10, 11) / 10;
                            defenseMultiplier = (float)rng.Next(12, 13) / 10;
                            magicMultiplier = (float)rng.Next(11, 12) / 10;
                            picture = MainWindow.imageByteConverter(Properties.Resources.leatherShoes);
                            break;
                        case 2:
                            bootsID = 1;
                            rarity = 1;
                            name = "Sabaton";
                            healthMultiplier = (float)rng.Next(14, 17) / 10;
                            attackMultiplier = (float)rng.Next(10, 10) / 10;
                            defenseMultiplier = (float)rng.Next(16, 19) / 10;
                            magicMultiplier = (float)rng.Next(10, 10) / 10;
                            picture = MainWindow.imageByteConverter(Properties.Resources.sabaton);
                            break;
                        case 3:
                            bootsID = 2;
                            rarity = 2;
                            name = "Archmage Sandals";
                            healthMultiplier = (float)rng.Next(7, 9) / 10;
                            attackMultiplier = (float)rng.Next(13, 17) / 10;
                            defenseMultiplier = (float)rng.Next(12, 14) / 10;
                            magicMultiplier = (float)rng.Next(20, 23) / 10;
                            picture = MainWindow.imageByteConverter(Properties.Resources.archmageSandals);
                            break;
                        case 4:
                            bootsID = 3;
                            rarity = 3;
                            name = "Cloud-stepping Shoes";
                            healthMultiplier = (float)rng.Next(20, 22) / 10;
                            attackMultiplier = (float)rng.Next(12, 15) / 10;
                            defenseMultiplier = (float)rng.Next(15, 19) / 10;
                            magicMultiplier = (float)rng.Next(25, 28) / 10;
                            picture = MainWindow.imageByteConverter(Properties.Resources.cloudShoes);
                            break;
                    }
                    break;
                case 3: //Rogue
                    switch (bootsRarity)
                    {
                        case 0:
                            bootsID = -1;
                            rarity = -1;
                            name = "Scrappy Shoes";
                            healthMultiplier = 1;
                            attackMultiplier = 1;
                            defenseMultiplier = 1;
                            magicMultiplier = 1;
                            picture = MainWindow.imageByteConverter(Properties.Resources.scrappyShoes);
                            break;
                        case 1:
                            bootsID = 0;
                            rarity = 0;
                            name = "Leather Shoes";
                            healthMultiplier = (float)rng.Next(11, 12) / 10;
                            attackMultiplier = (float)rng.Next(11, 12) / 10;
                            defenseMultiplier = (float)rng.Next(11, 12) / 10;
                            magicMultiplier = (float)rng.Next(11, 12) / 10;
                            picture = MainWindow.imageByteConverter(Properties.Resources.leatherShoes);
                            break;
                        case 2:
                            bootsID = 1;
                            rarity = 1;
                            name = "Wooden Sandals";
                            healthMultiplier = (float)rng.Next(13, 15) / 10;
                            attackMultiplier = (float)rng.Next(11, 12) / 10;
                            defenseMultiplier = (float)rng.Next(12, 14) / 10;
                            magicMultiplier = (float)rng.Next(13, 14) / 10;
                            picture = MainWindow.imageByteConverter(Properties.Resources.woodenSandals);
                            break;
                        case 3:
                            bootsID = 2;
                            rarity = 2;
                            name = "Light Shoes";
                            healthMultiplier = (float)rng.Next(11, 12) / 10;
                            attackMultiplier = (float)rng.Next(18, 21) / 10;
                            defenseMultiplier = (float)rng.Next(11, 12) / 10;
                            magicMultiplier = (float)rng.Next(16, 18) / 10;
                            picture = MainWindow.imageByteConverter(Properties.Resources.lightShoes);
                            break;
                        case 4:
                            bootsID = 3;
                            rarity = 3;
                            name = "Talaria";
                            healthMultiplier = (float)rng.Next(15, 20) / 10;
                            attackMultiplier = (float)rng.Next(21, 24) / 10;
                            defenseMultiplier = (float)rng.Next(15, 20) / 10;
                            magicMultiplier = (float)rng.Next(21, 24) / 10;
                            picture = MainWindow.imageByteConverter(Properties.Resources.talaria);
                            break;
                    }
                    break;
            }
        }

        public Boots(int bootsRarity, int classID)
        {
            bootsID = -1;
            rarity = -1;
            name = "Boots";
            healthMultiplier = 1;
            attackMultiplier = 1;
            defenseMultiplier = 1;
            magicMultiplier = 1;
            picture = MainWindow.imageByteConverter(Properties.Resources.scrappyShoes);
        }
    }
}
