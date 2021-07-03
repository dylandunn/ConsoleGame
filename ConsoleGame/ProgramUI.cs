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


        //public enum Item { BrokenRumMug, SantasBelch, DudesBowlingBall, BeerGoggles, HolyHandGranade };

        // public List<Item> inventory = new List<Item>();

        public static Items brokenRumMug = new Items("Broken Rum Mug", 25);
        public static Items santasBelch = new Items("Santa's Belch", 75);
        public static Items    fffff = new Items("" , );
        public static Items    fffff = new Items("" , );
        public static Items fffff = new Items("", );




        public static Opponents jackSparrow = new Opponents(100, " Capt. Jack Sparrow", new List<Items> { brokenRumMug });




       // public static Rooms bar = new Rooms(
       //     "You have entered the bar\n" +
       //     "Head NORTH or EAST",
       //     new List<string> { "north", "east" });
       //
       // public static Rooms bar2 = new Rooms(
       //     "You're trying to exit the bar but Jack Sparrow challeges you to a dual\n",
       //     new List<string> { "north" },
       //     new List<Item> { Item.BrokenRumMug }
       //     );
       //
       // // Bad Santa Enconter Room
       // //1. “Is Grandma Spry?
       // //2. “Boy did someone drop you on your head?”
       // //3. “That's Right I forgot to take my pill.”
       // //4. on death, pass out? “And don't worry about us. We'll be fine.Let's get the Hell out of here Marcus.”
       // public static Rooms room2 = new Rooms(
       //     "You have now entered Room 2 \n" +
       //     "Head NORTH or WEST",
       //     new List<string> { "north", "west" },
       //     new List<Item> { Item.SantasBelch });
       //
       // // Frank the Tank Enconter Room
       // //1.On Defeat/Death ”We're going streaking!”
       // //2. “Fill it up again! Fill it up again! Once it hits your lips, it's so good! “
       // //3.“You tell anyone about this and I'll fucking kill you. I'm kidding, I'm kidding, we'll have him home by tonight.Okay, sweetie.”
       // //4.”Snoop! Snoop-a-loop!”
       // public static Rooms room3 = new Rooms(
       //     "You have now entered Room 3 \n" +
       //     "Head NORTH or EAST",
       //     new List<string> { "north", "west" },
       // new List<Item> { Item.DudesBowlingBall });



        public void Run()
        {
            Rooms currentRoom = bar;
            Console.WriteLine("        _                 _    _       _  ___                                    \n" +
                             @"      _| | _ _  _ _ ._ _ | |__<_>._ _ |/ | . \ _ _ ._ _  ___  ___  ___ ._ _  ___ \n" +
                             @"     / . || '_>| | || ' || / /| || ' |   | | || | || ' |/ . |/ ._>/ . \| ' |<_-< \n" +
                             @"     \___||_|  \___||_|_||_|_\|_||_|_|   |___/`___||_|_||_. ||___.\___/|_|_|/__/ \n" +
                              "                                                        <___>                    \n");

            Console.WriteLine("Welcome to Drunkin' Dungeons, a drunken text adventure that takes place in of all places of course a bar, go figure.\n" +
                              "a text based adventure game by Dylan Dunn and Colin Koestler\n" +
                              "\n" +
                              "\n" +
                              "\n" +
                              "As the player you will be provided with opportunities and encounters. As you play the game you will be asked to PRESS A KEY TO MAKE CHOICES.\n" +
                              " Example: Press 1 to head EAST\n" +
                                        "Press 2 To head WEST\n" +
                                        "Simple isn't it? \n");
            Console.WriteLine("Press ENTER to Continue");
            Console.Clear();

            Console.Clear();        //intro text
            Console.WriteLine("You walk in from the alleyway after having a rough conversation with your spouse about Christmas Presents.\n" +
                              "You hear the bars of one bourbon, one scotch, one beer blairing out over the bars speakers. This means only one thing.\n" +
                              "it's 2 O'clock and last call for alcohol. The bar has become a blurry, sort of foggy, and the partrons all look like drunken movie character rejects.\n" +
                              "The kind that you'd see hanging out in front of Mann's Chinese Theater; the kind that get into fights with tourist over the cost of taking a picture with them.\n" +
                              "They're all here even the way ovewieght Spiderman, who is arguing with the wall at this very moment.\n" +
                              "You're good you figured and you told your spouse you'd be home by 12, they are not happy, it's time to head home.\n" +
                              "Type 1 and head NORTH, towards the EXIT.\n");

            bool alive = true;
            while (alive)
            {
 

                Console.Clear();        //Navigation and story text
                Console.WriteLine("You have stumbled in front of the bar \n" +
                    "Which direction would you like to go? \n" +
                    "1. North\n" +
                    "2. East");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        Console.Clear();        //Jack Sparrow Text
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
                                            //Colin Text but make sure you keep in the string interpolation
                Console.WriteLine($"You have defeated Jack Sparrow! He dropped an {Item.BrokenRumMug} and it has been added to your inventory!");
                //Item names can also be changed, just make sure they're changed in every occurence
                inventory.Add(Item.BrokenRumMug);

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
                        Console.WriteLine($"You have summond the power of {Item.SantasBelch} and it has been added to your inventory!");
                        inventory.Add(Item.SantasBelch);
                        
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
                        $"1.{Item.BrokenRumMug}\n" +
                        $"2. Punch");
                }

            }





        }









