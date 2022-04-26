using System;
using System.Collections.Generic;
using System.Linq;

namespace Hangman
{
    public class HangmanStages
    {
        private static IReadOnlyDictionary<int, Action> _hangmanStagesPerGuesses = new Dictionary<int, Action>();

        private static readonly IList<Action> _allStages = new List<Action>
        {
            Initial,
            Head,
            //Torso,
            //Nipples,
            BellyButton,
            OneArm,
            TwoArms,
            //OneHand,
            TwoHands,
            //OneLeg,
            TwoLegs,
            OneFoot,
            Death
        };

        private static IReadOnlyDictionary<int, Action> GetDictionary()
        {
            if (_hangmanStagesPerGuesses != null && _hangmanStagesPerGuesses.Any())
                return _hangmanStagesPerGuesses;

            var actionsAndIndices = _allStages.Select((action, index) => (index, action));
            _hangmanStagesPerGuesses = new Dictionary<int, Action>(actionsAndIndices.ToDictionary(x => x.index, x => x.action));
            return _hangmanStagesPerGuesses;
        }

        public static int TotalNumberOfStages => GetDictionary().Select((item, index) => index).Max();

        public static void ShowCurrentStage(int numberOfFailedGuesses)
        {
            if (GetDictionary().TryGetValue(numberOfFailedGuesses, out var stage))
                stage.Invoke();
            else
                Console.WriteLine($"Number of failed guesses incorrect: {numberOfFailedGuesses}");
        }

        private static void Initial()
        {
            Console.WriteLine(@" ____________________");
            Console.WriteLine(@"| .__________________|");
            Console.WriteLine(@"| | / /");
            Console.WriteLine(@"| |/ /");
            Console.WriteLine(@"| | /");
            Console.WriteLine(@"| |/");
            Console.WriteLine(@"| |");
            Console.WriteLine(@"| |");
            Console.WriteLine(@"| |");
            Console.WriteLine(@"| |");
            Console.WriteLine(@"| |");
            Console.WriteLine(@"| |");
            Console.WriteLine(@"| |");
            Console.WriteLine(@"| |");
            Console.WriteLine(@"| |");
            Console.WriteLine(@"| |");
            Console.WriteLine(@"| |");
            Console.WriteLine(@"| | ");
            Console.WriteLine(@"~~~~~~~~~~|_        |~~~|");
            Console.WriteLine(@"|~|~~~~~~~\ \       '~|~|");
            Console.WriteLine(@"| |        \ \        | |");
            Console.WriteLine(@": :         \ \       : :");
            Console.WriteLine(@". .          `'       . .");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
        }

        private static void Head()
        {
            Console.WriteLine(@" ___________.._______");
            Console.WriteLine(@"| .__________))______|");
            Console.WriteLine(@"| | / /      ||");
            Console.WriteLine(@"| |/ /       ||");
            Console.WriteLine(@"| | /        ||.-''.");
            Console.WriteLine(@"| |/         |/  _  \ ");
            Console.WriteLine(@"| |          ||  `/,|");
            Console.WriteLine(@"| |          (\\`_.'");
            Console.WriteLine(@"| |");
            Console.WriteLine(@"| |");
            Console.WriteLine(@"| |");
            Console.WriteLine(@"| |");
            Console.WriteLine(@"| |");
            Console.WriteLine(@"| |");
            Console.WriteLine(@"| |");
            Console.WriteLine(@"| |");
            Console.WriteLine(@"| |");
            Console.WriteLine(@"| | ");
            Console.WriteLine(@"~~~~~~~~~~|_        |~~~|");
            Console.WriteLine(@"|~|~~~~~~~\ \       '~|~|");
            Console.WriteLine(@"| |        \ \        | |");
            Console.WriteLine(@": :         \ \       : :");
            Console.WriteLine(@". .          `'       . .");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
        }

        private static void Torso()
        {
            Console.WriteLine(@" ___________.._______");
            Console.WriteLine(@"| .__________))______|");
            Console.WriteLine(@"| | / /      ||");
            Console.WriteLine(@"| |/ /       ||");
            Console.WriteLine(@"| | /        ||.-''.");
            Console.WriteLine(@"| |/         |/  _  \ ");
            Console.WriteLine(@"| |          ||  `/,|");
            Console.WriteLine(@"| |          (\\`_.'");
            Console.WriteLine(@"| |         .-`--'.");
            Console.WriteLine(@"| |          |   |");
            Console.WriteLine(@"| |          |   |");
            Console.WriteLine(@"| |          |   |");
            Console.WriteLine(@"| |          |   |");
            Console.WriteLine(@"| |");
            Console.WriteLine(@"| |");
            Console.WriteLine(@"| |");
            Console.WriteLine(@"| |");
            Console.WriteLine(@"| | ");
            Console.WriteLine(@"~~~~~~~~~~|_        |~~~|");
            Console.WriteLine(@"|~|~~~~~~~\ \       '~|~|");
            Console.WriteLine(@"| |        \ \        | |");
            Console.WriteLine(@": :         \ \       : :");
            Console.WriteLine(@". .          `'       . .");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
        }

