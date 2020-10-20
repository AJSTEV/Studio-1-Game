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
        // Evan's Area
        public void stuff(Item[] items)
        {
            
            string goldKey;
            items[0].keys = "goldKey";
            
        }




        static void Main(string[] args)
        {
            EvanRoom();
            Console.ReadLine();
        }

                public static void EvanRoom()
        {
            Console.WriteLine("This room is very dark and cold.");
            Thread.Sleep(500);
            Console.WriteLine("There is a computer scream turns on. It seems that there are some questions need to be answer...");
            Thread.Sleep(500);
            Console.WriteLine("Question:If your mother and your girlfriend(boyfriend) fall into a pond and nobody can siwm including yourself");
            Thread.Sleep(500);
            Console.WriteLine("How would you like to do?");
            Thread.Sleep(500);           
            Menu1();
        
        }

            public static void Menu1()
        {

            int selection;
            string[] title = { 
                "Pretend not to see. Go home immediately and invite your friends to make a super big party",
                "Sing a song to make them relax and light a cigarette",
                "Jumping into the pond Join them", 
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
                        answer1();
                        break;

                    case 2:
                        answer2();
                        break;

                    case 3:
                        answer3();
                        break;
                
                    default:
                        break;
                }
            } while (selection != 4);
        }
     
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
                        
                        youDistanceToExit = youDistanceToExit - rand.Next(1,3);
                        zombiesDistanceToExit = zombiesDistanceToExit - rand.Next(2,6);

                        Console.WriteLine($"You are {youDistanceToExit} m from Exit.");
                        Console.WriteLine($"Zombies are {zombiesDistanceToExit - youDistanceToExit} m from you.");
                        Console.WriteLine();
                        Thread.Sleep(500);
                       
                        Console.ReadLine();

            }

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
        }
        
            static void answer3()
            {
                Console.Clear();
                Console.WriteLine("On the floor there is a gold key.");
                Console.WriteLine("What do you wish to do?");
                Console.WriteLine("Pick up the key?(yes/no)");
                string temp = Console.ReadLine();
            if (temp == "yes")
            {
                Console.WriteLine("You walk over to the key and pick it up.");
                Console.WriteLine("You got a gold key");
                
            }
            else
            {
                Console.WriteLine("Good Luck");
                
            }
            Console.ReadLine();
            }








            //Oliver's Area
            // commit test
             




       
            // Judah's Area






            //Alex's Area

        public static void MainRoom()
        {
            int choice;
            do
            {
                Console.WriteLine("You find yourself in a big room.");
                Console.WriteLine("In the room there is a door with a lock on it.");
                Console.WriteLine("On the floor there is a key.");
                Console.WriteLine("What do you wish to do?");
                Console.WriteLine("1.Walk around the room.");
                Console.WriteLine("2.Curel up and cry");
                Console.WriteLine("3.Pick up the key");

                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("You walk around the room for what seems like ages. (Nothing happens)");
                        break;
                    case 2:
                        Console.WriteLine("You curel up on the floor and cry to yourself, continplating your hopless situation.");
                        break;
                    case 3:
                        Console.WriteLine("You walk over to the key and pick it up. I feels cold iin your hand.");
                        break;
                    default:
                        Console.WriteLine("Invalid input");
                        break;
                }
            } while (choice > 3);

        }



        }
}
