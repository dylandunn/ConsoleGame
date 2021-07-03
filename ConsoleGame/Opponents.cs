using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame
{
    public class Opponents
    {
        public int BossPoints { get; set; }
        public string Name { get; }
        public List<Items> Items { get; }


        public Opponents(int bossPoints, string name, List<Items> items)
        {
            Name = name;
            Items = items;
            BossPoints = bossPoints;
        }


    }
}
