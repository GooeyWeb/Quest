using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Quest
{
    public class Quests
    {
        public int questID { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public int difficulty { get; set; } 
        // 1 - Easy; 2 - Medium; 3 - Hard; 4 - Legendary;
        public int coins { get; set; }
        public bool loot { get; set; }

        public Quests()
        {
            questID = MainWindow.person.player.questsQuantity;
            title = "Mystery Quest";
            description = "There's nothing about it...";
            difficulty = 1;
            coins = 0;
            loot = false;
        }
        public Quests(string title, string description, int difficulty)
        {
            questID = MainWindow.person.player.questsQuantity;
            Random rng = new Random();
            this.title = title;
            this.description = description;
            this.difficulty = difficulty;
            coins = rng.Next(40,60) * (int)Math.Pow(difficulty,2);
            if (rng.Next(2) % 2 == 0)
                loot = true;
            else 
                loot = false;
        }
    }
}
