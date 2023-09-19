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
        int MonsterDamage = 100;
        //Float varaibles
        float shield = 100;
        float health = 100;
        static void Main()
        {
            Console.WriteLine("Welcome Exploerer! You have been selected to go on a magical adventure through a land of wonders!");
            Console.WriteLine("--------------------------------------------------------------------------------------------------");
            Console.ReadKey();
        }
         void Damage()
        {
            while(health >0)
            {
                if (shield > 0)
                {
                    Console.WriteLine("The monster attacks");
                    shield = shield - MonsterDamage;
                }
                else
                {
                    Console.WriteLine("The monster attacks");
                    health = health - MonsterDamage;    
                }
            } 
        }
        static void EXP()
        {

        }
        static void EnemyBasic()
        {

        }
        static void Mission1()
        {

        }
    }
}
