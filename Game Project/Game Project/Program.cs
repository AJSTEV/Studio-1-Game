using System;
using System.Runtime.InteropServices;
using System.Threading;

namespace Game_Project
{
    class Program
    {
        // Evan's Area
        




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
            Console.WriteLine("There are 4 doors(methods) in front of you");
            Thread.Sleep(500);
            Console.WriteLine("Which one do you want to get into?");
            Thread.Sleep(500);           
            Menu1();

            Console.Beep(); Console.Beep((int)523.2, 300); Console.Beep((int)523.2, 300); Console.Beep((int)523.2, 300);
        }

            public static void Menu1()
        {

            int selection;
            string[] title = { "method1", "method2", "method3", "Exit" };
            do
            {
                Console.Clear();
                Console.WriteLine("Main Menu".PadLeft(20));
                Console.WriteLine("Please Select a number".PadLeft(28));
                for (int i = 0; i < title.Length; i++)
                {
                    Console.Write((i + 1).ToString().PadRight(10));
                    Console.WriteLine(title[i]);
                }
                // selection to call out task or exit the program
                selection = Convert.ToInt32(Console.ReadLine());

                switch (selection)
                {
                    case 1:
                        method1();
                        break;

                    case 2:
                        method2();
                        break;

                    case 3:
                        method3();
                        break;
                    default:
                        break;
                }
            } while (selection != 4);
        }
     
             public static void method1()
            {
                Console.WriteLine("Press any key to continue");
                Console.ReadLine();
                }
        
            public static void method2()
            {
   
            
            
            Console.Clear();
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
            Console.WriteLine("Boommmmmmmmmmmmm!!!!!!!!");
            Thread.Sleep(500);
            Console.WriteLine("You dead!!");


        }
        
            static void method3()
            {
                Console.Clear();
                Console.WriteLine("empty for now");

                Console.WriteLine("Press any key to continue");
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