//                 uuuuuuu
//             uu$$$$$$$$$$$uu
//          uu$$$$$$$$$$$$$$$$$uu
//         u$$$$$$$$$$$$$$$$$$$$$u
//        u$$$$$$$$$$$$$$$$$$$$$$$u
//       u$$$$$$$$$$$$$$$$$$$$$$$$$u
//       u$$$$$$$$$$$$$$$$$$$$$$$$$u
//       u$$$$$$"   "$$$"   "$$$$$$u
//       "$$$$"      u$u       $$$$"
//        $$$u       u$u       u$$$
//        $$$u      u$$$u      u$$$
//         "$$$$uu$$$   $$$uu$$$$"
//          "$$$$$$$"   "$$$$$$$"
//            u$$$$$$$u$$$$$$$u
//             u$"$"$"$"$"$"$u
//  uuu        $$u$ $ $ $ $u$$       uuu
// u$$$$        $$$$$u$u$u$$$       u$$$$
//  $$$$$uu      "$$$$$$$$$"     uu$$$$$$
//u$$$$$$$$$$$uu    """""    uuuu$$$$$$$$$$
//$$$$"""$$$$$$$$$$uuu   uu$$$$$$$$$"""$$$"
// """      ""$$$$$$$$$$$uu ""$"""
//           uuuu ""$$$$$$$$$$uuu
//  u$$$uuu$$$$$$$$$uu ""$$$$$$$$$$$uuu$$$
//  $$$$$$$$$$""""           ""$$$$$$$$$$$"
//   "$$$$$"                      ""$$$$""
//     $$$"                         $$$$"

//                            _          ___          _
//                          /`.`.  .-=""_; _ "" = -..','\
//                         |  \`.`#"'.-" ; "-.`"#'.',   |
//                          \`=>-Y ,(O_; _O  ) , Y -< '/
//                           `--'\#>-`-'_; _`-'-<#/`--'
//                            _ /   .:::::. _ \  _
//                       .- ' `-'i - _ |:::::|  `i - ' `-._
//                        '     .-j'  `:::::' `-j-.
//                            .'  `L'   "T"   `j -. `.
//                              ,-'|\.___:___./|  `
//                                 | `.____.' |
//                                 \           /               _..
//                                  `.       .'             .-##  `-.
//                                  |=`.___.'|           .' ##      `.
//                                 / _ =#`.       .#b  #               \
//                               .####..  .-._##".   .'###   \         |
//                              /###"""  /  ; `=##\,##  "#b  .j.      /
//                             /== --.. /    ;   \/ "##   " /  `-._.'
//                           /##==-._  |     ;   |   ##b   /
//                           |########= |  _..-d#b!    "#  /
//                           >###""  .=-+###" d###"`-._  .'
//                           |#"  ,d##  d###  ##"      `+.
//                           / d###  d###   #"           \
//    .d8#o.                /   ###"    ##     \          |
//  .' ###  `.              |   ##"     "#    .'`.        |
// /#b _# =# d\             \   "#      __.--'  ; `-.____/
//(###b \#8  ##\             `.___..---'|       ;   |
// "##8/ \" d###\         hjw   |=-""###|      ;    |
//   `"   \=##";              | 8#b  "#/     ;    /
//         |  =##|             ;####b= /      ;   |
//         |,#=,_|            /"""    |      ;    ;
//         |#####|            |_ -=##/      ;    |
//         |  ,-=|            |##b  /      ;     /
//         | _.d##|            ;###=/      ;     /
//         |#####|            | __  `.    ;    /.
//         |`"""" |           / d####=- \   ;    / b.
//         |  =##"\         /########= \ ;    |  ###-.
//          \",=___\    _.,/##""     -==\     | ####" `.
//           \####""8b#" #/   _d#8##b d"|    / ###"    #\
//            `#"  ###  ##|_d###""""8###|   / #"   _,"###|
//              `.##"  ###.\_.=   _____ /-.'#,  -=######/
//                `---"""   `-. __####.'.'         _d8'
//                           .- "   " -< (--'--._
//                         .'  .----._`.`-.            `.
//                         | ,'       \|   `-.           \
//                         \(        .'       `---....__.'
//                           `---"""'


