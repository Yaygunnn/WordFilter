using System;

namespace WordFilter 
{
    internal class Program
    {
        static List<string> WordList = new List<string>();
        
        static void Main(string[] args)
        {
            DataController.AddIntToNumberOfLettersList(4);
            DataController.AddIntToNumberOfLettersList(5);
            DataController.AddIntToNumberOfLettersList(6);


            DataController.StartFactoryFunction();

            
            WordList = TxtFileReader.ConvertTxtFileToList(DataController.GetMainWordListFilePath());
            LetterNumberLimiter.LimitNumberOfLettersAndSetNewWorldList(WordList);

            
            CharLimiter.LimitCharartersOfWords();


            TxtFileWriter.WriteTxtFile();
        }
    }
}