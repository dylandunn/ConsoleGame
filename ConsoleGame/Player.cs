using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame
{
    public class Player
    {
        public int PlayerPoints { get; set; }
        public string Name { get; set; }
        public List<Items> Items { get; }

        public Player()
        {

        }

        public Player(int playerPoints, string name, List<Items> items)
        {
            PlayerPoints = playerPoints;
            Name = name;
            Items = items;
        }

    }

}