//        _____________________
// _____.':                   :`._____
//(_____: : The ROLLING PIN!  : :_____)
//      `.:___________________:.'
//         \.'`.            :
//              `.          `.
//                \          :
//                 \__.       `.
//                     `.      :
//                      `.     `.
//                        `.   /
//                          `./

//                      You are a ninja!

// .pQQQQQp                ffpQQQQQQQQQQQQQQQQQQQQQQpp              QQQQQQQp.
//.QQQQQQQQpp                  ppQQQQQQQQQQQQQQQQQpp.               pPQQQQQQQQ.
//PQQQQQQQQQQQQQQQQQQQQQQ         `QQQp  , PQQQQQQQQ       pPQQQQQQQQQQQQQQQQQQQQ
//QQQQQQQQQQQQQQQQQQQQQQQQQQQQQpp  pQQp  pPQQQQQQP   ppPQQQQQQQQQQQQQQQQQQQQQQQQQ
//QQQQQQQQQQQQQQQQQQQQQQQQQQQQQPPPppQp  pPQQQQQQQP  pPQQQQQQQQQQQQQQQQQQQQQQQQQQQQ
//QQQQQQQQp              'pQQQQQQQQQQQQQQQQQQQQQPPPQQQPfp'                 'p,QQQQ
//QQfa'            AQp       'fpQQQQQQQQQQQQQQQQQQQQPfp'         Afp           fAQ
//QQQfa'.fAAQ'.    QQ, .fF p   hhQQQQQQQQQQQQQQQQQQQQh    hFF.   QQP  ; QQQ; AQQQ
//fFQQQQQQQQQQFp      'QQQQQQQQQQQQQQQQQQQQQQQQQQ fQQQQQQQQQPF.      pPQQQQQQQFP'
// pQQQQQQQQQQQQQQQppfQQQQQQf , QQQQQQQQQQQQQQQQQp pQQQQQQQQQQQPpppPQQQQQQQQQQP
//   pQQQQQQQQQQQQQQQQQ         PQQQQQQQQQQQQQQQPP  .pQQQQQQQQQQQQQQQQQQQQQQF

//                              "       _                      _     _        _       ___                                                \n" +
//                              "    __| | _ __  _   _  _ __  | | __(_) _ __ ( )     /   \ _   _  _ __    __ _   ___   ___   _ __   ___  \n" +
//                              "   / _` || '__|| | | || '_ \ | |/ /| || '_ \|/     / /\ /| | | || '_ \  / _` | / _ \ / _ \ | '_ \ / __| \n" +
//                              "  | (_| || |   | |_| || | | ||   < | || | | |     / /_// | |_| || | | || (_| ||  __/| (_) || | | |\__ \ \n" +
//                              "   \__,_||_|    \__,_||_| |_||_|\_\|_||_| |_|    /___,'   \__,_||_| |_| \__, | \___| \___/ |_| |_||___/ \n" +
//                              "                                                                         |___/ ");
//



////
//     _                      _     _        _      ___                                               
//  __| | _ __  _   _  _ __  | | __(_) _ __ ()     /   \ _ _  _ __    __ _   ___   ___   _ __   ___ 
// / _` || '__|| | | || '_ \ | |/ /| || '_ \|/    / /\ /| | | || '_ \  / _` | / _ \ / _ \ | '_ \ / __|
//| (_| || |   | |_| || | | ||   < | || | | |    / /_// | |_| || | | || (_| ||  __/| (_) || | | |\__ \
// \__, _||_|    \__, _||_| |_||_|\_\|_||_| |_| /___,'   \__,_||_| |_| \__, | \___| \___/ |_| |_||___/
//                                                                     |___/                          
//        _                 _    _       _  ___                                   
//      _| | _ _  _ _ ._ _ | |__<_>._ _ |/ | . \ _ _ ._ _  ___  ___  ___ ._ _  ___
//     / . || '_>| | || ' || / /| || ' |   | | || | || ' |/ . |/ ._>/ . \| ' |<_-<
//     \___||_|  `___||_|_||_\_\|_||_|_|   |___/`___||_|_|\_. |\___.\___/|_|_|/__/
//                                                        <___'                   
                                                                                                                              