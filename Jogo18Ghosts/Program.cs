﻿using System;

namespace Jogo18Ghosts
{
    class GamePlay
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Tell me your names Player 1, Player 2.");

            var player1 = new PlayerYellow()
            {
                Name = Console.ReadLine()

            };

            var player2 = new PlayerBlue()
            {
                Name = Console.ReadLine()
            };

            var winner = new Battle(player1, player2).PlayMatchUp();

            if (winner == null)
            {
                Console.WriteLine("You cannot fight him.");
            }
            else
            {
                Console.WriteLine("The Winner of this battle is {0}", winner.Name);
            }

            Console.ReadKey();
        }

    }
}

