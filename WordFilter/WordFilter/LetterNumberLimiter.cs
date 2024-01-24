using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordFilter
{
    internal class LetterNumberLimiter
    {
        public static void LimitNumberOfLettersAndSetNewWorldList(List<string> OldWordList)
        {
            foreach (string word in OldWordList)
            {
                if(DataController.GetNumberOfLettersList().Contains(word.Length))
                {
                    DataController.AddWordToNewWordList(word);
                }
            }
        }
    }
}
