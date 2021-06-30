using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame
{

    public class ProgramUI
    {
        public static Rooms bar = new Rooms(
            "You have entered the bar\n" +
            "Head NORTH or EAST",
            new List<string> { "north", "east" });

        // Bad Santa Enconter Room
        public static Rooms room2 = new Rooms(
            "You have now entered Room 2 \n" +
            "Head NORTH or WEST",
            new List<string> { "north", "west" });

        // Frank the Tank Enconter Room
        public static Rooms room3 = new Rooms(
            "You have now entered Room 3 \n"+
            "Head NORTH or EAST",
            new List<string> { "north", "west" });



        public void Run()
        {
            Rooms currentRoom = bar;
            Console.Clear();
            Console.WriteLine("You've stumbled in front of the bar. Type HEAD NORTH to enter");

            bool alive = true;
            while (alive)
            {
                bool level1 = true;
                
                string command = Console.ReadLine().ToLower();
                Console.Clear();
                Console.WriteLine(currentRoom.TextPrompt);

                    if (command.StartsWith("Head") || command.StartsWith("Go"))
                    {
                        if (command.Contains("North"))
                        {
                            currentRoom = bar;
                        }
                        else if (command.Contains("east"))
                        {
                            Console.WriteLine("You can't go that way.");
                        }
                        else
                        {
                            Console.WriteLine("Head where???");
                        }
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
