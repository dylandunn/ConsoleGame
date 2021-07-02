using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame
{
    // This is my change -Dylan
    public class ProgramUI
    {
        public enum Item { item1, item2, item3, item4 };

        public List<Item> inventory = new List<Item>();


        public static Rooms bar = new Rooms(
            "You have entered the bar\n" +
            "Head NORTH to exit",
            new List<string> { "north" },
            new List<Item> { });

        public static Rooms bar2 = new Rooms(
            "You're trying to exit the bar but Jack Sparrow challeges you to a dual\n",
            new List<string> { "north" },
            new List<Item> { Item.item1 }
            );

        // Bad Santa Enconter Room
        public static Rooms room2 = new Rooms(
            "You have now entered Room 2 \n" +
            "Head NORTH or WEST",
            new List<string> { "north", "west" },
            new List<Item> { Item.item2 });

        // Frank the Tank Enconter Room
        public static Rooms room3 = new Rooms(
            "You have now entered Room 3 \n" +
            "Head NORTH or EAST",
            new List<string> { "north", "west" },
        new List<Item> { Item.item3 });



        public void Run()
        {

            Console.Clear();        ///Collin text
            Console.WriteLine("You've stumbled in front of the bar. ");

            bool alive = true;
            while (alive)
            {
                ///// Intro Screen Will Go Here

                Console.Clear();        ///Collin text
                Console.WriteLine("You have stumbled in front of the bar \n" +
                    "Which direction would you like to go? \n" +
                    "1. North\n" +
                    "2. East");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        Console.Clear();        ///Collin text
                        Console.WriteLine("You reached a door, but you incounter Jack Sparrow and he's ready to fight"); ;
                        break;
                       

                    case "2":
                        Console.Clear();
                        Console.WriteLine("You hit a wall. Press enter to try again");
                        Console.ReadLine();

                        continue;


                    default:
                        Console.Clear();
                        Console.WriteLine("You seem drunk. Press Enter to try again and choose a direction.");
                        Console.ReadLine();

                        continue;

                }


                                                   //Collin Text
                Console.WriteLine($"\n\n\nQUICK Choose an attack!\n\n\n" +
                    // Collin Text for Attacks, Will Call Them in Switch Case
                    "\n\n\n 1: Attack 1\n" +
                    "\n\n\n 2: Attack 2\n" +
                    "\n\n\n 3: Attack 3\n");

                string input2 = Console.ReadLine();
                switch (input2)
                {

                }

                Console.Clear();
                                            //Collin Text but make sure you keep in the string interpolation
                Console.WriteLine($"You have defeated Jack Sparrow! He dropped an {Item.item1} and it has been added to your inventory!");
                //Item names can also be changed, just make sure they're changed in every occurence
                inventory.Add(Item.item1);

                Console.Clear();

                Console.WriteLine("You open the door, it leads to a room upstairs. You see two Doors, which one would you like to enter?\n" +
                    "1. Left door\n" +
                    "2. Right door\n");

                string input3 = Console.ReadLine();
                bool foundItem = true;
                switch(input3)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine($"You have summond the power of {Item.item2} and it has been added to your inventory!");
                        inventory.Add(Item.item2);
                        
                        break;
                    case "2":
                        Console.Clear();      //Collin Text
                        Console.WriteLine("You walk in on Bad Santa and he's in a bad mood");
                        foundItem = false;
                        break;
                    default:
                        Console.WriteLine("That is not an option");
                        continue;
                }
                if (foundItem==false)
                {
                    Console.WriteLine($"Choose an attack!\n" +
                        $"1.{Item.item1}\n" +
                        $"2. Punch");
                }

            }





        }







    }
}









////
//     _                      _     _        _      ___                                               
//  __| | _ __  _   _  _ __  | | __(_) _ __ ()     /   \ _ _  _ __    __ _   ___   ___   _ __   ___ 
// / _` || '__|| | | || '_ \ | |/ /| || '_ \|/    / /\ /| | | || '_ \  / _` | / _ \ / _ \ | '_ \ / __|
//| (_| || |   | |_| || | | ||   < | || | | |    / /_// | |_| || | | || (_| ||  __/| (_) || | | |\__ \
// \__, _||_|    \__, _||_| |_||_|\_\|_||_| |_| /___,'   \__,_||_| |_| \__, | \___| \___/ |_| |_||___/
//                                                                     |___/                          
