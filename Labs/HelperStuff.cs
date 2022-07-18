using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labs
{
    public class LetterWords
    {
        public string Letter { get; set; }
        public List<string> words { get; set; } = new List<string>();
    }

    public static class ExtensionMethods
    {
        public static string PrintLetterWords(this LetterWords lw)
        {
            return lw.Letter + ": Words = " + String.Join(", ", lw.words);
        }
    }

    public class HelperStuff
    {
        public static void Go()
        {
            //Debugme();
            Helpers();

            
        }


        public static void Helpers()
        {
            LetterWords lw1 = new LetterWords();
            lw1.Letter = "A";
            lw1.words.Add("Apple");
            lw1.words.Add("Algroithm");

            List<LetterWords> myLetters = new List<LetterWords>();
            myLetters.Add(lw1);
        }
        public static void Debugme()
        {
            int glueCrewCount = 0;

            List<int> myNumbers = new List<int>{ 1, 2, 3, 4 };

            for (int i = 0; i < myNumbers.Count; i++)
            {
                Console.WriteLine(myNumbers[i]);
            }

            int result = SumMethod(glueCrewCount);
            Console.WriteLine("Result: " + result);
        }

        private static int SumMethod(int value)
        {
            return value * 2;
        }
    }

}
