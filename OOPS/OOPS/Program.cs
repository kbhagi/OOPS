using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Hangman!");
            Console.WriteLine("What's your name?");
            string name = Console.ReadLine();
            Player player = new Player(name);
            Console.WriteLine($"Welcome {player.Name}");
            HangMan hangman = new HangMan(player);
            hangman.DuplicateGuess += OnDuplicateGuess;
            hangman.IncorrectGuess += OnIncorrectGuess;
            hangman.CorrectGuess += OnCorrectGuess;
            hangman.GameLost += OnGameLost;
            hangman.GameWon += OnGameWon;

            while (hangman.Outcome == Outcome.InProgress)
            {
                Console.WriteLine(string.Join(" ", (IEnumerable<char>)hangman.WordToDisplay));
                Console.WriteLine();
                Console.WriteLine("Make a guess:");
                var keyinfo = Console.ReadKey(true);
                hangman.Guess(char.ToLower(keyinfo.KeyChar));

            }
        }
    }
}
