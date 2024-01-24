﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordFilter
{
    internal class DataController
    {
        private static Data data = new Data();
        
        public static void StartFactoryFunction()
        {
            foreach (int index in data.NumberOfLetters)
            {
                data.NewWordList.Add(index, new List<string>());
            }
        }



        public static void AddIntToNumberOfLettersList(int number)
        {
            data.NumberOfLetters.Add(number);
        }

        public static void AddWordToNewWordList(string word)
        {
            data.NewWordList[word.Length].Add(word);
        }
        
        public static List<int> GetNumberOfLettersList()
        {
            return data.NumberOfLetters;
        }
        public static string GetMainWordListFilePath()
        {
            return data.MainWordListTxtFilePath;
        }

        public static string GetExportWordListFilePath()
        {
            return data.ExportWordListPath;
        }
        public static Dictionary<int,List<string>> GetNewWordListDictionary()
        {
            return data.NewWordList;
        }
    }
}