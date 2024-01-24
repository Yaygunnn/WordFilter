using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordFilter
{
    internal class TxtFileWriter
    {
        public static void WriteTxtFile(string FilePath, List<string> lines)
        {
            File.WriteAllLines(FilePath, lines);
        }
    }
}
