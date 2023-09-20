using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {
        // int varaibles
        static int MonsterDamage = 100;
        static int PlayerDamage = 200;
        static int XpUp = 100;
        //Float varaibles
         static float shield = 100;
         static float health = 100;
        static float xp = 0;
        static float EnemyHealth = 100;
        static float XpMultiply = 1.5f;
        static void Main()
        {
            Console.WriteLine("Welcome Explorer! You have been selected to go on a magical adventure through a land of wonders!");
            Console.WriteLine("--------------------------------------------------------------------------------------------------");
            Console.ReadKey();
            Console.WriteLine("Are you ready for a fight?");
            Console.ReadKey(); 
            Console.WriteLine("As you walk along in the woods you are attacked by a troll!");
            Console.WriteLine("The troll attacks! ");
            Console.WriteLine("It attacks with " + MonsterDamage + " Damage"); 
            HUD();

            Mission1();
            
        }
        static void Mission1()
        {
           
            
            
           Damage();
           Console.WriteLine("You attack back with " + PlayerDamage + " Damage");
           EnemyBasic();
          
           Console.WriteLine("Your Mission is over!");
            EXP(); 
           Console.ReadKey();
            
            
        }
        static public void HUD()
        {
         Console.WriteLine("You have: " + shield + " Shield "+ health + " Health");
            Console.WriteLine("--------------------------");
            Console.ReadKey();
        }
        static void Damage()
        {
            if (health >0)
            {
                if (shield > 0)
                {
                    Console.WriteLine("The monster attacks");
                    shield = shield - MonsterDamage;
                    Console.WriteLine("Your shields are down!");
                    HUD();
                }
                else
                {
                    Console.WriteLine("The monster attacks");
                    health = health - MonsterDamage;
                    Console.WriteLine("You lost all your health!");
                    HUD();
                }
            } 
        }
        static void EXP()
        {
           xp += XpUp;
            xp = xp * XpMultiply;
            Console.WriteLine("You gain " + xp + " Exp");
            if ( xp > 100)
            {
                Console.WriteLine("You advance to level 2!");
            }
            
        }
        static void EnemyBasic()
        {
            EnemyHealth = PlayerDamage - EnemyHealth;
            if (EnemyHealth <= 0)
            {
                Console.WriteLine("You have defeated the Troll!");
                EXP();
            }
        }
        
    }
}
