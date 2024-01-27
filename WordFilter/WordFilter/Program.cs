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

            while(true)
            {
                Console.Clear();

                Console.Write(PrintTexts.WantedLetterNumbers);

                foreach(int letternumber in DataController.GetNumberOfLettersList())
                {
                    Console.Write(letternumber + " ");
                }
                Console.WriteLine();
                Console.WriteLine(PrintTexts.PleaseEnterNumber);
                Console.WriteLine(PrintTexts.ToContinuePress);

                string UserInput=Console.ReadLine();
                
                if(UserInput == "C" || UserInput == "c" ) 
                {
                    DataController.StartFactoryFunction();
                    Console.Clear();
                    break;
                }

                try 
                { 
                    int number = Convert.ToInt32(UserInput);
                    DataController.AddIntToNumberOfLettersList(number);
                } catch (FormatException)
                {
                    Console.WriteLine(PrintTexts.WrongEntry);
                }
            }

            LetterNumberLimiter.LimitNumberOfLettersAndSetNewWorldList(WordList);
            
            if (InputKeyCheck.TypeYesOrNo(PrintTexts.DoYouWantToLimitCharacters, PrintTexts.YesOrNo))
            {
                while (true)
                {
                    if (InputKeyCheck.TypeYesOrNo(PrintTexts.CurrentLimitCharacter, DataController.GetWantedCharacters(), PrintTexts.YesOrNo))
                    {
                        CharLimiter.LimitCharartersOfWords();
                        break;
                    }
                    else
                    {
                        Console.WriteLine(PrintTexts.TypeNewAlphabet);
                        DataController.SetWantedCharacters(Console.ReadLine());
                    }
                }
               

            }
            

            


            TxtFileWriter.WriteTxtFile();
        }
    }
}