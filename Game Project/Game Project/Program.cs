using System;
using System.Runtime.InteropServices;
using System.Threading;

namespace Game_Project

{
    public struct Item  //add your items
    {
        public string keys;

    }

    class Program
    {
        //Inventory
        //Main Objective Keys
        public static int redkey = 0, bluekey = 0, greenkey = 0, yellowkey = 0, blackkey = 0, blacklock = 0, victory = 0;


        // Evan's Area


        static void EvansRoom1()
        {
            EvanRoomA();

            Console.ReadLine();
        }

                public static void EvanRoomA()
        {
            Console.WriteLine("This room is very dark and cold.");
            Thread.Sleep(500);
            Console.WriteLine("There is a computer scream turns on. It seems that there are some questions need to be answer...");
            Thread.Sleep(500);
            Console.ReadLine();
            Console.WriteLine("*****************************************************************************************************************\n");
            Console.WriteLine(" Question: If your mother and your girlfriend(boyfriend) fall into a pond and nobody can siwm including yourself  \n");
            Console.WriteLine("*****************************************************************************************************************");
            Thread.Sleep(500);
            Console.ReadLine();
            Console.WriteLine("How would you like to do?");
            Console.ReadLine();
            Thread.Sleep(500);           
            Menu1();

        }

        public static void Menu1()
        {

            int selection;
            string[] title = {
                "Pretend not to see. Go home immediately and invite your friends to make a super big party",
                "Sing a song to make them relax and light a cigarette",
                "Jumping into the pond and joining them", 
                "It's not my business." };
            do
            {

                for (int i = 0; i < title.Length; i++)
                {
                    Console.WriteLine();
                    Console.Write((i + 1).ToString().PadLeft(5).PadRight(10));
                    Console.WriteLine(title[i]);
                    Console.WriteLine();
                }
                selection = Convert.ToInt32(Console.ReadLine());

                switch (selection)
                {
                    case 1:
                        zombies();
                        break;

                    case 2:
                        bomb();
                        break;

                    case 3:
                        redKey();
                        break;

                    default:
                        Console.WriteLine("Oh It is your business,go back");
                        break;
                }
            } while (selection != 4);
        }
     
                     public static void zombies()
                    {

        public static void answer1()
        {

            Console.Clear();
            Console.WriteLine("What's that noises");

            Console.ReadLine();
            Console.WriteLine("The cage is open");

            Console.ReadLine();
            Console.WriteLine("Oh my god!! ZOMBIES IS COMING");

            Console.ReadLine();
            Console.WriteLine("RUN!!!");
            int youDistanceToExit, zombiesDistanceToExit;
            Random rand = new Random();

            youDistanceToExit = rand.Next(10, 20);
            zombiesDistanceToExit = youDistanceToExit + rand.Next(15, 25);

            Console.ReadLine();

            while ((youDistanceToExit < zombiesDistanceToExit) && (youDistanceToExit > 0))
            {

                youDistanceToExit = youDistanceToExit - rand.Next(1, 3);
                zombiesDistanceToExit = zombiesDistanceToExit - rand.Next(2, 6);

                Console.WriteLine($"You are {youDistanceToExit} m from Exit.");
                Console.WriteLine($"Zombies are {zombiesDistanceToExit - youDistanceToExit} m from you.");
                Console.WriteLine();
                Thread.Sleep(500);

                Console.ReadLine();

            }

                    if (zombiesDistanceToExit - youDistanceToExit <= 0)
                    {
                        Console.WriteLine("The Zombies ate you....");
                        Main();

                        Console.ReadLine();
                        
            }
                    else
                    {
                        Console.WriteLine("You survived....");
                        
                         Console.ReadLine();
                         Console.WriteLine("It seems that they have gone...");
                        Console.ReadLine();
                        Console.WriteLine("You have to go back.");
                        Console.ReadLine();
                    }
                    Console.ReadLine();
        }
        
            public static void bomb()
            if (zombiesDistanceToExit - youDistanceToExit <= 0)
            {
                Console.WriteLine("The Zombies ate you....");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("You survived....");
                Console.ReadLine();
            }
            Console.ReadLine();
        }

