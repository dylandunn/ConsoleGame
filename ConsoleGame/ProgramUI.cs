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
        // Jack Sparrow Encounter(No Mc Lovin Encounter Move North only)Capt. Jack Sparrow:
        //1. “This is the day you will always remember as the day you almost caught Captain Jack Sparrow.”
        //2. “Nobody move! I dropped me Brain!”
        //3. “I've got a jar of dirt!” 
        //4. “Crazy people don’t know they’re crazy. I know I’m crazy, therefore I’m not crazy, isn’t that crazy?”
        public static Rooms bar = new Rooms(
            "You have re-entered the bar\n" +
            "Head NORTH or EAST",
            new List<string> { "north", "east" });

        // Bad Santa Enconter Room
        //1. “Is Grandma Spry?
        //2. “Boy did someone drop you on your head?”
        //3. “That's Right I forgot to take my pill.”
        //4. on death, pass out? “And don't worry about us. We'll be fine.Let's get the Hell out of here Marcus.”
        public static Rooms room2 = new Rooms(
            "You have now entered Room 2 \n" +
            "Head NORTH or WEST",
            new List<string> { "north", "west" });

        // Frank the Tank Enconter Room
        //1.On Defeat/Death ”We're going streaking!”
        //2. “Fill it up again! Fill it up again! Once it hits your lips, it's so good! “
        //3.“You tell anyone about this and I'll fucking kill you. I'm kidding, I'm kidding, we'll have him home by tonight.Okay, sweetie.”
        //4.”Snoop! Snoop-a-loop!”
        public static Rooms room3 = new Rooms(
            "You have now entered Room 3 \n" +
            "Head NORTH or EAST",
            new List<string> { "north", "west" });



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
            Console.WriteLine("You walk in from the alleyway after having a rough conversation with your spouse about Christmas Presents.\n" +
                              "You hear the bars of one bourbon, one scotch, one beer blairing out over the bars speakers. This means only one thing.\n" +
                              "it's 2 O'clock and last call for alcohol. The bar has become a blurry, sort of foggy, and the partrons all look like drunken movie character rejects.\n" +
                              "The kind that you'd see hanging out in front of Mann's Chinese Theater; the kind that get into fights with tourist over the cost of taking a picture with them.\n" +
                              "They're all here even the way ovewieght Spiderman, who is arguing with the wall at this very moment.\n" +
                              "You're good you figured and you told your spouse you'd be home by 12, they are not happy, it's time to head home.\n" +
                              "Type 1 and head NORTH, towards the EXIT.\n");


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

//        _                 _    _       _  ___                                   
//      _| | _ _  _ _ ._ _ | |__<_>._ _ |/ | . \ _ _ ._ _  ___  ___  ___ ._ _  ___
//     / . || '_>| | || ' || / /| || ' |   | | || | || ' |/ . |/ ._>/ . \| ' |<_-<
//     \___||_|  `___||_|_||_\_\|_||_|_|   |___/`___||_|_|\_. |\___.\___/|_|_|/__/
//                                                        <___'                   
                                                                                                                              