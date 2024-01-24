using System;

namespace WordFilter 
{
    internal class Program
    {
        static List<string> WordList = new List<string>();
        static DataController dataController;
        static void Main(string[] args)
        {
            DataController.AddIntToNumberOfLettersList(5);

            dataController = new DataController();
            WordList = TxtFileReader.ConvertTxtFileToList(Data.MainWordListTxtFilePath);
            LetterNumberLimiter.LimitNumberOfLettersAndSetNewWorldList(WordList);
            TxtFileWriter.WriteTxtFile(Data.ExportWordListPath, Data.NewWordList[Data.NumberOfLetters[0]]);
        }
    }
}