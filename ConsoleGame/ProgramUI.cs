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
        public static Items santasBelch = new Items("Santa's Belch", 50);
        public static Items dudesBowlingBall = new Items(" Dudes' Bowling Ball", 1500);
        public static Items beerGoggles = new Items("Franks' Beer Goggles Sling Shot", 75);

        public static Opponents jackSparrow = new Opponents(100, " Capt. Jack Sparrow", new List<Items> { brokenRumMug });
        public static Opponents badSanta = new Opponents(150, "Bad Santa", new List<Items> { santasBelch });
        public static Opponents dudeLabowski = new Opponents(225, " The 'Dude' Labowski", new List<Items> { dudesBowlingBall });
        public static Opponents frankTheTank = new Opponents(275, " Frank the Tank", new List<Items> { beerGoggles });
        public static Opponents drunkenMaster = new Opponents(1100, "Drunken Master", new List<Items> { });

        public void Run()
        {
            //Points Calculator

            //           public static int Sum(int PlayerPoints, int damageTaken)
            //           {
            //               int total;
            //               total = PlayerPoints - damageTaken;
            //               return total;
            //           }
            //
            //           public static void main()
            //           {
            //               Console.WriteLine($"{player.Name}, Your FINAL SCORE is: {0} \n"), sum(PlayerPoints,damageTaken));
            //           }
            //




            Player player = new Player();
            player.PlayerPoints = 1500;


            //Intro Screen
            Console.WriteLine("        _                 _    _       _  ___                                    \n" +
                             @"      _| | _ _  _ _ ._ _ | |__<_>._ _ |/ | . \ _ _ ._ _  ___  ___  ___ ._ _  ___ \n" +
                             @"     / . || '_>| | || ' || / /| || ' |   | | || | || ' |/ . |/ ._>/ . \| ' |<_-< \n" +
                             @"     \___||_|  \___||_|_||_|_\|_||_|_|   |___/`___||_|_||_. ||___.\___/|_|_|/__/ \n" +
                              "                                                        <___>                    \n");

            Console.WriteLine("Welcome to Drunkin' Dungeons, a drunken text adventure that takes place in of all places of course a bar, go figure.\n" +
                              "a text based adventure game by Dylan Dunn and Colin Koestler\n");
            Console.WriteLine("What are you Called NumbSkull?\n");
            player.Name = Console.ReadLine();

            Console.WriteLine($"{player.Name}, you will be provided with opportunities and encounters. As you play the game you will be asked to PRESS A KEY TO MAKE CHOICES.\n" +
                              " Example: Press 1 to head EAST\n" +
                                        "Press 2 To head WEST\n" +
                                        "Simple isn't it? \n");
            Console.ReadLine();
            Console.WriteLine("Press ENTER to Continue");

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

            Console.Clear();

            bool alive = true;
            while (alive)
            {


                bool exit3 = false;
                string input = Console.ReadLine();
                while (exit3)
                {
                    switch (input)
                    {
                        case "1":
                            Console.Clear();        //Jack Sparrow Text
                            Console.WriteLine("You stuble towards the exit. The room appears to be shifting sideways a little. \n" +
                            "All of a sudden a poorly costumed Capt. Jack Sparrow comes out of nowhere. Muttering - Nobody move! I dropped me Brain!, and I've got a jar of dirt.\n" +
                            "You stumble and bump into him he sreams at you SWAB!. As you fall backwards to the floor.");
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
                            Console.WriteLine($"{player.Name}, you appear to be more than slightly drunk. Press Enter to try again and choose a direction.");
                            Console.ReadLine();
                            break;
                    }

                    //Jack Sparrow
                    Console.WriteLine($"\n\n\n Capt. Jack looks to be piss drunk, just like in the movies you think, He's moving towards you. You feel threatened what do you do?\n\n\n");
                        // Collin Text for Attacks, Will Call Them in Switch Case

                                        //100pts    K.O.
                    while (jackSparrow.BossPoints > 0)
                    {
                        Console.WriteLine("\n\n\n 1: Punch\n" +
                                          "\n\n\n 2: Kick \n");

                        //FIGHTING GOES HERE
                        string input2 = Console.ReadLine().ToLower();
                        Console.Clear();
                        if (input2.StartsWith("1"))
                        {
                            Console.WriteLine("Your KICK does 35 points of damage!");
                            jackSparrow.BossPoints -= 35;
                            Console.Clear();
                        }
                        else if (input2.StartsWith("2"))
                        {                       
                        Console.WriteLine("Your Punch does 25 points of damage!");
                            jackSparrow.BossPoints -= 25;
                            Console.Clear();

                        }
                        else
                        {
                            Console.WriteLine("Don't know much about what you are doing huh? Simple option is to press 1 or 2 on your KEYBOARD.");
                            Console.Clear();
                        }

                    }

                }

                Console.Clear();

                //Collin Text but make sure you keep in the string interpolation
                Console.WriteLine($"Defeated, Jack Sparrow slumps to the floor passed out! As he slides to the floor he drops a Broken Rum Mug and it has been added to your inventory!\n"+
                    $"You've been rewarded with {jackSparrow.BossPoints} points");
                Console.ReadLine();

                jackSparrow.Items.Remove(brokenRumMug);
                player.Items.Add(brokenRumMug);
                player.PlayerPoints += jackSparrow.BossPoints;
                Console.WriteLine($"Your SCORE is:{player.PlayerPoints}");
                Console.WriteLine("Press ENTER to continue.");
                Console.ReadKey();

                Console.Clear();





                //Bad Santa

                Console.WriteLine("Later and still drunk. You find yourself laying on a heap of Elvis Jumpsuit costumes.\n" +
                    "You look around and find that you ended up on top of some stairs.\n" +
                    "Welcome to Level 2!\n" +
                    "You see two Doors, which one would you like to enter?\n" +
                    "1. The Door on the LEFT?\n" +
                    "2. The Door On the RIGHT?\n");

                while (badSanta.BossPoints > 0)
                    Console.WriteLine($"\n\n\n You enter the room and see what appears to be an Angry, no, a Bad Santa look-a-like.\n" +
                         "he's even complete with Bourbon Breath just like in the movies you think, He's moving towards you.\n" +
                         " You feel threatened what do you do?\n\n\n");

                {
                    Console.WriteLine($"Choose an attack!\n" +
                        $"1. Throw Broken Rum Mug\n" +
                        $"2. Punch\n" +
                        $"3. Kick\n");

                    string input3 = Console.ReadLine().ToLower();
                        Console.Clear();
                        if (input3.StartsWith("1"))
                        {
                            Console.WriteLine("Broken Rum Mug does 25 points of damage!");
                            badSanta.BossPoints -= brokenRumMug.ItemDamage;
                            Console.Clear();
                        }
                        else if (input3.StartsWith("2"))
                        {
                            Console.WriteLine("Your Punch does 35 points of damage!");
                            badSanta.BossPoints -= 35;
                            Console.Clear();

                        }
                        else if (input3.StartsWith("3"))
                        {
                        Console.WriteLine("Your Kick does 55 points of damage!");
                        badSanta.BossPoints -= 55;
                        Console.Clear();

                        }
                        else
                        {
                            Console.WriteLine("Don't know much about what you are doing huh? Simple option is to press 1, 2, or 3 on your KEYBOARD.");
                            Console.Clear();
                        }

                    }


                    Console.ReadLine();
                    Console.WriteLine("You finally get Bad Santa to submit, as he leaves the room he yells, don't worry about us. We'll be fine. Let's get the Hell out of here Marcus!\n" +
                        "You think that you see an elf appear out of nowhere and walk right out the door with Bad Santa. Did I really see that? You think to yourself.\n" +
                        $"You've been rewarded with {badSanta.BossPoints} points\n");

                    badSanta.Items.Remove(santasBelch);
                    player.Items.Add(santasBelch);
                    player.PlayerPoints += badSanta.BossPoints;
                    Console.WriteLine($"Your SCORE is:{player.PlayerPoints}");
                    Console.WriteLine("Press ENTER to continue.");
                    Console.ReadKey();

                    Console.Clear();

                    Console.WriteLine("As you look around the room you see two more doors one to the left and one to the right.\n"+
                        "Which would you like to go through?\n"+
                        "1. The Door on the LEFT\n" +
                        "2. The Door on the RIGHT");

                //Dude
                Console.WriteLine("As you move forward you hear the sound of a bowling ball hitting pins you remember that the bar once had a two bowling lanes.\n" +
                                   "You enter the room and see the Dude, setting up to knock down some pins.\n" +
                                    "You see two Doors, which one would you like to enter?\n" +
                                    "1. The Door on the LEFT?\n" +
                                    "2. The Door On the RIGHT?\n");
                while (dudeLabowski.BossPoints > 0)
            {
                Console.WriteLine($"How would you like to attack?\n" +
                    $"1. Throw Broken Rum Mug\n" +
                    $"2. Deploy Santas's Belch\n" +
                    $"3. Kick\n");

                string input4 = Console.ReadLine().ToLower();
                Console.Clear();
                if (input4.StartsWith("1"))
                {
                    Console.WriteLine("Broken Rum Mug does 25 points of damage!");
                    dudeLabowski.BossPoints -= brokenRumMug.ItemDamage;
                    Console.Clear();
                }
                else if (input4.StartsWith("2"))
                {
                    Console.WriteLine("Your Santas Belch does 50 points of damage!");
                    dudeLabowski.BossPoints -= santasBelch.ItemDamage;
                    Console.Clear();

                }
                else if (input4.StartsWith("3"))
                {
                    Console.WriteLine("Your Kick does 45 points of damage!");
                    dudeLabowski.BossPoints -= 45;
                    Console.Clear();

                }
                else
                {
                    Console.WriteLine("Don't know much about what you are doing huh? Simple option is to press 1, 2, or 3 on your KEYBOARD.");
                    Console.Clear();
                }

            }
                Console.ReadLine();
                Console.WriteLine("After a while the 'Dude', as he strolls out of the room he looks at you and says, sooner or later you are going to have to face the fact that you’re a moron.\n" +
                    "You think yo yourself, you know the Dude may be right.\n" +
                    $"You've been rewarded with {dudeLabowski.BossPoints} points\n");

                dudeLabowski.Items.Remove(dudesBowlingBall);
                player.Items.Add(dudesBowlingBall);
                player.PlayerPoints += dudeLabowski.BossPoints;
                Console.WriteLine($"Your SCORE is:{player.PlayerPoints}");
                Console.WriteLine("Press ENTER to continue.");
                Console.ReadKey();

                Console.Clear();

                //CHOOSE LAST 2 DOORS

                Console.WriteLine("As you look around the room you see two more doors one to the left and one to the right.\n" +
                                  "Which would you like to go through?\n");
                                  "1. The Door on the LEFT\n" +
                                  "2. The Door on the RIGHT");


                //FRANK THE TANK FIGHT
                while (frankTheTank.BossPoints > 0)
                {
                    Console.WriteLine($"How would you like to attack Frank The Tank?\n" +
                        $"1. Throw Broken Rum Mug\n" +
                        $"2. Deploy Santas's Belch\n" +
                        $"3. Use Dudes Bowling Ball\n");

                    string input5= Console.ReadLine().ToLower();
                    Console.Clear();
                    if (input5.StartsWith("1"))
                    {
                        Console.WriteLine("Broken Rum Mug does 25 points of damage!");
                        frankTheTank.BossPoints -= brokenRumMug.ItemDamage;
                        Console.Clear();
                    }
                    else if (input5.StartsWith("2"))
                    {
                        Console.WriteLine("Your Santas Belch does 50 points of damage!");
                        frankTheTank.BossPoints -= santasBelch.ItemDamage;
                        Console.Clear();

                    }
                    else if (input5.StartsWith("3"))
                    {
                        Console.WriteLine("The Dudes Bowling ball hits Frank for a whopping 1500 points of damage!");
                        frankTheTank.BossPoints -= dudesBowlingBall.ItemDamage;
                        Console.Clear();

                    }
                    else
                    {
                        Console.WriteLine("Don't know much about what you are doing huh? Simple option is to press 1, 2, or 3 on your KEYBOARD.");
                        Console.Clear();
                    }

                }
                Console.ReadLine();
                Console.WriteLine("A defeated Frank the Tank starts to pull off his clothes, and heads for the door screaming *We're going streaking! in the quad!*\n" +
                    "As he runs past he drops a pair of Beer Goggles on the floor, with a bag of beer caps. You think about it and feel that it'd make a perfect slingshot.\n" +
                    "Beer Goggles has been added to your inventory.\n" +
                    $"You've been rewarded with {frankTheTank.BossPoints} points\n");

                frankTheTank.Items.Remove(beerGoggles);
                player.Items.Add(beerGoggles);
                player.PlayerPoints += frankTheTank.BossPoints;
                Console.WriteLine($"Your SCORE is:{player.PlayerPoints}");
                Console.WriteLine("Press ENTER to continue.");
                Console.ReadKey();

                Console.Clear();


                Console.WriteLine("Frank runs out of the room screaming *We're going streaking! in the Quad!*\n" +
                    "A Jackie Chan look-a-like in sprints into the room ready to fight\n" +
                    "He's wasted and claims he can fight in the style of the style of Drunken Master.");

                //JACKIE CHAN FIGHT
                while (drunkenMaster.BossPoints > 0)
                {
                    Console.WriteLine($"How would you like to attack Jackie Chan/Drunken Master?\n" +
                        $"1. Throw Broken Rum Mug\n" +
                        $"2. Deploy Santas's Belch\n" +
                        $"3. Use Dudes Bowling Ball\n" +
                        $"4. Shoot Beer Goggles");

                    string input5 = Console.ReadLine().ToLower();
                    Console.Clear();
                    if (input5.StartsWith("1"))
                    {
                        Console.WriteLine("Broken Rum Mug does 25 points of damage!");
                        drunkenMaster.BossPoints -= brokenRumMug.ItemDamage;
                        Console.Clear();
                    }
                    else if (input5.StartsWith("2"))
                    {
                        Console.WriteLine("Your Santas Belch does 50 points of damage!");
                        drunkenMaster.BossPoints -= santasBelch.ItemDamage;
                        Console.Clear();

                    }
                    else if (input5.StartsWith("3"))
                    {
                        Console.WriteLine("The Dudes Bowling ball hits Frank for a whopping 1500 points of damage!");
                        drunkenMaster.BossPoints -= dudesBowlingBall.ItemDamage;
                        Console.Clear();

                    }
                    else
                    {
                        Console.WriteLine("Don't know much about what you are doing huh? Simple option is to press 1, 2, or 3 on your KEYBOARD.");
                        Console.Clear();
                    }

                }
                Console.ReadLine();
                Console.WriteLine("A defeated Frank the Tank starts to pull off his clothes, and heads for the door screaming *We're going streaking! in the quad!*\n" +
                    "As he runs past he drops a pair of Beer Goggles on the floor, with a bag of beer caps. You think about it and feel that it'd make a perfect slingshot.\n" +
                    "Beer Goggles has been added to your inventory.\n" +
                    $"You've been rewarded with {drunkenMaster.BossPoints} points\n");

                player.PlayerPoints += drunkenMaster.BossPoints;
                Console.WriteLine($"Your SCORE is:{player.PlayerPoints}");
                Console.WriteLine("Press ENTER to continue.");
                Console.ReadKey();

                Console.Clear();


                Console.WriteLine("Frank runs out of the room screaming *We're going streaking! in the Quad!*  falls Jackie Chan sprints into the room ready to fight");



            }  //DONT GO PAST

            //string input6 = Console.ReadLine();
            Console.WriteLine($"Choose an attack!\n" +
                            $"1. {brokenRumMug} Throw Broken Rum Mug\n" +
                            $"2. {santasBelch} Deploy Santa's Belch\n" +
                            $"3. {dudesBowlingBall} Use Dudes Bowling Ball\n");

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
                        Console.WriteLine("You find one more staircase. You're on the top floor now.  Final boss Jackie Chan appears. This is it.");
                        string input7 = Console.ReadLine();
            Console.WriteLine($"Choose an attack!!\n" +
                $"1. {brokenRumMug} Throw Broken Rum Mug\n" +
                $"2. {santasBelch} Deploy Santa's Belch\n" +
                $"3. {dudesBowlingBall} Use Dudes Bowling Ball\n");

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
                                Console.WriteLine("Drunks are impossible. Please enter a valid command choice. Press enter to continue.");
                                break;
                        }

                        Console.Clear();
                        string input8 = Console.ReadLine();
                        Console.WriteLine("After taking down the Drunken Master, you see three more doors. Could this be freedom from this drunken mess? Choose wisley!\n" +
                            "1. Door 1\n" +
                            "2. Door 2\n" +
                            "3. Door 3");

                        switch (input8)
                        {
                            case "1":
                                Console.WriteLine("You are a Ninja!, You wake up on the roof as the sun comes up. "); //Cheese 1
                                Console.WriteLine($"Your SCORE is:{player.PlayerPoints}");
                            break;
                            case "2":
                                Console.WriteLine("Rolling Pin! You wake up on the roof and find your spouse standing over you. They seem angry, but relived that you are alive.\n" +
                                    "You wonder if you're in for it when you get to the car. They say nothing and drop the issue. You got lucky, Draw.");//Cheese 2
                                Console.WriteLine($"Your SCORE is:{player.PlayerPoints}");
                            break;
                            case "3":
                                Console.WriteLine("TIGER! For some unknown reason there is a tiger behind the door!");
                                Console.WriteLine($"Your SCORE is:{player.PlayerPoints}");
                                Console.WriteLine("You will go down in history as the poor drunken misfit that was killed in a freak tiger accident, in of all places a bar.\n");//Cheese 3

                            break;
                        }

                        Console.Clear();

                        Console.WriteLine("Press ENTER to continue.");
                        Console.ReadKey();

                        Console.Clear();
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
                                                                                                                              