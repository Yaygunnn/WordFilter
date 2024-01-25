using System;

namespace WordFilter 
{
    internal class Program
    {
        static List<string> WordList = new List<string>();
        
        static void Main(string[] args)
        {
            DataController.AddIntToNumberOfLettersList(5);

            DataController.StartFactoryFunction();

            
            WordList = TxtFileReader.ConvertTxtFileToList(DataController.GetMainWordListFilePath());
            LetterNumberLimiter.LimitNumberOfLettersAndSetNewWorldList(WordList);

            string TurkishAlphabet = "abcçdefgğhıijklmnoöprsştuüvyz";
            DataController.SetWantedCharacters(TurkishAlphabet);
            CharLimiter.LimitCharartersOfWords();


            TxtFileWriter.WriteTxtFile(DataController.GetExportWordListFilePath(), DataController.GetNewWordListDictionary()
                [DataController.GetNumberOfLettersList()[0]]);
        }
    }
}