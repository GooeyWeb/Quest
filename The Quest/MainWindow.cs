using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using The_Quest.Properties;

namespace The_Quest
{
    public partial class MainWindow : Form
    {
        public static Person person;
        public static Skills currentSkill;
        public static Skills lastSkillUsed;
        public static List<Quests> tasks = new List<Quests>();
        public static List<Enemy> enemies = new List<Enemy>();

        public static bool characterExist = true;
        public static bool isGuildOpen = false;
        public static bool isCharacterOpen = false;
        public static bool isListOpen = false;
        public static bool isGuideOpen = false;
        public static bool isBossFight = false;
        public static bool isFightActive = false;
        public static bool delayedAction = false;
        public static bool targeting = false;
        public static bool coward = false;
        public static int x, y;

        public static int monstersAlive = 0;
        public static int temporaryHealth = 1;
        public static int temporaryAttack = 1;
        public static int temporaryDefense = 1;
        public static int temporaryMagic = 1;

        QuestList questList;
        QuestMaker questMaker;
        Character character;
        GuideBook guideBook;

        
        public MainWindow()
        {
            InitializeComponent();
            loadPlayer();
            loadQuests();
            loadBattle();
            questInitialization();
            updateGUI();
        }

        static public Image byteImageConverter(byte[] pictureArr)
        {
            MemoryStream memoryStream = new MemoryStream(pictureArr);
            Image image = Image.FromStream(memoryStream);
            return image;
        }
        static public byte[] imageByteConverter(Image picture)
        {
            MemoryStream memoryStream = new MemoryStream();
            picture.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Png);
            return memoryStream.ToArray();
        }
        public void updateGUI()
        {
            info.Text = Texts.hello; //Text Board Welcome
            switch (person.player.classID) //Player Image
            {
                case 1:
                    Player.BackgroundImage = Properties.Resources.warrior;
                    break;
                case 2:
                    Player.BackgroundImage = Properties.Resources.mage;
                    break;
                case 3:
                    Player.BackgroundImage = Properties.Resources.rogue;
                    break;
                default:
                    Player.BackgroundImage = Properties.Resources.warrior;
                    break;
            }
            skill1_pic.BackgroundImage = getSkillPic(person.player.skill1);
            skill2_pic.BackgroundImage = getSkillPic(person.player.skill2);
            skill3_pic.BackgroundImage = getSkillPic(person.player.skill3);
        }
        public void questInitialization()
        {
            int i = 1;
            foreach (Quests x in tasks)
            {
                if (i < tasks.Count()) //first 6 quests
                {
                    questActivator(i, x);
                }
                else if (i == tasks.Count()) //empty quests
                {
                    questActivator(i, x);
                    for (int j = 1 + i; j <= 6; j++)
                    {
                        switch (j)
                        {
                            case 1:
                                quest1.Hide();
                                quest1diff.Hide();
                                quest1title.Hide();
                                quest1claim.Hide();
                                break;
                            case 2:
                                quest2.Hide();
                                quest2diff.Hide();
                                quest2title.Hide();
                                quest2claim.Hide();
                                break;
                            case 3:
                                quest3.Hide();
                                quest3diff.Hide();
                                quest3title.Hide();
                                quest3claim.Hide();
                                break;
                            case 4:
                                quest4.Hide();
                                quest4diff.Hide();
                                quest4title.Hide();
                                quest4claim.Hide();
                                break;
                            case 5:
                                quest5.Hide();
                                quest5diff.Hide();
                                quest5title.Hide();
                                quest5claim.Hide();
                                break;
                            case 6:
                                quest6.Hide();
                                quest6diff.Hide();
                                quest6title.Hide();
                                quest6claim.Hide();
                                break;
                            default:
                                break;
                        }
                        if (j == 6)
                            break;
                    }
                }
                i++;
            }
            if (tasks.Count() == 0)
            {
                quest1.Hide();
                quest1title.Hide();
                quest1diff.Hide();
                quest1claim.Hide();
                quest2.Hide();
                quest2title.Hide();
                quest2diff.Hide();
                quest2claim.Hide();
                quest3.Hide();
                quest3title.Hide();
                quest3diff.Hide();
                quest3claim.Hide();
                quest4.Hide();
                quest4title.Hide();
                quest4diff.Hide();
                quest4claim.Hide();
                quest5.Hide();
                quest5title.Hide();
                quest5diff.Hide();
                quest5claim.Hide();
                quest6.Hide();
                quest6title.Hide();
                quest6diff.Hide();
                quest6claim.Hide();
            }

        }
        public void questActivator(int i, Quests x)
        {
            switch (i)
            {
                case 1:
                    quest1title.Text = x.title;
                    switch (x.difficulty)
                    {
                        case 1:
                            quest1diff.BackgroundImage = Properties.Resources.easy;
                            break;
                        case 2:
                            quest1diff.BackgroundImage = Properties.Resources.medium;
                            break;
                        case 3:
                            quest1diff.BackgroundImage = Properties.Resources.hard;
                            break;
                        case 4:
                            quest1diff.BackgroundImage = Properties.Resources.legendary;
                            break;
                    }
                    quest1.Show();
                    quest1diff.Show();
                    quest1title.Show();
                    quest1claim.Show();
                    break;

                case 2:
                    quest2title.Text = x.title;
                    switch (x.difficulty)
                    {
                        case 1:
                            quest2diff.BackgroundImage = Properties.Resources.easy;
                            break;
                        case 2:
                            quest2diff.BackgroundImage = Properties.Resources.medium;
                            break;
                        case 3:
                            quest2diff.BackgroundImage = Properties.Resources.hard;
                            break;
                        case 4:
                            quest2diff.BackgroundImage = Properties.Resources.legendary;
                            break;
                    }
                    quest2.Show();
                    quest2diff.Show();
                    quest2title.Show();
                    quest2claim.Show();
                    break;

                case 3:
                    quest3title.Text = x.title;
                    switch (x.difficulty)
                    {
                        case 1:
                            quest3diff.BackgroundImage = Properties.Resources.easy;
                            break;
                        case 2:
                            quest3diff.BackgroundImage = Properties.Resources.medium;
                            break;
                        case 3:
                            quest3diff.BackgroundImage = Properties.Resources.hard;
                            break;
                        case 4:
                            quest3diff.BackgroundImage = Properties.Resources.legendary;
                            break;
                    }
                    quest3.Show();
                    quest3diff.Show();
                    quest3title.Show();
                    quest3claim.Show();
                    break;

                case 4:
                    quest4title.Text = x.title;
                    switch (x.difficulty)
                    {
                        case 1:
                            quest4diff.BackgroundImage = Properties.Resources.easy;
                            break;
                        case 2:
                            quest4diff.BackgroundImage = Properties.Resources.medium;
                            break;
                        case 3:
                            quest4diff.BackgroundImage = Properties.Resources.hard;
                            break;
                        case 4:
                            quest4diff.BackgroundImage = Properties.Resources.legendary;
                            break;
                    }
                    quest4.Show();
                    quest4diff.Show();
                    quest4title.Show();
                    quest4claim.Show();
                    break;

                case 5:
                    quest5title.Text = x.title;
                    switch (x.difficulty)
                    {
                        case 1:
                            quest5diff.BackgroundImage = Properties.Resources.easy;
                            break;
                        case 2:
                            quest5diff.BackgroundImage = Properties.Resources.medium;
                            break;
                        case 3:
                            quest5diff.BackgroundImage = Properties.Resources.hard;
                            break;
                        case 4:
                            quest5diff.BackgroundImage = Properties.Resources.legendary;
                            break;
                    }
                    quest5.Show();
                    quest5diff.Show();
                    quest5title.Show();
                    quest5claim.Show();
                    break;

                case 6:
                    quest6title.Text = x.title;
                    switch (x.difficulty)
                    {
                        case 1:
                            quest6diff.BackgroundImage = Properties.Resources.easy;
                            break;
                        case 2:
                            quest6diff.BackgroundImage = Properties.Resources.medium;
                            break;
                        case 3:
                            quest6diff.BackgroundImage = Properties.Resources.hard;
                            break;
                        case 4:
                            quest6diff.BackgroundImage = Properties.Resources.legendary;
                            break;
                    }
                    quest6.Show();
                    quest6diff.Show();
                    quest6title.Show();
                    quest6claim.Show();
                    break;
            }
        }
        public void loadPlayer()
        {
            try
            {
                MemoryStream stream = new MemoryStream();

                XmlSerializer xmlSerializer = new XmlSerializer(typeof(Person));
                using (FileStream fileStream = new FileStream("data.xml", FileMode.Open))
                    person = xmlSerializer.Deserialize(fileStream) as Person;
            }
            catch
            {
                Console.WriteLine("Player loading error");
            }

            if (person == null)
            {
                characterExist = false;
                Classes cc = new Classes();
                cc.ShowDialog();
            }
        }
        public void savePlayer()
        {
            if (characterExist)
            {
                Person playerData = person;
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(Person));
                using (FileStream fileStream = new FileStream("data.xml", FileMode.Create))
                {
                    xmlSerializer.Serialize(fileStream, playerData);
                }
            }
        }
        public void loadQuests()
        {
            try
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Quests>));
                using (FileStream fileStream = new FileStream("tasks.xml", FileMode.Open))
                    tasks = xmlSerializer.Deserialize(fileStream) as List<Quests>;
            }
            catch
            {
                Console.WriteLine("Quests loading error");
            }
        }
        public void saveBattle()
        {
            List<String> enemyName = new List<String>();
            foreach(Enemy enemy in enemies)
            {
                enemyName.Add(enemy.name);
            }

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<String>));
            using (FileStream fileStream = new FileStream("battle.xml", FileMode.Create))
            {
                xmlSerializer.Serialize(fileStream, enemyName);
            }
        }
        public void loadBattle()
        {
            try
            {
                List<String> names = new List<String>();
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<String>));
                using (FileStream fileStream = new FileStream("battle.xml", FileMode.Open))
                    names = xmlSerializer.Deserialize(fileStream) as List<String>;

                isFightActive = true;
                nextFight_btn.Hide();
                run_pic.Show();

                try
                {
                    character.Close();
                    questList.Close();
                }
                catch
                {
                    Console.WriteLine("Character/Quest List window already closed.");
                }

                spawnEnemies(names[0], names[1], names[2]);
            }
            catch
            {
                Console.WriteLine("No battle active");
                isFightActive = false;
                nextFight_btn.Show();
                run_pic.Hide();
            }
        }
        public void battleScenario()
        {
            Random rng = new Random();
            switch (person.player.bossClear) 
            {
                case 0:
                    if (person.player.fights > 10 && rng.Next(5) == 0)
                        isBossFight = true;
                    initializeFight(person.player.bossClear);
                    break;
                case 1:
                    if (person.player.fights > 20 && rng.Next(5) == 0)
                        isBossFight = true;
                    initializeFight(person.player.bossClear);
                    break;
                default:
                    if (person.player.fights > 30 && rng.Next(10) == 0)
                        isBossFight = true;
                    initializeFight(person.player.bossClear);
                    break;
            }

        }
        public void initializeFight(int milieu)
        {
            run_pic.Show();
            isFightActive = true;
            try
            {
                character.Close();
                questList.Close();
            }
            catch
            {
                Console.WriteLine("Character/Quest List window already closed.");
            }
            int progress = person.player.fights;
            int possibleEnemies;
            Random rng = new Random();

            switch (milieu) 
            {
                case 0:
                    if(isBossFight)
                    {
                        spawnEnemies("nothing", "Goblin King", "nothing");
                    }
                    else
                    {
                        if (progress > 10)
                            possibleEnemies = rng.Next(100);
                        else if (progress > 2)
                            possibleEnemies = rng.Next(50);
                        else
                            possibleEnemies = rng.Next(3);

                        if (possibleEnemies >= 90) //Scenario 1
                        {
                            spawnEnemies("Goblin Mage", "Goblin", "Goblin Mage");
                        }
                        else if (possibleEnemies >= 80) //Scenario 2
                        {
                            spawnEnemies("Goblin", "Goblin Mage", "Goblin");
                        }
                        else if (possibleEnemies >= 65) //Scenario 3
                        {
                            spawnEnemies("Goblin", "Goblin Mage", "Slime");
                        }
                        else if (possibleEnemies >= 55) //Scenario 4
                        {
                            spawnEnemies("nothing", "Goblin Mage", "nothing");
                        }
                        else if (possibleEnemies >= 45) //Scenario 5
                        {
                            spawnEnemies("Goblin", "Goblin", "Goblin");
                        }
                        else if (possibleEnemies >= 30) //Scenario 6
                        {
                            spawnEnemies("Goblin", "Slime", "Goblin");
                        }
                        else if (possibleEnemies >= 10) //Scenario 7
                        {
                            spawnEnemies("Slime", "Goblin", "Slime");
                        }
                        else if (possibleEnemies >= 5) //Scenario 8
                        {
                            spawnEnemies("Goblin", "Goblin", "nothing");
                        }
                        else if (possibleEnemies >= 1) //Scenario 9
                        {
                            spawnEnemies("Slime", "Slime", "Slime");
                        }
                        else //Scenario 10
                        {
                            spawnEnemies("nothing", "Slime", "Slime");
                        }
                    }
                    break;
                case 1:
                    if(isBossFight)
                    {
                        spawnEnemies("nothing", "Dragon", "nothing");
                    }
                    else
                    {
                        if (progress > 10)
                            possibleEnemies = rng.Next(100);
                        else if (progress > 3)
                            possibleEnemies = rng.Next(50);
                        else
                            possibleEnemies = rng.Next(25);

                        if (possibleEnemies >= 90) //Scenario 1
                        {
                            spawnEnemies("Crystal Boar", "Crystal Boar", "Crystal Boar");
                        }
                        else if (possibleEnemies >= 80) //Scenario 2
                        {
                            spawnEnemies("Wyvern", "nothing", "Wyvern");
                        }
                        else if (possibleEnemies >= 65) //Scenario 3
                        {
                            spawnEnemies("Crystal Boar", "Goblin", "Goblin Mage");
                        }
                        else if (possibleEnemies >= 55) //Scenario 4
                        {
                            spawnEnemies("nothing", "Wyvern", "nothing");
                        }
                        else if (possibleEnemies >= 35) //Scenario 5
                        {
                            spawnEnemies("Wolf", "Wolf", "Wolf");
                        }
                        else if (possibleEnemies >= 20) //Scenario 6
                        {
                            spawnEnemies("Wolf", "Goblin", "Wolf");
                        }
                        else if (possibleEnemies >= 10) //Scenario 7
                        {
                            spawnEnemies("nothing", "Crystal Boar", "nothing");
                        }
                        else //Scenario 8
                        {
                            spawnEnemies("nothing", "Wolf", "nothing");
                        }
                    }
                    break;
                default:
                    if(isBossFight)
                    {
                        spawnEnemies("nothing", "Demon", "nothing");
                    }
                    else
                    {
                        if (progress > 15)
                            possibleEnemies = rng.Next(100);
                        else if (progress > 5)
                            possibleEnemies = rng.Next(70);
                        else
                            possibleEnemies = rng.Next(40);

                        if (possibleEnemies >= 95) //Scenario 1
                        {
                            spawnEnemies("Wyvern", "Dragon", "Wyvern");
                        }
                        else if (possibleEnemies >= 80) //Scenario 2
                        {
                            spawnEnemies("Dark Mage", "Goblin King", "Dark Mage");
                        }
                        else if (possibleEnemies >= 65) //Scenario 3
                        {
                            spawnEnemies("Wolf", "Dark Mage", "Wolf");
                        }
                        else if (possibleEnemies >= 55) //Scenario 4
                        {
                            spawnEnemies("Ghost", "nothing", "Ghost");
                        }
                        else if (possibleEnemies >= 35) //Scenario 5
                        {
                            spawnEnemies("Skeleton", "Skeleton", "Skeleton");
                        }
                        else if (possibleEnemies >= 20) //Scenario 6
                        {
                            spawnEnemies("Goblin Mage", "Ghost", "Goblin Mage");
                        }
                        else if (possibleEnemies >= 10) //Scenario 7
                        {
                            spawnEnemies("Skeleton", "Crystal Boar", "Crystal Boar");
                        }
                        else //Scenario 8
                        {
                            spawnEnemies("nothing", "Skeleton", "Slime");
                        }
                    }
                    break;
            }
        }
        public void spawnEnemies(string name1,  string name2, string name3)
        {
            spawn1Enemy(name1);
            spawn2Enemy(name2);
            spawn3Enemy(name3);
        }
        public void spawn1Enemy(string name)
        {
            Enemy enemy = new Enemy(name);
            enemies.Add(enemy);
            healthbar1.Maximum = enemy.health;
            healthbar1.Value = enemy.health;

            if (name == "nothing") //empty slot
            {
                healthbar1.Hide();
                enemy1_pic.Hide();
            }
            else
            {
                enemy1_pic.BackgroundImage = byteImageConverter(enemy.picture);
                healthbar1.Show();
                enemy1_pic.Show();
            }
            
        }
        public void spawn2Enemy(string name)
        {
            Enemy enemy = new Enemy(name);
            enemies.Add(enemy);

            if (name == "nothing") //empty slot
            {
                healthbar2.Hide();
                enemy2_pic.Hide();
                bosshealthbar.Hide();
                boss_pic.Hide();
            }
            else if (enemy.boss)
            {
                bosshealthbar.Maximum = enemy.health;
                bosshealthbar.Value = enemy.health;
                boss_pic.BackgroundImage = byteImageConverter(enemy.picture);
                bosshealthbar.Show();
                boss_pic.Show();
            }
            else
            {
                healthbar2.Maximum = enemy.health;
                healthbar2.Value = enemy.health;
                enemy2_pic.BackgroundImage = byteImageConverter(enemy.picture);
                healthbar2.Show();
                enemy2_pic.Show();
            }
        }
        public void spawn3Enemy(string name)
        {
            Enemy enemy = new Enemy(name);
            enemies.Add(enemy);
            healthbar3.Maximum = enemy.health;
            healthbar3.Value = enemy.health;

            if (name == "nothing") //empty slot
            {
                healthbar3.Hide();
                enemy3_pic.Hide();
            }
            else
            {
                enemy3_pic.BackgroundImage = byteImageConverter(enemy.picture);
                healthbar3.Show();
                enemy3_pic.Show();
            }
        }
        public bool checkForWin()
        {
            countMonsters();
            if(monstersAlive == 0)
            {
                person.player.fights++;
                int bestLootTier = 1;
                Random rng = new Random();
                foreach (Enemy enemy in enemies) 
                { 
                    if(enemy.lootTier > bestLootTier)
                        bestLootTier = enemy.lootTier;
                }
                if (isBossFight)
                {
                    person.player.bossClear++;
                    if (enemies[1].name != "Demon")
                        person.player.fights = 0;
                }
                endBattleSequence(bestLootTier);
                info.Text = Texts.rewards;
                return true;
            }
            else if (playerhealtbar.Value <= 0)
            {
                info.Text = Texts.lost;
                endBattleSequence(0);
                return true;
            }
            else if (coward)
            {
                coward = false;
                person.player.money -= (int)(person.player.money / 50);
                endBattleSequence(0);
                return true;
            }
            return false;
        }
        public void endBattleSequence(int lootTier)
        {
            if(lootTier > 0)
                claimLoot(lootTier);
            nextFight_btn.Show();
            enemies.Clear();
            hideEnemies();
            isFightActive = false;
            isBossFight = false;
        }
        public void hideEnemies()
        {
            bosshealthbar.Maximum = 0;
            bosshealthbar.Value = 0;
            bosshealthbar.Hide();
            boss_pic.Hide();
            enemy1_pic.Hide();
            enemy2_pic.Hide();
            enemy3_pic.Hide();
            healthbar1.Maximum = 0;
            healthbar1.Value = 0;
            healthbar2.Maximum = 0;
            healthbar2.Value = 0;
            healthbar3.Maximum = 0;
            healthbar3.Value = 0;
            healthbar1.Hide();
            healthbar2.Hide();
            healthbar3.Hide();
            run_pic.Hide();
        }
        public void GetMainWindowCords()
        {
            x = this.Location.X;
            y = this.Location.Y;
        }

        private void btn_QM_Click(object sender, EventArgs e)
        {
            if (isGuildOpen)
            {
                questMaker.Activate();
            }
            else
            {
                if(!isFightActive)
                    info.Text = Texts.quests;
                questMaker = new QuestMaker();
                questMaker.Show();
                isGuildOpen = true;
            }
        }
        private void Player_Click(object sender, EventArgs e)
        {
            if (!isFightActive)
            {
                if (isCharacterOpen)
                {
                    character.Activate();
                }
                else
                {
                    GetMainWindowCords();
                    character = new Character();
                    character.Location = new Point(x + 589, y);
                    character.Show();
                    isCharacterOpen = true;
                }
            }
            else
                info.Text = Texts.warning;
        }
        private void MainWindow_Activated(object sender, EventArgs e)
        {
            questInitialization();
            skill1_pic.BackgroundImage = getSkillPic(person.player.skill1);
            skill2_pic.BackgroundImage = getSkillPic(person.player.skill2);
            skill3_pic.BackgroundImage = getSkillPic(person.player.skill3);
        }

        public void claimQuest(int questNumber)
        {
            int i = 1;
            foreach (Quests x in tasks)
            {
                if (i == questNumber)
                {
                    person.player.money += x.coins;
                    if (x.loot)
                    {
                        info.Text = Texts.rewards;
                        claimLoot(x.difficulty);
                    }
                    tasks.Remove(x);
                    break;
                }
                i++;
            }
        }
        public static void claimLoot(int questTier)
        {
            Random rng = new Random();
            int i = rng.Next(100);
            switch (questTier)
            {
                case 1:
                    if (i < 70)
                        Loot.rarityOfLoot = 1;
                    else if (i < 90)
                        Loot.rarityOfLoot = 2;
                    else
                        Loot.rarityOfLoot = 3;
                    break;
                case 2:
                    if (i < 40)
                        Loot.rarityOfLoot = 1;
                    else if (i < 80)
                        Loot.rarityOfLoot = 2;
                    else
                        Loot.rarityOfLoot = 3;
                    break;
                case 3:
                    if (i < 60)
                        Loot.rarityOfLoot = 2;
                    else if (i < 90)
                        Loot.rarityOfLoot = 3;
                    else
                        Loot.rarityOfLoot = 4;
                    break;
                case 4:
                    if (i < 35)
                        Loot.rarityOfLoot = 3;
                    else
                        Loot.rarityOfLoot = 4;
                    break;
                default:
                    Loot.rarityOfLoot = 1;
                    break;
            }
            Loot.lootType = rng.Next(4);
            Loot loots = new Loot();
            loots.ShowDialog();
        }
        public void countMonsters()
        {
            monstersAlive = 0;
            if (bosshealthbar.Value > 0)
                monstersAlive++;
            if (healthbar1.Value > 0)
                monstersAlive++;
            if (healthbar2.Value > 0)
                monstersAlive++;
            if (healthbar3.Value > 0)
                monstersAlive++;
        }
        public void attack(int skillNumber)
        {
            if (isFightActive)
            {
                countMonsters();

                switch (skillNumber)
                {
                    case 1:
                        currentSkill = new Skills(person.player.skill1);
                        break;
                    case 2:
                        currentSkill = new Skills(person.player.skill2);
                        break;
                    case 3:
                        currentSkill = new Skills(person.player.skill3);
                        break;
                }

                if (currentSkill.threeTargets || monstersAlive == 1 && currentSkill.attackPower > 0)
                {
                    targeting = false;
                    if (currentSkill.ignoreShield)
                    {
                        int x = bosshealthbar.Value - currentSkill.attackPower;
                        if (x >= 0)
                            bosshealthbar.Value = x;
                        else
                            bosshealthbar.Value = 0;

                        x = healthbar1.Value - currentSkill.attackPower;
                        if (x >= 0)
                            healthbar1.Value = x;
                        else
                            healthbar1.Value = 0;

                        x = healthbar2.Value - currentSkill.attackPower;
                        if (x >= 0)
                            healthbar2.Value = x;
                        else
                            healthbar2.Value = 0;

                        x = healthbar3.Value - currentSkill.attackPower;
                        if (x >= 0)
                            healthbar3.Value = x;
                        else
                            healthbar3.Value = 0;
                    }
                    else
                    {
                        int x = bosshealthbar.Value - currentSkill.attackPower;
                        if (x >= 0)
                            bosshealthbar.Value = x;
                        else
                            bosshealthbar.Value = 0;

                        x = healthbar1.Value - currentSkill.attackPower;
                        if (x >= 0)
                            healthbar1.Value = x;
                        else
                            healthbar1.Value = 0;

                        x = healthbar2.Value - currentSkill.attackPower;
                        if (x >= 0)
                            healthbar2.Value = x;
                        else
                            healthbar2.Value = 0;

                        x = healthbar3.Value - currentSkill.attackPower;
                        if (x >= 0)
                            healthbar3.Value = x;
                        else
                            healthbar3.Value = 0;
                    }
                    enemyTurn();
                }
                else if (currentSkill.attackPower == 0)
                {
                    delayedAction = true;
                    lastSkillUsed = currentSkill;

                    switch (currentSkill.attackName) 
                    {
                        case "Inside Fury":

                            if(person.player.classID == 2)
                            {
                                delayedAction = false;
                            }
                            temporaryAttack = (int)(temporaryAttack * currentSkill.attackBoost);
                            temporaryDefense = (int)(temporaryDefense * currentSkill.defenseBoost);
                            temporaryMagic = (int)(temporaryMagic * currentSkill.magicBoost);
                            break;
                        case "Guard Up":
                            int emptyStat = temporaryAttack;
                            temporaryAttack += temporaryDefense;
                            temporaryDefense += emptyStat;
                            break;
                        case "Shield Aside":
                            delayedAction = false;
                            temporaryAttack += temporaryDefense;
                            temporaryMagic += temporaryDefense;
                            temporaryDefense = 0;
                            break;
                        default:
                            int x = playerhealtbar.Value + (int)((playerhealtbar.Maximum / 100) * currentSkill.heal);
                            temporaryAttack = (int)(temporaryAttack * currentSkill.attackBoost);
                            temporaryDefense = (int)(temporaryDefense * currentSkill.defenseBoost);
                            temporaryMagic = (int)(temporaryMagic * currentSkill.magicBoost);
                            if (x >= playerhealtbar.Maximum)
                                playerhealtbar.Value = playerhealtbar.Maximum;
                            else
                                playerhealtbar.Value = x;
                            break;
                    }
                    enemyTurn();
                }
                else //Target to choose
                {
                    info.Text = Texts.target;
                    targeting = true;
                }
            }
            else
                info.Text = Texts.battle;
        }
        public void enemyTurn()
        {
            skill1_pic.BorderStyle = BorderStyle.None;
            skill2_pic.BorderStyle = BorderStyle.None;
            skill3_pic.BorderStyle = BorderStyle.None;
            if(!checkForWin())
            {
                int x;
                if(bosshealthbar.Value > 0)
                {
                    x = playerhealtbar.Value - enemies[1].attackPower;
                    if (x >= 0)
                        playerhealtbar.Value = x;
                    else
                        playerhealtbar.Value = 0;
                }
                if (healthbar1.Value > 0)
                {
                    x = playerhealtbar.Value - enemies[0].attackPower; //dodac attack power i defense jako statystki label pod przeciwnikami
                    if (x >= 0)
                        playerhealtbar.Value = x;
                    else
                        playerhealtbar.Value = 0;
                }
                if (healthbar2.Value > 0)
                {
                    x = playerhealtbar.Value - enemies[1].attackPower;
                    if (x >= 0)
                        playerhealtbar.Value = x;
                    else
                        playerhealtbar.Value = 0;
                }
                if (healthbar3.Value > 0)
                {
                    x = playerhealtbar.Value - enemies[2].attackPower;
                    if (x >= 0)
                        playerhealtbar.Value = x;
                    else
                        playerhealtbar.Value = 0;
                }
                checkForWin();
            }
        }
        public static Image getSkillPic(string skillName)
        {
            switch(skillName)
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
                    return null;
            }
        }

        private void quest1claim_Click(object sender, EventArgs e)
        {
            if (!isFightActive)
            {
                claimQuest(1);
                questInitialization();
            }
            else
                info.Text = Texts.warning;
        }
        private void quest2claim_Click(object sender, EventArgs e)
        {
            if (!isFightActive)
            {
                claimQuest(2);
                questInitialization();
            }
            else
                info.Text = Texts.warning;
        }
        private void quest3claim_Click(object sender, EventArgs e)
        {
            if (!isFightActive)
            {
                claimQuest(3);
                questInitialization();
            }
            else
                info.Text = Texts.warning;
        }
        private void quest4claim_Click(object sender, EventArgs e)
        {
            if (!isFightActive)
            {
                claimQuest(4);
                questInitialization();
            }
            else
                info.Text = Texts.warning;
        }
        private void quest5claim_Click(object sender, EventArgs e)
        {
            if (!isFightActive)
            {
                claimQuest(5);
                questInitialization();
            }
            else
                info.Text = Texts.warning;
        }
        private void quest6claim_Click(object sender, EventArgs e)
        {
            if (!isFightActive)
            {
                claimQuest(6);
                questInitialization();
            }
            else
                info.Text = Texts.warning;
        }
        private void btn_fullList_Click(object sender, EventArgs e)
        {
            if (!isFightActive)
            {
                if (isListOpen)
                {
                    questList.Activate();
                }
                else
                {
                    questList = new QuestList();
                    questList.Show();
                    isListOpen = true;
                }
            }
            else
                info.Text = Texts.warning;
        }
        private void nextFight_btn_Click(object sender, EventArgs e)
        {
            info.Text = Texts.battle;
            temporaryHealth = (int)person.player.health;
            temporaryAttack = (int)person.player.attack;
            temporaryDefense = (int)person.player.defense;
            temporaryMagic = (int)person.player.magic;

            playerhealtbar.Maximum = temporaryHealth;
            playerhealtbar.Value = temporaryHealth;
            nextFight_btn.Hide();
            battleScenario();
        }
        private void run_pic_Click(object sender, EventArgs e)
        {
            info.Text = Texts.escape;
            coward = true;

            checkForWin();
        }
        private void guide_pic_Click(object sender, EventArgs e)
        {
            if (isGuideOpen)
            {
                guideBook.Activate();
            }
            else
            {
                GetMainWindowCords();
                guideBook = new GuideBook();
                guideBook.Location = new Point(x, y);
                guideBook.Show();
                isGuideOpen = true;
            }
        }
        private void skill1_pic_Click(object sender, EventArgs e)
        {
            attack(1);
            skill1_pic.BorderStyle = BorderStyle.Fixed3D;
            skill2_pic.BorderStyle = BorderStyle.None;
            skill3_pic.BorderStyle = BorderStyle.None;
        }
        private void skill2_pic_Click(object sender, EventArgs e)
        {
            attack(2);
            skill1_pic.BorderStyle = BorderStyle.None;
            skill2_pic.BorderStyle = BorderStyle.Fixed3D;
            skill3_pic.BorderStyle = BorderStyle.None;
        }
        private void skill3_pic_Click(object sender, EventArgs e)
        {
            attack(3);
            skill1_pic.BorderStyle = BorderStyle.None;
            skill2_pic.BorderStyle = BorderStyle.None;
            skill3_pic.BorderStyle = BorderStyle.Fixed3D;
        }
        private void boss_pic_Click(object sender, EventArgs e)
        {
            if(targeting && bosshealthbar.Value > 0)
            {
                int x = bosshealthbar.Value - currentSkill.attackPower;
                targeting = false;
                if (x >= 0)
                    bosshealthbar.Value = x;
                else
                    bosshealthbar.Value = 0;
                enemyTurn();
            }
        }
        private void enemy1_pic_Click(object sender, EventArgs e)
        {
            if (targeting && healthbar1.Value > 0)
            {
                int x = healthbar1.Value - currentSkill.attackPower;
                targeting = false;
                if (x >= 0)
                    healthbar1.Value = x;
                else
                    healthbar1.Value = 0;
                enemyTurn();
            }
        }
        private void enemy2_pic_Click(object sender, EventArgs e)
        {
            if (targeting && healthbar2.Value > 0)
            {
                int x = healthbar2.Value - currentSkill.attackPower;
                targeting = false;
                if (x >= 0)
                    healthbar2.Value = x;
                else
                    healthbar2.Value = 0;
                enemyTurn();
            }
        }
        private void enemy3_pic_Click(object sender, EventArgs e)
        {
            if (targeting && healthbar3.Value > 0)
            {
                int x = healthbar3.Value - currentSkill.attackPower;
                targeting = false;
                if (x >= 0)
                    healthbar3.Value = x;
                else
                    healthbar3.Value = 0;
                enemyTurn();
            }
        }

        private void MainWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            savePlayer();
            saveBattle();

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Quests>));
            using (FileStream fileStream = new FileStream("tasks.xml", FileMode.Create))
            {
                xmlSerializer.Serialize(fileStream, tasks);
            }

            Application.Exit();
        }
    }
}
