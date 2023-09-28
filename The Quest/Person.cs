using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace The_Quest
{
    [XmlInclude(typeof(System.Drawing.Bitmap))]
    public class Person
    {
        public Player player { get; set; }
        public Weapons weapon { get; set; }
        public Helmets helmet { get; set; }
        public Armor armor { get; set; }
        public Boots boots { get; set; }

        public Person()
        {
            player = new Player();
            weapon = new Weapons();
            helmet = new Helmets();
            armor = new Armor();
            boots = new Boots();
        }

        public Person(int classID)
        {
            player = new Player(classID);
            weapon = new Weapons(0, classID);
            helmet = new Helmets(0, classID);
            armor = new Armor(0, classID);
            boots = new Boots(0, classID);
        }
    }
}
