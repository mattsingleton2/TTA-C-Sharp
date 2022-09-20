﻿using System;
using System.IO;
using Casino;
using Casino.TwentyOne;

namespace Blackjack
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to the Grand Hotel and Casino. Let's start by telling me your name.");
            string playerName = Console.ReadLine();
            
            Console.WriteLine("And how much money did you bring today?");
            int bank = Convert.ToInt32(Console.ReadLine());
           
            Console.WriteLine($"Hello, {playerName}. Would you like to join a game of 21 right now?");
            string answer = Console.ReadLine().ToLower();
            
            if (answer == "yes" || answer == "yeah" || answer == "y" || answer == "ya")
            {
                Player player = new Player(playerName, bank);
                player.Id = Guid.NewGuid();
                using (StreamWriter file = new StreamWriter(@"C:\Users\matts\Desktop\log.txt", true))
                {
                    file.WriteLine($"Player ID: {player.Id} started game.");
                }
                Game game = new TwentyOneGame();
                game += player;
                player.IsActivelyPlaying = true;
                while (player.IsActivelyPlaying && player.Balance > 0)
                {
                    game.Play();
                }
                game -= player;
                Console.WriteLine("Thanks for playing!");
            }
            
            Console.WriteLine("Feel free to look around the casino. Bye for now.");
            Console.Read();
        }
    }
}
