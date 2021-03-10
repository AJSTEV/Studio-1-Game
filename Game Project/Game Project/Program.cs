using System;
using System.Runtime.InteropServices;
using System.Threading;

namespace Game_Project

{
    class Program
    {
        //Inventory
        //Main Objective Keys
        public static int redkey = 0, bluekey = 0, greenkey = 0, yellowkey = 0, blackkey = 0, victory = 0, bag = 0, yellow = 0;
        public static string yellowlock = "CLOSED", redlock = "CLOSED", bluelock = "CLOSED", greenlock = "CLOSED", blacklock = "CLOSED";
        public static int KeyFragment = 0, bombA = 0;//Evan needs
        public static void Inventory()
        {
            if (redkey >= 1)
            {
                Console.WriteLine($"Red Key x{redkey}");
                bag = 1;
            }
            if (bluekey >= 1)
            {
                Console.WriteLine($"Blue Key x{bluekey}");
                bag = 1;
            }
            if (greenkey >= 1)
            {
                Console.WriteLine($"Green Key x{greenkey}");
                bag = 1;
            }
            if (yellowkey >= 1)
            {
                Console.WriteLine($"Yellow Key x{yellowkey}");
                bag = 1;
            }
            if (blackkey >= 1)
            {
                Console.WriteLine($"Black Key x{blackkey}");
                bag = 1;
            }
            if (KeyFragment >= 1)
            {
                Console.WriteLine($"Key Fragment x{KeyFragment}");
                bag = 1;
            }
            if (bombA >= 1)
            {
                Console.WriteLine($"Bomb x{bombA}");
                bag = 1;
            }
            if (bag == 0)
            {
                Console.WriteLine("Your inventory is empty");
            }
            
            Console.ReadLine();

        }
        // Evan's Area 
        //In my room, users have to collect 2 pieces of fragments which come from room1(zombies) and room2(bomb) to make red key.
        //Room 1 zombies is needed to use a item which is bomb can be colleted by room 2 bomb.
        //room 3 redkey is a feature to make a completed redkey as long as user collect at least 2 fragments.
        //features: 001:if users pass room2 but didn't use bomb in room .There will be a notice
        //features: 002:if users havn't passed room2 but use bomb in room .There will be a jok notice user
        //features: 003: beep sound can be heard
        
        static void EvansRoom1()
        {
            
            EvanRoomA();

            Console.ReadLine();
            Console.WriteLine("Press enter to continue.");
        }

        public static void EvanRoomA()//corn question
        {
            Console.WriteLine("This room is very dark and cold.\n");
            Thread.Sleep(500);
            Console.WriteLine("There is a computer scream turns on. It seems that there a question need to be answer...\n");
            Thread.Sleep(500);          
            Console.WriteLine("*****************************************************************************************************************\n");
            Console.WriteLine(" Question: If your mother and your girlfriend(boyfriend) fall into a pond and nobody can swim including yourself  \n");
            Console.WriteLine("*****************************************************************************************************************");
            Thread.Sleep(500);
            Console.WriteLine("How would you like to do?");
            Thread.Sleep(300);
            EvanMenu1();

        }

        public static void EvanMenu1() //answers that player need to manke decision
        {

            int selection;
            string[] title = {
                "Pretend not to see. Go home immediately and invite your friends to make a super big party",//no.1 decision
                "Sing a song to make them relax and light a cigarette",//no.2 decision
                "Jumping into the pond and joining them", //no.3 decision
                "It's not my business.",//no.4 decision
                "Check Inevntory"//no.5 decision
                                        };
            do
            {

                for (int i = 0; i < title.Length; i++)
                {
                    Console.WriteLine();
                    Console.Write((i + 1).ToString().PadLeft(5).PadRight(10));
                    Console.WriteLine(title[i]);
                    Console.WriteLine();
                    Thread.Sleep(300);
                }
                string temp = Console.ReadLine();

                selection = Convert.ToInt32(temp);

                switch (selection)
                {
                    case 1:
                        zombies();//zombies situation
                        break;

                    case 2:
                        bomb();//bomb situation
                        break;

                    case 3:
                        redKey(); // make red key by fragments 
                        break;
                    case 5:
                        //EvanInventory();  //check out inventory
                        Console.Clear();
                        Inventory();
                        break;

                    default:
                        Thread.Sleep(500);
                        Console.WriteLine("Oh It is your business,go back\n");
                        Thread.Sleep(500);
                        Console.WriteLine("press enter to continue....");
                        Console.ReadLine();
                        Console.Clear();
                        EvanRoomA();
                        break;
                }
            } while (selection != 4);
        }

