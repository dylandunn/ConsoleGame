using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame
{
    public class OpponentLibrary
    {
        public string Name { get; set; }

        public OpponentLibrary() { }

        public OpponentLibrary(string name)
        {
            Name = name;
        }
    }
   
}