        private static void Nipples()
        {
            Console.WriteLine(@" ___________.._______");
            Console.WriteLine(@"| .__________))______|");
            Console.WriteLine(@"| | / /      ||");
            Console.WriteLine(@"| |/ /       ||");
            Console.WriteLine(@"| | /        ||.-''.");
            Console.WriteLine(@"| |/         |/  _  \ ");
            Console.WriteLine(@"| |          ||  `/,|");
            Console.WriteLine(@"| |          (\\`_.'");
            Console.WriteLine(@"| |         .-`--'.");
            Console.WriteLine(@"| |          |. .|");
            Console.WriteLine(@"| |          |   |");
            Console.WriteLine(@"| |          |   |");
            Console.WriteLine(@"| |          |   |");
            Console.WriteLine(@"| |");
            Console.WriteLine(@"| |");
            Console.WriteLine(@"| |");
            Console.WriteLine(@"| |");
            Console.WriteLine(@"| | ");
            Console.WriteLine(@"~~~~~~~~~~|_        |~~~|");
            Console.WriteLine(@"|~|~~~~~~~\ \       '~|~|");
            Console.WriteLine(@"| |        \ \        | |");
            Console.WriteLine(@": :         \ \       : :");
            Console.WriteLine(@". .          `'       . .");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
        }

        private static void BellyButton()
        {
            Console.WriteLine(@" ___________.._______");
            Console.WriteLine(@"| .__________))______|");
            Console.WriteLine(@"| | / /      ||");
            Console.WriteLine(@"| |/ /       ||");
            Console.WriteLine(@"| | /        ||.-''.");
            Console.WriteLine(@"| |/         |/  _  \ ");
            Console.WriteLine(@"| |          ||  `/,|");
            Console.WriteLine(@"| |          (\\`_.'");
            Console.WriteLine(@"| |         .-`--'.");
            Console.WriteLine(@"| |          |. .|");
            Console.WriteLine(@"| |          |   |");
            Console.WriteLine(@"| |          | . |");
            Console.WriteLine(@"| |          |   |");
            Console.WriteLine(@"| |");
            Console.WriteLine(@"| |");
            Console.WriteLine(@"| |");
            Console.WriteLine(@"| |");
            Console.WriteLine(@"| | ");
            Console.WriteLine(@"~~~~~~~~~~|_        |~~~|");
            Console.WriteLine(@"|~|~~~~~~~\ \       '~|~|");
            Console.WriteLine(@"| |        \ \        | |");
            Console.WriteLine(@": :         \ \       : :");
            Console.WriteLine(@". .          `'       . .");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
        }

        private static void OneArm()
        {
            Console.WriteLine(@" ___________.._______");
            Console.WriteLine(@"| .__________))______|");
            Console.WriteLine(@"| | / /      ||");
            Console.WriteLine(@"| |/ /       ||");
            Console.WriteLine(@"| | /        ||.-''.");
            Console.WriteLine(@"| |/         |/  _  \ ");
            Console.WriteLine(@"| |          ||  `/,|");
            Console.WriteLine(@"| |          (\\`_.'");
            Console.WriteLine(@"| |         .-`--'.");
            Console.WriteLine(@"| |        /Y . .|");
            Console.WriteLine(@"| |       // |   |");
            Console.WriteLine(@"| |      //  | . |");
            Console.WriteLine(@"| |          |   |");
            Console.WriteLine(@"| |");
            Console.WriteLine(@"| |");
            Console.WriteLine(@"| |");
            Console.WriteLine(@"| |");
            Console.WriteLine(@"| | ");
            Console.WriteLine(@"~~~~~~~~~~|_        |~~~|");
            Console.WriteLine(@"|~|~~~~~~~\ \       '~|~|");
            Console.WriteLine(@"| |        \ \        | |");
            Console.WriteLine(@": :         \ \       : :");
            Console.WriteLine(@". .          `'       . .");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
        }        

