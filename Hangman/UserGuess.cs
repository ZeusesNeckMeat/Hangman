using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hangman
{
    public class UserGuess
    {
        private readonly string _wordToGuess;
        private readonly int _maxNumberOfFailedGuesses;
        private int _currentNumberOfFailedGuesses = 0;
        private string _currentStateOfWord = string.Empty;
        private readonly IList<char> _lettersNotInWord = new List<char>();
        private readonly IList<char> _lettersGuessed = new List<char>();

        public UserGuess(string wordToGuess, int maxNumberOfFailedGuesses)
        {
            _wordToGuess = wordToGuess;
            _maxNumberOfFailedGuesses = maxNumberOfFailedGuesses;

            #region Possible attempt to generate "fresh" current state of word
            _currentStateOfWord = new string(Enumerable.Repeat('_', wordToGuess.Length).ToArray());
            #endregion
        }

        public int CurrentNumberOfFailedGuesses => _currentNumberOfFailedGuesses;
        public IEnumerable<char> LetterNotInWord => _lettersNotInWord;

        //Determine whether or not the user is out of guesses
        //This will be used outside of this class
        public bool IsUserOutOfGuesses =>

        //Determine whether or not the user won the game
        public bool DidUserWin =>

        public string CurrentStateOfWord => _currentStateOfWord;
        public void GetNextGuess()
        {
            var letterGuessed = GetUserGuessedLetter();

            if (IsLetterInWord(letterGuessed))
                UnMaskLetterInWord(letterGuessed);
        }

        //Fill out the method to do the following
        // - Prompt the user to enter a letter that has not already been guessed
        // - Retrieve the user's input and get a char representation of that input
        // - Restart this method if what the user typed in is either not a valid letter, or has already been guessed
        // - Once the user has entered a valid letter record that the letter has been guessed and return said letter from the method
        private char GetUserGuessedLetter()
        {
            
        }

        public static void ClearCurrentConsoleLine()
        {
            int currentLineCursor = Console.CursorTop;
            Console.SetCursorPosition(0, Console.CursorTop);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(0, currentLineCursor);
        }

        //Determine if the letter is in the word to guess
        //If not in the word then add that letter to the list of letters not in the word and record the failed guess
        private bool IsLetterInWord(char letter)
        {
            
        }

        //This is quite a bit more complicated, but could always attempt if interested
        private void UnMaskLetterInWord(char letterGuessed)
        {
            
        }
    }
}