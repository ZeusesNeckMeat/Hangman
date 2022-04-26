using System;
using System.Collections.Generic;
using System.Linq;

namespace Hangman
{
    internal static class DisplayWord
    {
        public static void DisplayLettersNotInWord(IEnumerable<char> guessedLetters)
        {
            Console.WriteLine(new string(guessedLetters.ToArray()));
            Console.WriteLine();
        }

        public static void DisplayWordGuessing(string currentStateOfWord)
        {
            var letters = currentStateOfWord.ToList();
            Console.WriteLine(string.Join(" ", letters));
            Console.WriteLine();
        }

        public static void DisplayFinalMessage(bool didUserWin, string wordToGuess, Action action)
        {
            var finalMessage = didUserWin ? "Congratulations!!" : $"Better luck next time! \n\n Word: {wordToGuess}";
            action.Invoke();
            Console.WriteLine();
            Console.WriteLine(finalMessage);
        }
    }
}