        private static void TwoArms()
        {
            Console.WriteLine(@" ___________.._______");
            Console.WriteLine(@"| .__________))______|");
            Console.WriteLine(@"| | / /      ||");
            Console.WriteLine(@"| |/ /       ||");
            Console.WriteLine(@"| | /        ||.-''.");
            Console.WriteLine(@"| |/         |/  _  \ ");
            Console.WriteLine(@"| |          ||  `/,|");
            Console.WriteLine(@"| |          (\\`_.'");
            Console.WriteLine(@"| |         .-`--'.");
            Console.WriteLine(@"| |        /Y . . Y\");
            Console.WriteLine(@"| |       // |   | \\");
            Console.WriteLine(@"| |      //  | . |  \\");
            Console.WriteLine(@"| |          |   |");
            Console.WriteLine(@"| |");
            Console.WriteLine(@"| |");
            Console.WriteLine(@"| |");
            Console.WriteLine(@"| |");
            Console.WriteLine(@"| | ");
            Console.WriteLine(@"~~~~~~~~~~|_        |~~~|");
            Console.WriteLine(@"|~|~~~~~~~\ \       '~|~|");
            Console.WriteLine(@"| |        \ \        | |");
            Console.WriteLine(@": :         \ \       : :");
            Console.WriteLine(@". .          `'       . .");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
        }

        private static void OneHand()
        {
            Console.WriteLine(@" ___________.._______");
            Console.WriteLine(@"| .__________))______|");
            Console.WriteLine(@"| | / /      ||");
            Console.WriteLine(@"| |/ /       ||");
            Console.WriteLine(@"| | /        ||.-''.");
            Console.WriteLine(@"| |/         |/  _  \ ");
            Console.WriteLine(@"| |          ||  `/,|");
            Console.WriteLine(@"| |          (\\`_.'");
            Console.WriteLine(@"| |         .-`--'.");
            Console.WriteLine(@"| |        /Y . . Y\");
            Console.WriteLine(@"| |       // |   | \\");
            Console.WriteLine(@"| |      //  | . |  \\");
            Console.WriteLine(@"| |     ')   |   |");
            Console.WriteLine(@"| |");
            Console.WriteLine(@"| |");
            Console.WriteLine(@"| |");
            Console.WriteLine(@"| |");
            Console.WriteLine(@"| | ");
            Console.WriteLine(@"~~~~~~~~~~|_        |~~~|");
            Console.WriteLine(@"|~|~~~~~~~\ \       '~|~|");
            Console.WriteLine(@"| |        \ \        | |");
            Console.WriteLine(@": :         \ \       : :");
            Console.WriteLine(@". .          `'       . .");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
        }

        private static void TwoHands()
        {
            Console.WriteLine(@" ___________.._______");
            Console.WriteLine(@"| .__________))______|");
            Console.WriteLine(@"| | / /      ||");
            Console.WriteLine(@"| |/ /       ||");
            Console.WriteLine(@"| | /        ||.-''.");
            Console.WriteLine(@"| |/         |/  _  \ ");
            Console.WriteLine(@"| |          ||  `/,|");
            Console.WriteLine(@"| |          (\\`_.'");
            Console.WriteLine(@"| |         .-`--'.");
            Console.WriteLine(@"| |        /Y . . Y\");
            Console.WriteLine(@"| |       // |   | \\");
            Console.WriteLine(@"| |      //  | . |  \\");
            Console.WriteLine(@"| |     ')   |   |   (`");
            Console.WriteLine(@"| |");
            Console.WriteLine(@"| |");
            Console.WriteLine(@"| |");
            Console.WriteLine(@"| |");
            Console.WriteLine(@"| | ");
            Console.WriteLine(@"~~~~~~~~~~|_        |~~~|");
            Console.WriteLine(@"|~|~~~~~~~\ \       '~|~|");
            Console.WriteLine(@"| |        \ \        | |");
            Console.WriteLine(@": :         \ \       : :");
            Console.WriteLine(@". .          `'       . .");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
        }        

        private static void OneLeg()
        {
            Console.WriteLine(@" ___________.._______");
            Console.WriteLine(@"| .__________))______|");
            Console.WriteLine(@"| | / /      ||");
            Console.WriteLine(@"| |/ /       ||");
            Console.WriteLine(@"| | /        ||.-''.");
            Console.WriteLine(@"| |/         |/  _  \ ");
            Console.WriteLine(@"| |          ||  `/,|");
            Console.WriteLine(@"| |          (\\`_.'");
            Console.WriteLine(@"| |         .-`--'.");
            Console.WriteLine(@"| |        /Y . . Y\");
            Console.WriteLine(@"| |       // |   | \\");
            Console.WriteLine(@"| |      //  | . |  \\");
            Console.WriteLine(@"| |     ')   |   |   (`");
            Console.WriteLine(@"| |          ||");
            Console.WriteLine(@"| |          ||");
            Console.WriteLine(@"| |          ||");
            Console.WriteLine(@"| |          ||");
            Console.WriteLine(@"| |");
            Console.WriteLine(@"~~~~~~~~~~|_        |~~~|");
            Console.WriteLine(@"|~|~~~~~~~\ \       '~|~|");
            Console.WriteLine(@"| |        \ \        | |");
            Console.WriteLine(@": :         \ \       : :");
            Console.WriteLine(@". .          `'       . .");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
        }

        private static void TwoLegs()
        {
            Console.WriteLine(@" ___________.._______");
            Console.WriteLine(@"| .__________))______|");
            Console.WriteLine(@"| | / /      ||");
            Console.WriteLine(@"| |/ /       ||");
            Console.WriteLine(@"| | /        ||.-''.");
            Console.WriteLine(@"| |/         |/  _  \ ");
            Console.WriteLine(@"| |          ||  `/,|");
            Console.WriteLine(@"| |          (\\`_.'");
            Console.WriteLine(@"| |         .-`--'.");
            Console.WriteLine(@"| |        /Y . . Y\");
            Console.WriteLine(@"| |       // |   | \\");
            Console.WriteLine(@"| |      //  | . |  \\");
            Console.WriteLine(@"| |     ')   |   |   (`");
            Console.WriteLine(@"| |          ||'||");
            Console.WriteLine(@"| |          || ||");
            Console.WriteLine(@"| |          || ||");
            Console.WriteLine(@"| |          || ||");
            Console.WriteLine(@"| |");
            Console.WriteLine(@"~~~~~~~~~~|_        |~~~|");
            Console.WriteLine(@"|~|~~~~~~~\ \       '~|~|");
            Console.WriteLine(@"| |        \ \        | |");
            Console.WriteLine(@": :         \ \       : :");
            Console.WriteLine(@". .          `'       . .");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
        }

        private static void OneFoot()
        {
            Console.WriteLine(@" ___________.._______");
            Console.WriteLine(@"| .__________))______|");
            Console.WriteLine(@"| | / /      ||");
            Console.WriteLine(@"| |/ /       ||");
            Console.WriteLine(@"| | /        ||.-''.");
            Console.WriteLine(@"| |/         |/  _  \ ");
            Console.WriteLine(@"| |          ||  `/,|");
            Console.WriteLine(@"| |          (\\`_.'");
            Console.WriteLine(@"| |         .-`--'.");
            Console.WriteLine(@"| |        /Y . . Y\");
            Console.WriteLine(@"| |       // |   | \\");
            Console.WriteLine(@"| |      //  | . |  \\");
            Console.WriteLine(@"| |     ')   |   |   (`");
            Console.WriteLine(@"| |          ||'||");
            Console.WriteLine(@"| |          || ||");
            Console.WriteLine(@"| |          || ||");
            Console.WriteLine(@"| |          || ||");
            Console.WriteLine(@"| |         / |");
            Console.WriteLine(@"~~~~~~~~~~|_`-'     |~~~|");
            Console.WriteLine(@"|~|~~~~~~~\ \       '~|~|");
            Console.WriteLine(@"| |        \ \        | |");
            Console.WriteLine(@": :         \ \       : :");
            Console.WriteLine(@". .          `'       . .");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
        }

        private static void Death()
        {
            Console.WriteLine(@" ___________.._______");
            Console.WriteLine(@"| .__________))______|");
            Console.WriteLine(@"| | / /      ||");
            Console.WriteLine(@"| |/ /       ||");
            Console.WriteLine(@"| | /        ||.-''.");
            Console.WriteLine(@"| |/         |/  _  \ ");
            Console.WriteLine(@"| |          ||  `/,|");
            Console.WriteLine(@"| |          (\\`_.'");
            Console.WriteLine(@"| |         .-`--'.");
            Console.WriteLine(@"| |        /Y . . Y\");
            Console.WriteLine(@"| |       // |   | \\");
            Console.WriteLine(@"| |      //  | . |  \\");
            Console.WriteLine(@"| |     ')   |   |   (`");
            Console.WriteLine(@"| |          ||'||");
            Console.WriteLine(@"| |          || ||");
            Console.WriteLine(@"| |          || ||");
            Console.WriteLine(@"| |          || ||");
            Console.WriteLine(@"| |         / | | \");
            Console.WriteLine(@"~~~~~~~~~~|_`-' `-' |~~~|");
            Console.WriteLine(@"|~|~~~~~~~\ \       '~|~|");
            Console.WriteLine(@"| |        \ \        | |");
            Console.WriteLine(@": :         \ \       : :");
            Console.WriteLine(@". .          `'       . .");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}