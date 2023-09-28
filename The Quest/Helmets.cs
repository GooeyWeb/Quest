using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Quest
{
    public class Helmets
    {
        public int helmetID { get; set; }
        public int rarity { get; set; }
        public string name { get; set; }
        public float healthMultiplier { get; set; }
        public float attackMultiplier { get; set; }
        public float defenseMultiplier { get; set; }
        public float magicMultiplier { get; set; }
        public byte[] picture { get; set; }

        public Helmets()
        {
            helmetID = 0;
            rarity = 0;
            name = "Helmet";
            healthMultiplier = 1;
            attackMultiplier = 1;
            defenseMultiplier = 1;
            magicMultiplier = 1;
            picture = MainWindow.imageByteConverter(Properties.Resources.leatherCap);
        }

        public Helmets(int helmetRarity)
        {
            Random rng = new Random();
            switch (MainWindow.person.player.classID)
            {
                case 1: //Warrior
                    switch (helmetRarity)
                    {
                        case 0:
                            helmetID = -1;
                            rarity = -1;
                            name = "Leather Cap";
                            healthMultiplier = 1;
                            attackMultiplier = 1;
                            defenseMultiplier = 1;
                            magicMultiplier = 1;
                            picture = MainWindow.imageByteConverter(Properties.Resources.leatherCap);
                            break;
                        case 1:
                            helmetID = 0;
                            rarity = 0;
                            name = "Nasal Helmet";
                            healthMultiplier = (float)rng.Next(11, 14) / 10;
                            attackMultiplier = (float)rng.Next(11, 13) / 10;
                            defenseMultiplier = (float)rng.Next(13, 16) / 10;
                            magicMultiplier = (float)rng.Next(10, 10) / 10;
                            picture = MainWindow.imageByteConverter(Properties.Resources.nasalHelmet);
                            break;
                        case 2:
                            helmetID = 1;
                            rarity = 1;
                            name = "Mail Coif";
                            healthMultiplier = (float)rng.Next(14, 17) / 10;
                            attackMultiplier = (float)rng.Next(14, 17) / 10;
                            defenseMultiplier = (float)rng.Next(15, 20) / 10;
                            magicMultiplier = (float)rng.Next(11, 14) / 10;
                            picture = MainWindow.imageByteConverter(Properties.Resources.mailCoif);
                            break;
                        case 3:
                            helmetID = 2;
                            rarity = 2;
                            name = "Broe Helmet";
                            healthMultiplier = (float)rng.Next(13, 15) / 10;
                            attackMultiplier = (float)rng.Next(20, 23) / 10;
                            defenseMultiplier = (float)rng.Next(14, 17) / 10;
                            magicMultiplier = (float)rng.Next(12, 13) / 10;
                            picture = MainWindow.imageByteConverter(Properties.Resources.broeHelmet);
                            break;
                        case 4:
                            helmetID = 3;
                            rarity = 3;
                            name = "Helm of Hades";
                            healthMultiplier = (float)rng.Next(20, 25) / 10;
                            attackMultiplier = (float)rng.Next(20, 25) / 10;
                            defenseMultiplier = (float)rng.Next(25, 30) / 10;
                            magicMultiplier = (float)rng.Next(15, 20) / 10;
                            picture = MainWindow.imageByteConverter(Properties.Resources.helmHades);
                            break;
                    }
                    break;
                case 2: //Mage
                    switch (helmetRarity)
                    {
                        case 0:
                            helmetID = -1;
                            rarity = -1;
                            name = "Leather Cap";
                            healthMultiplier = 1;
                            attackMultiplier = 1;
                            defenseMultiplier = 1;
                            magicMultiplier = 1;
                            picture = MainWindow.imageByteConverter(Properties.Resources.leatherCap);
                            break;
                        case 1:
                            helmetID = 0;
                            rarity = 0;
                            name = "Wizard Hat";
                            healthMultiplier = (float)rng.Next(10, 11) / 10;
                            attackMultiplier = (float)rng.Next(10, 10) / 10;
                            defenseMultiplier = (float)rng.Next(10, 12) / 10;
                            magicMultiplier = (float)rng.Next(14, 16) / 10;
                            picture = MainWindow.imageByteConverter(Properties.Resources.wizardHat);
                            break;
                        case 2:
                            helmetID = 1;
                            rarity = 1;
                            name = "Royal Guard Helmet";
                            healthMultiplier = (float)rng.Next(13, 15) / 10;
                            attackMultiplier = (float)rng.Next(13, 15) / 10;
                            defenseMultiplier = (float)rng.Next(15, 19) / 10;
                            magicMultiplier = (float)rng.Next(16, 18) / 10;
                            picture = MainWindow.imageByteConverter(Properties.Resources.royalHelmet);
                            break;
                        case 3:
                            helmetID = 2;
                            rarity = 2;
                            name = "Archmage Hat";
                            healthMultiplier = (float)rng.Next(12, 15) / 10;
                            attackMultiplier = (float)rng.Next(10, 10) / 10;
                            defenseMultiplier = (float)rng.Next(12, 15) / 10;
                            magicMultiplier = (float)rng.Next(20, 25) / 10;
                            picture = MainWindow.imageByteConverter(Properties.Resources.archmageHat);
                            break;
                        case 4:
                            helmetID = 3;
                            rarity = 3;
                            name = "Runed Crown";
                            healthMultiplier = (float)rng.Next(15, 20) / 10;
                            attackMultiplier = (float)rng.Next(15, 20) / 10;
                            defenseMultiplier = (float)rng.Next(20, 25) / 10;
                            magicMultiplier = (float)rng.Next(25, 35) / 10;
                            picture = MainWindow.imageByteConverter(Properties.Resources.runedCrown);
                            break;
                    }
                    break;
                case 3: //Rogue
                    switch (helmetRarity)
                    {
                        case 0:
                            helmetID = -1;
                            rarity = -1;
                            name = "Leather Cap";
                            healthMultiplier = 1;
                            attackMultiplier = 1;
                            defenseMultiplier = 1;
                            magicMultiplier = 1;
                            picture = MainWindow.imageByteConverter(Properties.Resources.leatherCap);
                            break;
                        case 1:
                            helmetID = 0;
                            rarity = 0;
                            name = "Hood";
                            healthMultiplier = (float)rng.Next(10, 12) / 10;
                            attackMultiplier = (float)rng.Next(13, 15) / 10;
                            defenseMultiplier = (float)rng.Next(10, 12) / 10;
                            magicMultiplier = (float)rng.Next(13, 15) / 10;
                            picture = MainWindow.imageByteConverter(Properties.Resources.hood);
                            break;
                        case 2:
                            helmetID = 1;
                            rarity = 1;
                            name = "Mail Coif";
                            healthMultiplier = (float)rng.Next(15, 20) / 10;
                            attackMultiplier = (float)rng.Next(14, 17) / 10;
                            defenseMultiplier = (float)rng.Next(14, 17) / 10;
                            magicMultiplier = (float)rng.Next(11, 13) / 10;
                            picture = MainWindow.imageByteConverter(Properties.Resources.mailCoif);
                            break;
                        case 3:
                            helmetID = 2;
                            rarity = 2;
                            name = "Mask";
                            healthMultiplier = (float)rng.Next(11, 13) / 10;
                            attackMultiplier = (float)rng.Next(18, 23) / 10;
                            defenseMultiplier = (float)rng.Next(11, 13) / 10;
                            magicMultiplier = (float)rng.Next(20, 25) / 10;
                            picture = MainWindow.imageByteConverter(Properties.Resources.mask);
                            break;
                        case 4:
                            helmetID = 3;
                            rarity = 3;
                            name = "Helm of Hades";
                            healthMultiplier = (float)rng.Next(15, 20) / 10;
                            attackMultiplier = (float)rng.Next(27, 32) / 10;
                            defenseMultiplier = (float)rng.Next(15, 20) / 10;
                            magicMultiplier = (float)rng.Next(27, 32) / 10;
                            picture = MainWindow.imageByteConverter(Properties.Resources.helmHades);
                            break;
                    }
                    break;
            }
        }

        public Helmets(int helmetRarity, int classID)
        {
            helmetID = -1;
            rarity = -1;
            name = "Helmet";
            healthMultiplier = 1;
            attackMultiplier = 1;
            defenseMultiplier = 1;
            magicMultiplier = 1;
            picture = MainWindow.imageByteConverter(Properties.Resources.leatherCap);
        }
    }
}