        public static void answer2()
        {

            Console.Clear();
            Console.WriteLine("What is that sound ? ");
            Thread.Sleep(500);
            Console.WriteLine("Oh! My god!! That is a bomb!!!");
            Console.Beep((int)523.2, 300);
            Console.Beep();
            Console.Beep();
            Console.Beep();
            Console.Beep();
            Console.Beep();
            Console.Beep();
            Console.Beep();
            Console.Beep();
            Console.Beep();
            Console.Clear();
            Thread.Sleep(500);
            Console.WriteLine("BOMB!!!!");
            Thread.Sleep(1000);
            Console.WriteLine("You dead!!");
            Console.ReadLine();
            Main();


        }
        
            static void redKey()
            {
                Console.Clear();
                Console.WriteLine("On the floor there is a red key.");
                Console.WriteLine("What do you wish to do?");
                Console.WriteLine("Pick up the key?(yes/no)");
                string temp = Console.ReadLine();
            if (temp == "yes")
            {
                Console.WriteLine("You walk over to the key and pick it up.");
                Console.WriteLine("You got a red key");
                redkey++;
                Main();


            }
            else
            {
                Console.WriteLine("Good Luck");

            }
            Console.ReadLine();
        }








        //Oliver's Area
        // commit test
        public static void OliversRoom1()
        {
            int choice;
            Console.WriteLine("1. Go to previous room \n 2. Pick up blue key");
            choice = Convert.ToInt32(Console.ReadLine());
            do
            {
                switch (choice)
                {
                    case 1:
                        //go to previous room
                        break;
                    case 2:
                        //pick up blue key
                        break;
                    case 3:
                        break;
                }
            
            } while (choice != 0)
        Console.ReadLine();
        }
     
    





        // Judah's Area