        public static void VictoryBeep()
        {
            Console.WriteLine(@"
                                               ,.        ,.      ,.
                                ||        ||      ||  ()
 ,--. ,-. ,.,-.  ,--.,.,-. ,-.  ||-.,.  ,.|| ,-.  ||-.,. ,-. ,.,-.  ,--.
//`-'//-\\||/|| //-||||/`'//-\\ ||-'||  ||||//-\\ ||-'||//-\\||/|| ((`-'
||   || |||| ||||  ||||   || || ||  || /|||||| || ||  |||| |||| ||  ``.
\\,-.\\-//|| || \\-||||   \\-|| ||  ||//||||\\-|| ||  ||\\-//|| || ,-.))
 `--' `-' `' `'  `-,|`'    `-^-``'  `-' `'`' `-^-``'  `' `-' `' `' `--'
                  //           .--------.
              ,-.//          .: : :  :___`.
              `--'         .'!!:::::  \\_\ `.
                      : . /%O!!::::::::\\_\. \
                     [""]/%%O!!:::::::::  : . \
                     |  |%%OO!!::::::::::: : . |
                     |  |%%OO!!:::::::::::::  :|
                     |  |%%OO!!!::::::::::::: :|
            :       .'--`.%%OO!!!:::::::::::: :|
          : .:     /`.__.'\%%OO!!!::::::::::::/
         :    .   /        \%OO!!!!::::::::::/
        ,-'``'-. ;          ;%%OO!!!!!!:::::'
        |`-..-'| |   ,--.   |`%%%OO!!!!!!:'
        | .   :| |_.','`.`._|  `%%%OO!%%'
        | . :  | |--'    `--|    `%%%%'
        |`-..-'| ||   | | | |     /__\`-.
        \::::::/ ||)|/|)|)|\|           /
---------`::::'--|._ ~**~ _.|----------( -----------------------
           )(    |  `-..-'  |           \    ______
           )(    |          |,--.       ____/ /  /\\ ,-._.-'
        ,-')('-. |          |\`;/   .-()___  :  |`.!,-'`'/`-._
       (  '  `  )`-._    _.-'|;,|    `-,    \_\__\`,-'>-.,-._
        `-....-'     ````    `--'      `-._       (`- `-._`-.                   

