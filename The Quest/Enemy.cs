using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using The_Quest.Properties;

namespace The_Quest
{
    public class Enemy
    {
        public string name { get; set; }
        public bool boss { get; set; }
        public int health { get; set; }
        public int attackPower { get; set; }
        public int defense { get; set; }
        public int gold { get; set; }
        public int lootTier { get; set; }
        public bool ignoringShields { get; set; }
        public byte[] picture { get; set; }

        public int higherAttack()
        {
            int attack = (int)MainWindow.person.player.attack;
            int magic = (int)MainWindow.person.player.magic;

            if (attack > magic)
                return attack;
            else
                return magic;
        }
        public Enemy(string name)
        {
            Random rng = new Random();
            switch (name) 
            {
                case "nothing":
                    this.name = name;
                    boss = false;
                    health = 0;
                    attackPower = 0;
                    defense = 0;
                    gold = 0;
                    lootTier = 0;
                    ignoringShields = false;
                    picture = MainWindow.imageByteConverter(Properties.Resources.ghost);
                    break;
                case "Slime":
                    this.name = name;
                    boss = false;
                    health = (int)(MainWindow.person.player.health/10);
                    attackPower = (int)(1 + (higherAttack() / 5));
                    defense = (int)(2 + (higherAttack() / 10));
                    gold = rng.Next(5, 20);
                    lootTier = 1;
                    ignoringShields = true;
                    picture = MainWindow.imageByteConverter(Properties.Resources.slime);
                    break;
                case "Goblin":
                    this.name = name;
                    boss = false;
                    health = (int)(10 +(MainWindow.person.player.health / 5));
                    attackPower = (int)(5 + (higherAttack() / 8));
                    defense = 3;
                    gold = rng.Next(20, 30);
                    lootTier = 1;
                    ignoringShields = false;
                    picture = MainWindow.imageByteConverter(Properties.Resources.goblin);
                    break;
                case "Goblin Mage":
                    this.name = name;
                    boss = false;
                    health = (int)(5 + (MainWindow.person.player.health / 6));
                    attackPower = (int)(10 + (higherAttack() / 5));
                    defense = 1;
                    gold = rng.Next(30, 50);
                    lootTier = 2;
                    ignoringShields = true;
                    picture = MainWindow.imageByteConverter(Properties.Resources.goblinmage);
                    break;
                case "Goblin King":
                    this.name = name;
                    boss = true;
                    health = (int)(300 + (MainWindow.person.player.health / 4));
                    attackPower = (int)(20 + (higherAttack() / 4));
                    defense = (int)(20 + (MainWindow.person.player.defense / 2));
                    gold = rng.Next(500, 1000);
                    lootTier = 3;
                    ignoringShields = false;
                    picture = MainWindow.imageByteConverter(Properties.Resources.goblinking);
                    break;
                case "Wolf":
                    this.name = name;
                    boss = false;
                    health = 100;
                    attackPower = (int)(higherAttack() / 3);
                    defense = 0;
                    gold = rng.Next(0, 10);
                    lootTier = 3;
                    ignoringShields = false;
                    picture = MainWindow.imageByteConverter(Properties.Resources.wolf);
                    break;
                case "Crystal Boar":
                    this.name = name;
                    boss = false;
                    health = (int)(500 + (MainWindow.person.player.money / 5));
                    attackPower = (int)(10 + (higherAttack() / 15));
                    defense = 35;
                    gold = rng.Next(600, 800);
                    lootTier = 2;
                    ignoringShields = false;
                    picture = MainWindow.imageByteConverter(Properties.Resources.boar);
                    break;
                case "Wyvern":
                    this.name = name;
                    boss = false;
                    health = higherAttack();
                    attackPower = (higherAttack()/2);
                    defense = 5;
                    gold = rng.Next(300, 500);
                    lootTier = 3;
                    ignoringShields = false;
                    picture = MainWindow.imageByteConverter(Properties.Resources.wyvern);
                    break;
                case "Dragon":
                    this.name = name;
                    boss = true;
                    health = (int)(700 + (MainWindow.person.player.health / 2));
                    attackPower = (int)(100 + (higherAttack() / 4));
                    defense = (int)(MainWindow.person.player.defense / 4);
                    gold = rng.Next(5000, 10000);
                    lootTier = 4;
                    ignoringShields = true;
                    picture = MainWindow.imageByteConverter(Properties.Resources.dragon);
                    break;
                case "Skeleton":
                    this.name = name;
                    boss = false;
                    health = 3;
                    attackPower = (int)(30 + (higherAttack() / 5));
                    defense = higherAttack() - 1;
                    gold = rng.Next(300, 500);
                    lootTier = 2;
                    ignoringShields = false;
                    picture = MainWindow.imageByteConverter(Properties.Resources.skeleton);
                    break;
                case "Ghost":
                    this.name = name;
                    boss = false;
                    health = (int)MainWindow.person.player.health;
                    attackPower = (int)(50 + (higherAttack() / 3));
                    defense = 0;
                    gold = rng.Next(400, 700);
                    lootTier = 3;
                    ignoringShields = true;
                    picture = MainWindow.imageByteConverter(Properties.Resources.ghost);
                    break;
                case "Dark Mage":
                    this.name = name;
                    boss = false;
                    health = 300;
                    attackPower = (int)(higherAttack() / 2);
                    defense = 50;
                    gold = rng.Next(600, 900);
                    lootTier = 4;
                    ignoringShields = true;
                    picture = MainWindow.imageByteConverter(Properties.Resources.darkmage);
                    break;
                case "Demon":
                    this.name = name;
                    boss = true;
                    health = (int)(MainWindow.person.player.health)*4;
                    attackPower = (int)((MainWindow.person.player.defense) / 4 ) + (higherAttack() / 3);
                    defense = (int)((MainWindow.person.player.health) / 6) + ((int)(MainWindow.person.player.questsQuantity));
                    gold = rng.Next(10000, 20000);
                    lootTier = 4;
                    ignoringShields = false;
                    picture = MainWindow.imageByteConverter(Properties.Resources.demon);
                    break;
            }
        }
    }
}
