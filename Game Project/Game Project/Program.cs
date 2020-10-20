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






            // Judah's Area






            //Alex's Area





        }
}