        public static void JudahsRoom1()
        {
           

                int choice;

                do

                {

                    Console.WriteLine("You find yourself in a long corridor, it is warm and comfortable");
                    Console.WriteLine("something about this room makes you want to sit down and relax");
                    Console.WriteLine("At the end of this comfortable corridoor is a small green key hanging from what looks like a string");
                    Console.WriteLine("What do you do?");
                    Console.WriteLine("1.Go back through the door you entered.");
                    Console.WriteLine("2.Sit down and relax in comfort.");
                    Console.WriteLine("3.Run to grab the key.");

                    choice = Convert.ToInt32(Console.ReadLine());

                    switch (choice)

                    {

                        case 1:

                            Console.Clear();
                            Console.WriteLine("As comfortable as a sit down would be the room's comfort has made you uneasy");
                            Console.WriteLine("You return to the previous room.");
                            Main();

                            break;

                        case 2:

                            Console.Clear();

                            Console.WriteLine("You sit down.");
                            Console.WriteLine("Your hand comes to rest on a small object");
                            Console.WriteLine("It is a green key, you feel sleepy and take a nap");
                            Console.WriteLine("You awake in the main room");
                            greenkey = greenkey + 1;
                            Main();
                            break;

                        case 3:

                            Console.Clear();
                            Console.WriteLine("You resist the urge to sit down and sprint for the dangling key");
                            Console.WriteLine("You grab the key and are immeditely stuck to it");
                            Console.WriteLine("you cannot move.");

                            break;

                        default:

                            Console.Clear();

                            Console.WriteLine("Invalid input");
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
                    do
                    {
                        Console.WriteLine("You find yourself in a big room.");
                        Console.WriteLine("In the room there is a giant door with four locks on it.");
                        Console.WriteLine("One RED, one BLUE, one GREEN, one BLACK, and one YELLOW lock.");
                        Console.WriteLine("On the other opposite wall there is a RED door and a BLUE door.");
                        Console.WriteLine("On the left wall there is a GREEN door and on the right there is a YELLOW door.");
                        Console.WriteLine("Inthe center of the room there is a small BLACK key.");
                        Console.WriteLine("What do you wish to do?");
                        Console.WriteLine("1.Go through the RED door.");
                        Console.WriteLine("2.Go through the BLUE door.");
                        Console.WriteLine("3.Go through the GREEN door.");
                        Console.WriteLine("4.Go through the YELLOW door.");
                        if (blackkey != 1)
                        {
                            Console.WriteLine("5.Pick up the BLACK key.");
                        }
                        if (yellowkey == 1)
                        {
                            Console.WriteLine("6.Open the YELLOW lock.");
                        }
                        if ((blackkey == 1) && (blacklock == 0))
                        {
                            Console.WriteLine("7.Open the BLACK lock.");
                        }

                        choice = Convert.ToInt32(Console.ReadLine());
                        switch (choice)
                        {
                            case 1:
                                Console.Clear();
                                Console.WriteLine("You walk up to the RED door and walk through it and now find your self in a new room.");
                                EvansRoom1();
                                break;
                            case 2:
                                Console.Clear();
                                Console.WriteLine("You walk up to the BLUE door and walk through it and now find your self in a new room.");
                                OliversRoom1();
                                break;
                            case 3:
                                Console.Clear();
                                Console.WriteLine("You walk up to the GREEN door and walk through it and now find your self in a new room.");
                                JudahsRoom1();
                                break;
                            case 4:
                                Console.Clear();
                                Console.WriteLine("You walk up to the YELLOW door and walk through it and now find your self in a new room.");
                                AlexsRoom1();
                                break;
                            case 5:
                                Console.Clear();
                                Console.WriteLine("You pick up the BLACK key, it feels cold in your hand.");
                                blackkey = blackkey + 1;
                                break;
                            case 6:
                                Console.Clear();
                                Console.WriteLine("You use the YELLOW key to open the YELLOW lock.");
                                yellowkey = yellowkey - 1;
                                victory = victory + 1;
                                break;
                            case 7:
                                Console.Clear();
                                Console.WriteLine("You use the BLACK key to open the BLACK lock.");
                                blacklock = blacklock + 1;
                                victory = victory + 1;
                                break;
                            default:
                                if ((choice < 5) && (choice > 0))
                                {
                                    Console.Clear();
                                    Console.WriteLine("Invalid input, please enter the number corisponding to the choice you wish to pick.");
                                    Console.ReadLine();
                                }
                                Console.WriteLine("What do you wish to do?");
                                Console.WriteLine("1.Go through the RED door.");
                                Console.WriteLine("2.Go through the BLUE door.");
                                Console.WriteLine("3.Go through the GREEN door.");
                                Console.WriteLine("4.Go through the YELLOW door.");
                                if (blackkey != 1)
                                {
                                    Console.WriteLine("5.Pick up the BLACK key.");
                                }
                                if (yellowkey == 1)
                                {
                                    Console.WriteLine("6.Open the YELLOW lock.");
                                }
                                if ((blackkey == 1) && (blacklock == 0))
                                {
                                    Console.WriteLine("7.Open the BLACK lock.");
                                }
                                break;
                        }
                    } while ((choice < 5) && (choice > 0));
                } while (victory != 5);
            }

            public static void AlexsRoom1()
            {
                int choice;
                do
                {
                    Console.WriteLine("The find yourself in a small dark room in the center you see a small yellow key.");
                    Console.WriteLine("What do you wish to do?");
                    Console.WriteLine("1.Go back through the door you entered.");
                    Console.WriteLine("2.Look more closly around the room.");
                    Console.WriteLine("3.Pick up the key");
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
                            Console.WriteLine("You walk arounf the room for a bit but find nothing of interest except the small YELLOW key.");
                            break;
                        case 3:
                            Console.Clear();
                            Console.WriteLine("You pick up the YELLOW key, it feels cold in your hand.");
                            Console.WriteLine("You have everthing you need from this room and so you return to the Main room.");
                            yellowkey = yellowkey + 1;
                            Main();
                            break;
                        default:
                            Console.Clear();
                            Console.WriteLine("Invalid input, please enter the number corisponding to the choice you wish to pick.");
                            Console.WriteLine("What do you wish to do?");
                            Console.WriteLine("1.Go back through the door you entered.");
                            Console.WriteLine("2.Look more closly around the room.");
                            Console.WriteLine("3.Pick up the key");
                            break;
                    }
                } while (choice != 3);

                Console.ReadLine();

            }
        }
    } 
