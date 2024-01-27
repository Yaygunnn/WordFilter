using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordFilter
{
    internal class InputKeyCheck
    {
        public static bool TypeYesOrNo(params String[] PrintStrings)
        {
            Console.Clear();
            while (true)
            {
                
                foreach (String str in PrintStrings)
                {
                    Console.WriteLine(str);
                }

                ConsoleKeyInfo input = Console.ReadKey();

                if(input.Key == ConsoleKey.Y)
                {
                    
                    return true;
                }

                if(input.Key == ConsoleKey.N)
                {
                    return false;
                }

                Console.Clear();
                Console.WriteLine(PrintTexts.WrongEntry);
            }
            


        }
    }
}
