using System;

namespace WordFilter 
{
    internal class Program
    {
        static List<string> WordList = new List<string>();
        
        static void Main(string[] args)
        {
            WordList = TxtFileReader.ConvertTxtFileToList(DataController.GetMainWordListFilePath());
                      
            while( WordList.Count == 0 )
            {
                Console.WriteLine(PrintTexts.NoTxtFileOnFilePath);

                Console.WriteLine(PrintTexts.PleaseEnterFilePath);

                string filePath = Console.ReadLine();

                WordList = TxtFileReader.TryToReachFilePath( filePath );

            }


            DataController.AddIntToNumberOfLettersList(4);
            DataController.AddIntToNumberOfLettersList(5);
            DataController.AddIntToNumberOfLettersList(6);


            DataController.StartFactoryFunction();

            
            
            LetterNumberLimiter.LimitNumberOfLettersAndSetNewWorldList(WordList);

            
            CharLimiter.LimitCharartersOfWords();


            TxtFileWriter.WriteTxtFile();
        }
    }
}