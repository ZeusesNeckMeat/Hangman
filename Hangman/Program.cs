using Hangman.Services;
using System;
using System.Text;

namespace Hangman
{
    public class Program
    {
        public static void Main(string[] args)
        {
            bool doesUserWantToContinue;
            var randomWordService = new RandomWordService();

            do
            {
                var newRandomWord = randomWordService.GetRandomWord();
                var userGuess = new UserGuess(newRandomWord, HangmanStages.TotalNumberOfStages);

                Action clearConsoleAndDisplayStuff = () =>
                {
                    Console.Clear();
                    DisplayWord.DisplayLettersNotInWord(userGuess.LetterNotInWord);
                    HangmanStages.ShowCurrentStage(userGuess.CurrentNumberOfFailedGuesses);
                    DisplayWord.DisplayWordGuessing(userGuess.CurrentStateOfWord);
                };

                do
                {
                    clearConsoleAndDisplayStuff();
                    userGuess.GetNextGuess();
                }
                while (!userGuess.IsUserOutOfGuesses && !userGuess.DidUserWin);

                DisplayWord.DisplayFinalMessage(userGuess.DidUserWin, newRandomWord, clearConsoleAndDisplayStuff);

                doesUserWantToContinue = GetDoesUserWantToContinue();
            }
            while (doesUserWantToContinue);
        }

        private static bool GetDoesUserWantToContinue()
        {
            Console.WriteLine();
            Console.WriteLine("Would you like to play another game? (y,n)");
            var userInput = Console.ReadKey().KeyChar;

            return userInput == 'y';
        }
    }
}