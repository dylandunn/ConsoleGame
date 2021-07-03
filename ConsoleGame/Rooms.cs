using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ConsoleGame.ProgramUI;

namespace ConsoleGame
{
    public class Rooms
    {

        public string TextPrompt { get; }
        public List<string> Directions { get; }
        public List<Items> Items { get; }
       

        public Rooms( string textPrompt, List<string> directions, List<Items> items)
        {
            TextPrompt = textPrompt;
           
            Directions = directions;

            Items = items;
        }

        
    }
}