");
            Console.Beep(130, 100);
            Console.Beep(262, 100);
            Console.Beep(330, 100);
            Console.Beep(392, 100);
            Console.Beep(523, 100);
            Console.Beep(660, 100);
            Console.Beep(784, 300);
            Console.Beep(660, 300);
            Console.Beep(146, 100);
            Console.Beep(262, 100);
            Console.Beep(311, 100);
            Console.Beep(415, 100);
            Console.Beep(523, 100);
            Console.Beep(622, 100);
            Console.Beep(831, 300);
            Console.Beep(622, 300);
            Console.Beep(155, 100);
            Console.Beep(294, 100);
            Console.Beep(349, 100);
            Console.Beep(466, 100);
            Console.Beep(588, 100);
            Console.Beep(699, 100);
            Console.Beep(933, 300);
            Console.Beep(933, 100);
            Console.Beep(933, 100);
            Console.Beep(933, 100);
            Console.Beep(1047, 400);

        }
        public static void zombies()//no.1 decision
        {
            Console.Clear();
            Console.WriteLine("So you like crowds");
            Thread.Sleep(500);
            Console.WriteLine("Let's have a party..");
            Thread.Sleep(500);
            Console.WriteLine("A gate of a cage opened with a creak");
            Thread.Sleep(500);
            Console.WriteLine("Oh my god!! ZOMBIES IS COMING");
            Thread.Sleep(500);
            Console.WriteLine("RUN!!!");
            Thread.Sleep(800);
            int youDistanceToExit, zombiesDistanceToExit;
            Random rand = new Random();

            youDistanceToExit = rand.Next(10, 20);
            zombiesDistanceToExit = youDistanceToExit + rand.Next(15, 25);

            string temp = "";
            
                do
                {
                int distance = 0;
                    temp = "";
                    while ((youDistanceToExit < zombiesDistanceToExit) && (youDistanceToExit > 0) && (temp != "bomb"))
                    {

                    youDistanceToExit = youDistanceToExit - rand.Next(1, 2);
                    zombiesDistanceToExit = zombiesDistanceToExit - rand.Next(2, 6);
                    distance = zombiesDistanceToExit - youDistanceToExit;
                    if (distance<=0)
                    {
                        distance = 0;
                        Console.WriteLine($"You are {youDistanceToExit} m from Exit.");
                        Console.WriteLine($"Zombies are {zombiesDistanceToExit - youDistanceToExit} m from you.\n\n");
                        Console.WriteLine();
                        Thread.Sleep(500);
                        Console.WriteLine("press enter to continue....");
                        Thread.Sleep(500);
                        temp = Console.ReadLine();                       
                    }
                    if (temp == "bomb" && bombA == 0)
                    {                      

                        Console.WriteLine("After you yell \"bomb\" the world goes quiet for a second......\n") ;
                        Thread.Sleep(2000);
                        Console.WriteLine("and then the zombies chase you even faster....\n");
                        Thread.Sleep(2000);
                    }

                } while (temp == "bomb" && bombA == 0 );

                if (zombiesDistanceToExit - youDistanceToExit <= 0)
                {
                    Console.WriteLine("The Zombies ate your brain....\n\n\n");
                    Thread.Sleep(1000);
                    if (bombA == 1 && temp != "bomb")
                    {
                        Console.WriteLine("You seem to have forgotten to use your weapon...\n");
                    }
                    Console.WriteLine("press enter to continue....");
                    Console.ReadLine();

                    Console.Clear();
                    EvanMenu1();

                }
                else
                {
                    if (temp != "bomb")
                    {
                        Console.WriteLine("You survived....\n");
                        Thread.Sleep(800);
                        Console.WriteLine("It seems that they have gone...\n");
                        Thread.Sleep(800);
                        Console.WriteLine("You have to go back.\n");
                        Thread.Sleep(800);
                        Console.WriteLine("press enter to continue....");
                        Console.ReadLine();
                    }
                }
            
           
                if (temp == "bomb" && bombA >= 1)
                {

                    Console.WriteLine("You dropped a bomb on a zombie\n\n");
                    bombA = 0;
                    Console.Beep((int)523.2, 300);
                    Console.WriteLine("Beep!");
                    Console.WriteLine("Beep!!");
                    Console.Beep();
                    Console.WriteLine("Beep!!!");
                    Console.Beep();
                    Console.WriteLine("Beep!!!!");
                    Console.Beep();
                    Console.WriteLine("Beep!!!!!");
                    Console.Beep();
                    Console.WriteLine("Beep!!!!!!");
                    Console.Beep();
                    Console.WriteLine("Beep!!!!!!!");
                    Console.Beep();
                    Console.WriteLine("Beep!!!!!!!!");
                    Console.Beep();
                    Console.WriteLine("Beep!!!!!!!!!");
                    Console.Beep();
                    Console.WriteLine("Beep!!!!!!!!!!!");
                    Console.Beep();
                    Console.WriteLine("Beep!!!!!!!!!!!!");                   
                    Thread.Sleep(800);
                    Console.Clear();
                    Console.WriteLine("BOMB!!!!");
                    Console.WriteLine(@"
                              -^^---....,,--       
                         _--                  --_  
                        <                        >)
                        |                         | 
                         \._                   _./  
                            ```--. . , ; .--'''       
                                  | |   |             
                               .-=||  | |=-.   
                               `-=#$%&%$#=-'   
                                  | ;  :|     
                         _____.,-#%&$@%#&#~,._____



                                ");
                    Thread.Sleep(1000);
                    Console.WriteLine("They died again!!\n");
                    Thread.Sleep(800);
                    Console.WriteLine("It seems a Key fragment on the floor\n ");
                    Thread.Sleep(800);
                    Console.WriteLine($"Would you like to get it?(yes/no)");
                    temp = Console.ReadLine();
                    if (temp == "yes")
                    {
                        Console.WriteLine($"You got a red Key fragment\n");
                        Console.WriteLine("KeyFragment +1");
                        Thread.Sleep(800);
                        Console.WriteLine("press enter to continue....");
                        Console.ReadLine();
                        KeyFragment++;
                        
                    }
                Console.WriteLine("press enter to continue....");
                Console.ReadLine();
                }

                }
                              
        public static void bomb()//no.2 decision
        {

            int count = 1;
            char guess, comNum;
            string temp;
            Random rand = new Random();
            comNum = (char)rand.Next('a','z');
           // Console.WriteLine(comNum); //test
            Console.WriteLine("Smoking is bad for your health, but playing with fire is even more dangerous..");
            Thread.Sleep(500);
            Console.WriteLine("But if you like...");
            Thread.Sleep(500);
            Console.WriteLine("Let's play bigger");
            Thread.Sleep(500);
            Console.WriteLine("There is a bomb...");
            Thread.Sleep(500);
            Console.WriteLine("and it's going to explode unless you defuse it.");
            Thread.Sleep(500);
            Console.WriteLine("As you can see, there are 26 wires, each with A letter arranged from 'a' to 'z'.");
            Thread.Sleep(500);
            Console.WriteLine("Cutting one of the threads will prevent it from exploding.");
            Thread.Sleep(500);
            Console.WriteLine("You get FIVE chances to be wrong, and each time you get a hint.");
            Thread.Sleep(500);
            Console.WriteLine("To select your wire in letters and cut it.  (Range :a-z)\n");
            do
            {
                Console.WriteLine("make your decision.");
                temp = Console.ReadLine();
                
                guess = Convert.ToChar(temp);
                
                Console.WriteLine("Guess time: " + count);
                
                Console.WriteLine();
                if (guess < comNum)
                {
                    
                    Console.WriteLine("Too low\n");
                }
                else
                {
                    if (guess > comNum)
                    {
                       
                        Console.WriteLine("Too high\n");
                    }
                }
                if (count >= 5)
                {
                    Console.Clear();                  
                    Console.WriteLine("What is that sound ? ");
                    Thread.Sleep(500);
                    Console.WriteLine("Oh! My god!! That is a bomb!!!");
                    Console.Beep((int)523.2, 300);
                    Console.WriteLine("Beep!");
                    Console.Beep();
                    Console.WriteLine("Beep!!");
                    Console.Beep();
                    Console.WriteLine("Beep!!!");
                    Console.Beep();
                    Console.WriteLine("Beep!!!!");
                    Console.Beep();
                    Console.WriteLine("Beep!!!!!");
                    Console.Beep();
                    Console.WriteLine("Beep!!!!!!");
                    Console.Beep();
                    Console.WriteLine("Beep!!!!!!!");
                    Console.Beep();
                    Console.WriteLine("Beep!!!!!!!!");
                    Console.Beep();
                    Console.WriteLine("Beep!!!!!!!!!");
                    Console.Beep();
                    Console.WriteLine("Beep!!!!!!!!!!!");
                    Console.Beep();
                    Console.WriteLine("Beep!!!!!!!!!!!!");
                    Thread.Sleep(800);
                    Console.Clear();
                    Console.WriteLine("BOMB!!!!");
                    Console.WriteLine(@"
                              -^^---....,,--       
                         _--                  --_  
                        <                        >)
                        |                         | 
                         \._                   _./  
                            ```--. . , ; .--'''       
                                  | |   |             
                               .-=||  | |=-.   
                               `-=#$%&%$#=-'   
                                  | ;  :|     
                         _____.,-#%&$@%#&#~,._____



                                ");
                    Thread.Sleep(1000);
                    Console.WriteLine("You dead!!\n");
                    Console.WriteLine("press enter to continue....");
                    Console.ReadLine();
                    EvansRoom1();
                }
                count++;
            } while (guess != comNum || count >5); 
            Console.WriteLine();
            Console.WriteLine($"You paused the bomb and got red Key fragment\n");
            KeyFragment++;
            Console.WriteLine("KeyFragment +1\n");
            Console.WriteLine($"Would you like to get the bomb?(yes/no)\n");
            temp =  Console.ReadLine();
            if (temp == "yes")
            {
                Console.WriteLine($"You got the bomb\n");
                bombA++;
                Console.WriteLine("bomb +1\n");
            }
            Console.WriteLine("press enter to continue....");
            Console.ReadLine();


            Console.Clear();
            EvanMenu1();
        }
        
        static void redKey()//no.3 decision
        {
                if (KeyFragment >= 2)
                {
                    Console.Clear();
                    Console.WriteLine($"You have got enough red Key fragments\n");
                    Thread.Sleep(500);
                    Console.WriteLine("Do you want to put them together(yes/no)\n");
                    string temp = Console.ReadLine();
                    if (temp == "yes")
                    {

                        Console.WriteLine("Congratuations!\n");
                        Thread.Sleep(500);
                        VictoryBeep();
                        Console.WriteLine("You got a red key\n\n");
                        redkey++;
                        Console.WriteLine("Red key +1 ");
                        KeyFragment = 0;
                        
                        Console.WriteLine("press enter to continue....");
                        Console.ReadLine();
                        Console.Clear();
                        Main();
                    }
                }
                else
                {
                    Thread.Sleep(500);
                    Console.WriteLine("You were all drowned..\n\n");
                    Thread.Sleep(500);
                    Console.WriteLine("press enter to continue....");
                    Console.ReadLine();
                }


            }








        //Oliver's Area
        public static string choiceOliver;        
        public static void OliversRoom1()
        {
            Console.Clear();
            Console.WriteLine("You push open the door and cautiously enter a dark small room...");
            Thread.Sleep(700);
            Console.WriteLine("\nFrom the centre of the room emits a pale blue light");
            Console.ReadLine();
            EnterRoom();
        }
        public static void EnterRoom()
        {
            Console.Clear();
            Console.WriteLine("1. Return to main room");
            Console.WriteLine("2. Walk closer and inspect the strange light");
            choiceOliver = Console.ReadLine();
            Console.Clear();
            switch (choiceOliver)
            {
                case "1":
                    Console.WriteLine("Gripped by a feeling of dread you quickly leave the room");
                    Console.ReadLine();
                    Main();
                    break;
                case "2":                                                                   
                    Console.WriteLine("As you walk closer you notice the light is coming from a key atop a pillar");
                    Thread.Sleep(700);
                    Console.WriteLine("\nWithout hesistation you grab the key and quickly return to the main room");
                    Console.ReadLine();
                    bluekey = 1;
                    Main();
                    break;
                default:
                    Console.WriteLine("Invalid input");
                    Console.ReadLine();
                    EnterRoom();
                    break;
            }
            Console.ReadLine();
        }


        // Judah's Area

        public static void JudahsRoom1()
        {
           

                int choice;

                do

                {

                    Console.WriteLine("You find yourself in a long corridor, it is warm and comfortable.");
                    Console.WriteLine("Something about this room makes you want to sit down and relax.");
                    Console.WriteLine("At the end of this comfortable corridoor is a small green key hanging from what looks like a string.");
                    Console.WriteLine("What do you do?");
                    Console.WriteLine("1. Go back through the door you entered.");
                    Console.WriteLine("2. Sit down and relax in comfort.");
                    Console.WriteLine("3. Run to grab the key.");

                    choice = Convert.ToInt32(Console.ReadLine());

                    switch (choice)

                    {

                        case 1:

                            Console.Clear();
                            Console.WriteLine("As comfortable as a sit down would be the room's comfort has made you uneasy.");
                            Console.WriteLine("You return to the previous room.");
                            Main();

                            break;

                        case 2:

                            Console.Clear();

                            Console.WriteLine("You sit down.");
                            Console.WriteLine("Your hand comes to rest on a small object.");
                            Console.WriteLine("It is a green key, you feel sleepy and take a nap.");
                            Console.WriteLine("You awake in the main room.");
                            greenkey = greenkey + 1;
                            Main();
                            break;

                        case 3:

                            Console.Clear();
                            Console.WriteLine("You resist the urge to sit down and sprint for the dangling key.");
                            Console.WriteLine("You grab the key and are immediately stuck to it.");
                            Console.WriteLine("you cannot move.");

                            break;

                        default:

                            Console.Clear();

                            Console.WriteLine("Invalid input.");
                            Console.WriteLine("What do you do?");
                            Console.WriteLine("1.Go back through the door you entered.");
                            Console.WriteLine("2.Sit down and relax in comfort.");
                            Console.WriteLine("3.Run to grab the key.");

                            break;

                    }

                } while (choice != 3);



                Console.ReadLine();
        }





        //Alex's Area

        public static void Main()
        {
            int choice;
            do
            {
                    Console.Clear(); //added by oliver
                    Console.WriteLine("You find yourself in a big room.");
                    Console.WriteLine("In the room there is a giant door with four locks on it.");
                    Console.WriteLine("One RED, one BLUE, one GREEN, one BLACK, and one YELLOW lock.");
                    Console.WriteLine("On the other opposite wall there is a RED door and a BLUE door.");
                    Console.WriteLine("On the left wall there is a GREEN door and on the right there is a YELLOW door.");
                    Console.WriteLine("In the center of the room there is a small BLACK key.");
                    Console.WriteLine("What do you wish to do?");
                    Console.WriteLine($"The RED lock is {redlock}, the BLUE lock is {bluelock}, the GREEN lock is {greenlock},");
                    Console.WriteLine($"The YELLOW lock is {yellowlock}, and the BLACK lock is {blacklock}");
                    Console.WriteLine("1.Go through the RED door.");
                    Console.WriteLine("2.Go through the BLUE door.");
                    Console.WriteLine("3.Go through the GREEN door.");
                    Console.WriteLine("4.Go through the YELLOW door.");
                    Console.WriteLine("5.Check Inevntory.");
                    if ((blackkey != 1)&&(blacklock == "CLOSED"))
                    {
                        Console.WriteLine("6.Pick up the BLACK key.");
                    }
                    if (yellowkey >= 1)
                    {
                        Console.WriteLine("7.Open the YELLOW lock.");
                    }
                    if ((blackkey >= 1) && (blacklock == "CLOSED"))
                    {
                        Console.WriteLine("8.Open the BLACK lock.");
                    }
                    if (redkey >= 1)
                    {
                        Console.WriteLine("9.Open the RED lock.");
                    }
                    if (greenkey >= 1)
                    {
                        Console.WriteLine("10.Open the GREEN lock.");
                    }
                    if (bluekey >= 1)
                    {
                        Console.WriteLine("11.Open the BLUE lock.");
                    }

                    choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            Console.Clear();
                            Console.WriteLine("You walk up to the RED door and walk through it and now find yourself in a new room.");
                            EvansRoom1();
                            break;
                        case 2:
                            Console.Clear();
                        if (bluekey == 0)
                        {
                            Console.WriteLine("The door appears to have not been used in many years.");
                            OliversRoom1();
                        }
                        else
                        {
                            Console.WriteLine("You steel yourself and walk towards where the door was, you find nothing but a stone wall...");
                        }
                        Console.ReadLine();
                            Main();
                            break;
                        case 3:
                            Console.Clear();
                            Console.WriteLine("You walk up to the GREEN door and walk through it and now find yourself in a new room.");
                            JudahsRoom1();
                            break;
                        case 4:
                            Console.Clear();
                            Console.WriteLine("You walk up to the YELLOW door and walk through it and now find yourself in a new room.");
                            AlexsRoom1();
                            break;
                        case 5:
                            Console.Clear();
                            Inventory();
                            break;
                        case 6:
                            Console.Clear();
                            Console.WriteLine("You pick up the BLACK key, it feels cold in your hand.");
                            blackkey = blackkey + 1;
                            break;
                        case 7:
                            Console.Clear();
                            Console.WriteLine("You use the YELLOW key to open the YELLOW lock.");
                            yellowkey = yellowkey - 1;
                            yellowlock = "OPEN";
                            victory = victory + 1;
                            break;
                        case 8:
                            Console.Clear();
                            Console.WriteLine("You use the BLACK key to open the BLACK lock.");
                            blacklock = "OPEN";
                            blackkey = 0;
                            victory = victory + 1;
                            break;
                        case 9:
                            Console.Clear();
                            Console.WriteLine("You use the RED key to open the RED lock.");
                            redkey = redkey - 1;
                            redlock = "OPEN";
                            victory = victory + 1;
                            break;
                        case 10:
                            Console.Clear();
                            Console.WriteLine("You use the GREEN key to open the GREEN lock.");
                            greenkey = greenkey - 1;
                            greenlock = "OPEN";
                            victory = victory + 1;
                            break;
                        case 11:
                            Console.Clear();
                            Console.WriteLine("You use the BLUE key to open the BLUE lock.");
                            bluekey = bluekey - 1;
                            bluelock = "OPEN";
                            victory = victory + 1;
                            break;
                        default:
                                Console.Clear();
                                Console.WriteLine("Invalid input, please enter the number corresponding to the choice you wish to pick.");
                                Console.ReadLine();
                            break;

                    }
                
            } while (victory != 5);

            Console.Clear();
            Console.WriteLine("You escaped the whatever.");
            Console.WriteLine("Good for you.");
            VictoryBeep();
            Console.ReadLine();
        }

        public static void AlexsRoom1()
        {
            int choice;
            do
            {
                Console.WriteLine("You find yourself in a small dark room. In the center you see a small yellow key.");
                Console.WriteLine("What do you wish to do?");
                Console.WriteLine("1.Go back through the door you entered.");
                Console.WriteLine("2.Look more closely around the room.");
                if (yellow == 0)
                {
                    Console.WriteLine("3.Pick up the key.");
                }
                Console.WriteLine("4.Return to the main room.");
                Console.WriteLine("5.Check Inventory.");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("You have never been keen on small dark places, and so you return to the previous room.");
                        Main();
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("You walk around the room for a bit but find nothing of interest except the small YELLOW key.");
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("You pick up the YELLOW key, it feels cold in your hand.");
                        Console.WriteLine("You have everything you need from this room and so you return to the main room.");
                        yellowkey = yellowkey + 1;
                        yellow = 1;
                        Main();
                        break;
                    case 4:
                        Console.Clear();
                        Main();
                        break;
                    case 5:
                        Console.Clear();
                        Inventory();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Invalid input, please enter the number corresponding to the choice you wish to pick.");
                        Console.WriteLine("What do you wish to do?");
                        Console.WriteLine("1.Go back through the door you entered.");
                        Console.WriteLine("2.Look more closely around the room.");
                        if (yellow == 0)
                        {
                            Console.WriteLine("3.Pick up the key.");
                            yellow = 1;
                        }
                        Console.WriteLine("4.Return to the main room.");
                        Console.WriteLine("5.Check Inventory.");
                        break;
                }
            } while (choice != 3);

            Console.ReadLine();

            }
        }
    } 
