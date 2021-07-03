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

       



        

        public static Items brokenRumMug = new Items("Broken Rum Mug", 25);
        public static Items santasBelch = new Items("Santa's Belch", 75);
        public static Items    fffff = new Items("" , );
        public static Items    fffff = new Items("" , );
        public static Items fffff = new Items("", );




        public static Opponents jackSparrow = new Opponents(100, " Capt. Jack Sparrow", new List<Items> { brokenRumMug });




      



        public void Run()
        {
           
            Console.WriteLine("        _                 _    _       _  ___                                    \n" +
                             @"      _| | _ _  _ _ ._ _ | |__<_>._ _ |/ | . \ _ _ ._ _  ___  ___  ___ ._ _  ___ \n" +
                             @"     / . || '_>| | || ' || / /| || ' |   | | || | || ' |/ . |/ ._>/ . \| ' |<_-< \n" +
                             @"     \___||_|  \___||_|_||_|_\|_||_|_|   |___/`___||_|_||_. ||___.\___/|_|_|/__/ \n" +
                              "                                                        <___>                    \n");
            Console.ReadLine();

            Console.WriteLine("Welcome to Drunkin' Dungeons, a drunken text adventure that takes place in of all places of course a bar, go figure.\n" +
                              "a text based adventure game by Dylan Dunn and Colin Koestler\n" +
                              "\n" +
                              "\n" +
                              "\n" +
                              "As the player you will be provided with opportunities and encounters. As you play the game you will be asked to PRESS A KEY TO MAKE CHOICES.\n" +
                              " Example: Press 1 to head EAST\n" +
                                        "Press 2 To head WEST\n" +
                                        "Simple isn't it? \n");
            Console.ReadLine();
            Console.WriteLine("Press ENTER to Continue");

            Console.ReadLine();
           
            
            

            Console.Clear();        ///Collin text
            Console.WriteLine("You've stumbled in front of the bar. ");

            //bool alive = true;
            //while (alive)
            

                ///// Intro Screen Will Go Here

                Console.Clear();        ///Collin text
                Console.WriteLine("You walk in from the alleyway after having a rough conversation with your spouse about Christmas Presents.\n" +
                              "You hear the bars of one bourbon, one scotch, one beer blairing out over the bars speakers. This means only one thing.\n" +
                              "it's 2 O'clock and last call for alcohol. The bar has become a blurry, sort of foggy, and the partrons all look like drunken movie character rejects.\n" +
                              "The kind that you'd see hanging out in front of Mann's Chinese Theater; the kind that get into fights with tourist over the cost of taking a picture with them.\n" +
                              "They're all here even the way ovewieght Spiderman, who is arguing with the wall at this very moment.\n" +
                              "You're good you figured and you told your spouse you'd be home by 12, they are not happy, it's time to head home.\n" +
                              "Type 1 and head NORTH, towards the EXIT.\n" +
                                "1. North\n" +
                                "2. East");
            bool exit3 = false;

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
            while (exit3)
            {
                switch (input)
                {
                    case "1":
                        Console.Clear();        //Jack Sparrow Text
                        Console.WriteLine("You reached a door, but you incounter Jack Sparrow and he's ready to fight"); ;
                        exit3 = true;
                        break;


                    case "2":
                        Console.Clear();
                        Console.WriteLine("You hit a wall. Press enter to try again");
                        Console.ReadLine();
                        exit3 = true;
                        break;


                    default:
                        Console.Clear();
                        Console.WriteLine("You seem drunk. Press Enter to try again and choose a direction.");
                        Console.ReadLine();

                        break;

                }
            }

                //Collin Text
                Console.WriteLine($"\n\n\nQUICK Choose an attack!\n\n\n" +
                    // Collin Text for Attacks, Will Call Them in Switch Case
                    "\n\n\n 1: Punch\n" +
                    "\n\n\n 2: Kick \n" +
                    "\n\n\n 3: Run Away \n");

                bool exit = false;
                while (exit)
                {


                    string input2 = Console.ReadLine();
                    switch (input2)
                    {
                        case "1":
                            exit = true;
                            break;
                        case "2":
                            exit = true;
                            break;
                        case "3":
                            exit = true;
                            break;
                        default:
                            Console.WriteLine("Please enter a valid command.");
                            break;

                    }
                    
                }

                Console.Clear();

                //Collin Text but make sure you keep in the string interpolation
                Console.WriteLine($"You have defeated Jack Sparrow! He dropped an {Item.item1} and it has been added to your inventory!");
                Console.ReadLine();

                                            //Colin Text but make sure you keep in the string interpolation
                Console.WriteLine($"You have defeated Jack Sparrow! He dropped an {Item.BrokenRumMug} and it has been added to your inventory!");

                //Item names can also be changed, just make sure they're changed in every occurence
                inventory.Add(Item.BrokenRumMug);

                Console.Clear();







                Console.WriteLine("You open the door, it leads to a room upstairs. You see two Doors, which one would you like to enter?\n" +
                    "1. Left door\n" +
                    "2. Right door\n");

                string input3 = Console.ReadLine();
                bool exit2 = false;
                
                bool foundItem = true;
                while (exit2)
                {



                    switch (input3)
                    {
                        case "1":
                            Console.Clear();
                            Console.WriteLine($"You have summond the power of {Item.item2} and it has been added to your inventory!");
                            inventory.Add(Item.item2);
                            exit2 = true;

                            break;
                        case "2":
                            Console.Clear();      //Collin Text
                            Console.WriteLine("You walk in on Bad Santa and he's in a bad mood");
                            foundItem = false;
                            exit2 = true;
                            break;
                        default:
                         
                            Console.WriteLine("That is not an option. ");

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
                }
                if (foundItem == false)
                {
                    string input4 = Console.ReadLine();
                    Console.WriteLine($"Choose an attack!\
                        $"1.{Item.item1}\n" +
                        $"2. {Item.item2}\n" +
                        $"3. Kick");
                    switch (input4)
                    {
                        case "1":
                            break;
                        case "2":
                            break;
                        case "3":
                            break;
                        default:
                            Console.WriteLine("Enter a valid command. Press enter to continue.");
                        break; 

                            //Question on how to get code back on track


                    }
                    Console.ReadLine();
                    Console.WriteLine("You continue through to try and find an exit. You see Two doors, Which would you like to go through?\n" +
                        "1. Left\n" +
                        "2. Right");
                    bool foundItem2 = true;
                    string input5 = Console.ReadLine();
                    switch (input5)
                    {
                        case "1":
                            Console.Clear();
                            Console.WriteLine($"You find a {Item.item4} lying around. This will surley come in handy and will be added to your inventory!");
                            inventory.Add(Item.item4);
                            break;
                        case "2":
                            Console.Clear();
                            Console.WriteLine("You run into the dude and his bowling ball. Fight!");
                            foundItem2 = false;
                            break;
                        default:
                            Console.WriteLine("Please enter a vaild command. Press enter to continue.");
                            break;

                    }
                    if (foundItem2 == false)
                    {
                        string input6 = Console.ReadLine();
                        Console.WriteLine($"Choose an attack!\n" +
                            $"1.{Item.item2}\n" +
                            $"2. {Item.item2}\n" +
                            $"3. {Item.item3}");
                        switch (input6)
                        {
                            case "1":
                                break;
                            case "2":
                                break;
                            case "3":
                                break;
                            default:
                                Console.WriteLine("Please enter a valid command");
                                break;

                                ////// Fight Code

                        }
                        Console.ReadKey();
                        Console.WriteLine("You find one more staircase. You're on the roof now... Final boss Jackie Chan appears. This is it.");
                        string input7 = Console.ReadLine();
                        Console.WriteLine($"Choose an attack!!\n" +
                            $"1. {Item.item1}\n" +
                            $"2. {Item.item2}\n" +
                            $"3. {Item.item3}\n" +
                            $"4. {Item.item4}");
                        switch (input7)
                        {
                            case "1":
                                break;
                            case "2":
                                break;
                            case "3":
                                break;
                            case "4":
                                break;
                            default:
                                Console.WriteLine("Please enter a valid command. Press enter to continue.");
                                break;
                        }

                        Console.Clear();
                        string input8 = Console.ReadLine();
                        Console.WriteLine("After taking down the final boss, you pass into one more room. 3 doors this time. Choose wisley!\n" +
                            "1. Door 1\n" +
                            "2. Door 2\n" +
                            "3. Door 3");
                        switch (input8)
                        {
                            case "1":
                                //Cheese Screen 1
                                break;
                            case "2":
                                // Cheese Screen 2
                                break;
                            case "3":
                                // Cheese screen 3
                                break;
                        }
                        Console.Clear();
                        Console.WriteLine("Thanks for playing!");

                    }

=======
                        $"1.{Item.BrokenRumMug}\n" +
                        $"2. Punch");

                }

            
            





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
                                                                                                                              