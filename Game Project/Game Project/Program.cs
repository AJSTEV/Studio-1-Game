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
            Introduction();
            Console.ReadLine();
        }
        public static void Introduction()
        {
            Console.WriteLine("You wake up is a strange room...");
            Thread.Sleep(500);
            Console.WriteLine("Who am i?");
            Thread.Sleep(500);
            Console.WriteLine("there are 3 doors in front of you");
            Thread.Sleep(500);
            Console.WriteLine("which one do you want to get into?");
            Thread.Sleep(500);
            Console.ReadLine();
            Menu1();
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

        //method1
             public static void method1()
            {
                Console.WriteLine("Press any key to continue");
                Console.ReadLine();
             }
        
                public static void method2()
                {
                    Console.Clear();
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





        }
}
