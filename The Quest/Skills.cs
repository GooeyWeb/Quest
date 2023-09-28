using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Quest
{
    public class Skills
    {
        public string attackName { get; set; }
        public int attackPower { get; set; }
        public bool threeTargets { get; set; }
        public bool ignoreShield { get; set; }
        public float attackBoost { get; set; }
        public float defenseBoost { get; set; }
        public float magicBoost { get; set; }
        public int heal { get; set; }

        public Skills()
        {
            attackName = "Attack";
            attackPower = 0;
            threeTargets = false;
            ignoreShield = false;
            attackBoost = 1;
            defenseBoost = 1;
            magicBoost = 1;
            heal = 0;
        }

        public Skills(string attackName)
        {
            switch(attackName) 
            {
                case "Direct Attack":
                    this.attackName = attackName;
                    attackPower = MainWindow.temporaryAttack;
                    threeTargets = false;
                    ignoreShield = true;
                    attackBoost = 1;
                    defenseBoost = 1;
                    magicBoost = 1;
                    heal = 0;
                    break;
                case "Swing":
                    this.attackName = attackName;
                    attackPower = (int)(MainWindow.temporaryAttack * 0.7);
                    threeTargets = true;
                    ignoreShield = false;
                    attackBoost = 1;
                    defenseBoost = 1;
                    magicBoost = 1;
                    heal = 0;
                    break;
                case "Shield Aside":
                    this.attackName = attackName;
                    attackPower = 0;
                    threeTargets = false;
                    ignoreShield = false;
                    attackBoost = MainWindow.temporaryDefense;
                    defenseBoost = 0;
                    magicBoost = MainWindow.temporaryDefense;
                    heal = 0;
                    break;
                case "Shield Bash":
                    this.attackName = attackName;
                    attackPower = MainWindow.temporaryDefense;
                    threeTargets = true;
                    ignoreShield = false;
                    attackBoost = 1;
                    defenseBoost = 1;
                    magicBoost = 1;
                    heal = 0;
                    break;
                case "Guard Up":
                    this.attackName = attackName;
                    attackPower = 0;
                    threeTargets = false;
                    ignoreShield = false;
                    attackBoost = MainWindow.temporaryDefense;
                    defenseBoost = MainWindow.temporaryAttack;
                    magicBoost = 1;
                    heal = 0;
                    break;
                case "Meditation":
                    this.attackName = attackName;
                    attackPower = 0;
                    threeTargets = false;
                    ignoreShield = false;
                    attackBoost = 0.5f;
                    defenseBoost = 2;
                    magicBoost = 1;
                    heal = 10;
                    break;
                case "Fireball":
                    if (MainWindow.person.player.classID == 2)
                    {
                        this.attackName = attackName;
                        attackPower = (int)(1.2 * MainWindow.temporaryMagic);
                        threeTargets = false;
                        ignoreShield = true;
                        attackBoost = 1;
                        defenseBoost = 1;
                        magicBoost = 1;
                        heal = 0;
                    }
                    else
                    {
                        this.attackName = attackName;
                        attackPower = MainWindow.temporaryMagic;
                        threeTargets = false;
                        ignoreShield = true;
                        attackBoost = 1;
                        defenseBoost = 1;
                        magicBoost = 1;
                        heal = 0;
                    }
                    break;
                case "Heal Pulse":
                    if (MainWindow.person.player.classID == 2)
                    {
                        this.attackName = attackName;
                        attackPower = 0;
                        threeTargets = false;
                        ignoreShield = false;
                        attackBoost = 1;
                        defenseBoost = 1;
                        magicBoost = 1;
                        heal = MainWindow.monstersAlive * 25;
                    }
                    else
                    {
                        this.attackName = attackName;
                        attackPower = 0;
                        threeTargets = false;
                        ignoreShield = false;
                        attackBoost = 1;
                        defenseBoost = 1;
                        magicBoost = 1;
                        heal = MainWindow.monstersAlive * 15;
                    }
                    break;
                case "Inside Fury":
                    if (MainWindow.person.player.classID == 2)
                    {
                        this.attackName = attackName;
                        attackPower = 0;
                        threeTargets = false;
                        ignoreShield = false;
                        attackBoost = 1;
                        defenseBoost = 1;
                        magicBoost = 1.5f;
                        heal = 0;
                    }
                    else
                    {
                        this.attackName = attackName;
                        attackPower = 0;
                        threeTargets = false;
                        ignoreShield = false;
                        attackBoost = 2.5f;
                        defenseBoost = 0.5f;
                        magicBoost = 2.5f;
                        heal = 0;
                    }
                    break;
            }
        }
    }
}
