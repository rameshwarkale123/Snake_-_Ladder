using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SnakeAndLadder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("snake & Ladder Program");
            int Position = 0;
            //Initializing Constants
            const int Ladder = 1;
            const int NoPlay = 2;
            const int Snake = 3;

            Random random = new Random();
            int dieCount = 0;
            while (Position != 100)
            {
                int DieRoll = random.Next(1, 7);
                Console.WriteLine($"Die Rolling : {DieRoll}");
                dieCount++;
                int options = random.Next(1, 4);

                switch (options)
                {
                    case Ladder:
                        Position += DieRoll;
                        break;
                    case Snake:
                        Position -= DieRoll;
                        //turnery operator
                        Position = Position < 0 ? 0 : Position;
                        break;
                    case NoPlay:
                        break;
                }

                Console.WriteLine($"Die count:{dieCount} Position: {Position}\n");
            }
            Console.WriteLine("\nPOSITION " + Position);
            Console.ReadLine();
        }
    }
}
