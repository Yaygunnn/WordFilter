using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordFilter
{
    internal class CharLimiter
    {
        public static void LimitCharartersOfWords()
        {
            List<string> WordsThatWillBeRemoved = new List<string>();

            foreach(int LetterNumber in DataController.GetNumberOfLettersList())
            {
                foreach (string word in DataController.GetNewWordListDictionary()[LetterNumber])
                {
                    foreach(char c in word)
                    {
                        if (!DataController.GetWantedCharacters().Contains(c))
                        {
                            WordsThatWillBeRemoved.Add(word);
                            break;
                        }
                    }
                }
            }

            DataController.RemoveWords(WordsThatWillBeRemoved);
        }
    }
}
