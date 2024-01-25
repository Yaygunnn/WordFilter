using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordFilter
{
    internal class TxtFileWriter
    {
        public static void WriteTxtFile()
        {
            foreach(int numberOfLetter in DataController.GetNumberOfLettersList())
            {
                string FilePath=CalculatePath(numberOfLetter);
                File.WriteAllLines(FilePath, DataController.GetNewWordListDictionary()[numberOfLetter]);
            }
        }


        private static string CalculatePath(int NumberOfLetters)
        {
            string FilePath = DataController.GetMainWordListFilePath();

            int LastPlaceInString = FilePath.LastIndexOf("/");

            FilePath = FilePath.Substring(0, LastPlaceInString + 1);

            FilePath += NumberOfLetters.ToString();

            string NameOfExportFile = "LetterWords.txt";

            FilePath += NameOfExportFile;

            Console.WriteLine(FilePath);

            return FilePath;
        }
    }
}
