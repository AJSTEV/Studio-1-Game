using System;
using System.Collections.Generic;
using System.Text;

namespace Game_Project
{
    class CombatEncounters
    {

        public static void BlueEncounter()
        {
            //blue room encounter
            //30:30
        }
        public static void Combat(bool random, string name, int power, int health)
        {

            if (random)
            {

            }
            else
            {

            }
            while (health > 0)
            {
                Console.WriteLine("(A)ttack (D)efend (H)eal (F)lee");
                Console.WriteLine("Potions: " + Program.currentPlayer.potion + " Health: " + Program.currentPlayer.health);
                string input = Console.ReadLine();
                if (input.ToLower() == "a" || input.ToLower() == "attack")
                {
                    //attack
                }
                else if (input.ToLower() == "d" || input.ToLower() == "defend")
                {
                    //defend
                }
                else if (input.ToLower() == "h" || input.ToLower() == "heal")
                {
                    //heal
                }
                else if (input.ToLower() == "f" || input.ToLower() == "flee")
                {
                    //flee
                }

            }
        }

    
    
    
    }
}
