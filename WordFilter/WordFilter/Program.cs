using System;

namespace WordFilter 
{
    internal class Program
    {
        static List<string> WordList = new List<string>();
        static void Main(string[] args)
        {
            WordList = TxtFileReader.ConvertTxtFileToList(Data.MainWordListTxtFilePath);
            
        }
    }
}