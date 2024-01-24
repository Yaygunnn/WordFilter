using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordFilter
{
    internal class DataController
    {
        public DataController() 
        { 
            foreach(int index in Data.NumberOfLetters)
            {
                Data.NewWordList.Add(index, new List<string>());
            }
        }

        public static void AddIntToNumberOfLettersList(int number)
        {
            Data.NumberOfLetters.Add(number);
        }

        public static void AddWordToNewWordList(string word)
        {
            Data.NewWordList[word.Length].Add(word);
        }
    }
}
