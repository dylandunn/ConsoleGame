using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame
{
    public class Rooms
    {

        public string TextPrompt { get; }
        public List<string> Directions { get; }
       

        public Rooms( string textPrompt, List<string> directions)
        {
            TextPrompt = textPrompt;
           
            Directions = directions;
        }

        
    }
}
