using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordFilter
{
    internal class Data
    {
        public static string MainWordListTxtFilePath = "C:/Benimkiler/Github Projects/WordFilter/WordFilter/WordFilter/bin/Debug/net8.0/MainWordList.txt";
        // paste here the original word list file path.

        public static string ExportWordListPath = "C:/Benimkiler/TxtFiles/Words.txt";

        public static List<int> NumberOfLetters = new List<int>(); 

        public static Dictionary<int,List<string>> NewWordList = new Dictionary<int,List<string>>();
    }
}
