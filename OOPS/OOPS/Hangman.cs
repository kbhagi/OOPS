using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    class Hangman
    {
        public Hangman(Player player)
        {
            if (player == null)
                throw new ArgumentNullException(nameof(player));
            Player = player;
            Outcome = Outcome.InProgress;
           
        }
        public Hangman()
            : this(new Player())
        {

        }
        static private List<string> _wordList = GetWordList();
        static public ReadOnlyCollection<string> WordList { get; } = new ReadOnlyCollection<string>(_wordList);

        public Player Player { get; }
        public string Word { get; }
        public Outcome Outcome { get; private set; }
        public void Guess(char letter)
        {


        }
        private static List<string> GetWordList()
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            using (var stream = assembly.GetManifestResourceStream("words.txt")) 
            using (var reader = new StreamReader(stream))
            {
                string text = reader.ReadToEnd();
                string[] array = text.Split(
                    new[] { Environment.NewLine },
                    StringSplitOptions.RemoveEmptyEntries);
                return new List<string>(array);
            }

        }
    }
}
