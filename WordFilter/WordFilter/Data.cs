using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordFilter
{
    internal class Data
    {
        public  string MainWordListTxtFilePath ="C:/Benimkiler/TxtFiles/MainWordList.txt";
        // paste here the original word list file path.

        public  List<int> NumberOfLetters = new List<int>();

        public string WantedCharacters = "abcçdefgğhıijklmnoöprsştuüvyz";

        public  Dictionary<int,List<string>> NewWordList = new Dictionary<int,List<string>>();
    
        

    }
}
