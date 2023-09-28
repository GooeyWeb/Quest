using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Quest
{
    public class Player
    {
        public int questsQuantity { get; set; }
        public int classID { get; set; }
        //0 - None; 1 - Warrior; 2 - Mage; 3 - Rogue;
        public double health { get; set; }
        public double attack { get; set; }
        public double defense { get; set; }
        public double magic { get; set; }
        public int money { get; set; }
        public int upgCost1 { get; set; }
        public int upgCost2 { get; set; }
        public int upgCost3 { get; set; }
        public int upgCost4 { get; set; }
        public int bossClear { get; set; }
        public int fights { get; set; }
        public string skill1 { get; set; }
        public string skill2 { get; set; }
        public string skill3 { get; set; }
        public Player() 
        {
            questsQuantity = 0;
            classID = 1;
            health = 1f;
            attack = 1f;
            defense = 1f;
            magic = 1f;
            money = 0;
            upgCost1 = 5;
            upgCost2 = 5;
            upgCost3 = 5;
            upgCost4 = 5;
            bossClear = 0;
            fights = 0;
            skill1 = "Direct Attack";
            skill2 = "Fireball";
            skill3 = "Shield Bash";
        }

        public Player(int classID)
        {
            switch (classID)
            {
                case 1: //Warrior
                    questsQuantity = 0;
                    this.classID = classID;
                    health = 20f;
                    attack = 4f;
                    defense = 4f;
                    magic = 1f;
                    money = 0;
                    upgCost1 = 5;
                    upgCost2 = 5;
                    upgCost3 = 5;
                    upgCost4 = 5;
                    bossClear = 0;
                    fights = 0;
                    skill1 = "Swing";
                    skill2 = "Shield";
                    skill3 = "Guard Up";
                    break;
                case 2: //Mage
                    questsQuantity = 0;
                    this.classID = classID;
                    health = 15f;
                    attack = 1f;
                    defense = 1f;
                    magic = 7f;
                    money = 0;
                    upgCost1 = 5;
                    upgCost2 = 5;
                    upgCost3 = 5;
                    upgCost4 = 5;
                    bossClear = 0;
                    fights = 0;
                    skill1 = "Fireball";
                    skill2 = "Heal Pulse";
                    skill3 = "Meditation";
                    break;
                case 3: //Rogue
                    questsQuantity = 0;
                    this.classID = classID;
                    health = 10f;
                    attack = 8f;
                    defense = 2f;
                    magic = 3f;
                    money = 0;
                    upgCost1 = 5;
                    upgCost2 = 5;
                    upgCost3 = 5;
                    upgCost4 = 5;
                    bossClear = 0;
                    fights = 0;
                    skill1 = "Direct Attack";
                    skill2 = "Fireball";
                    skill3 = "Inside Fury";
                    break;
            }
        }
    }
}
