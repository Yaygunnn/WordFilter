using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WordFilter
{
    internal class TxtFileReader
    {
        public static List<string> ConvertTxtFileToList(string FilePath)
        {
            List<string> WordList = new List<string>();

            try
            {
                WordList = File.ReadAllLines(FilePath).ToList();
                if(WordList != null && WordList.Count > 0)
                {
                    Console.WriteLine("WordListRecieved");
                    Console.WriteLine("Word Count = " + WordList.Count);
                }
            }catch (Exception ex)
            {
                Console.WriteLine("No Txt File Found");
                Console.WriteLine($"Error: {ex.Message}");
            }

            return WordList;
        }
    }
}
