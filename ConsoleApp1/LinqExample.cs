using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    class LinqExample
    {
        static void ListByFileSize(string rootDirectory, string searchPattern)
        {
            IEnumerable<(FileInfo file, DateTime)> files = from fileName in Directory.EnumerateFiles(rootDirectory, searchPattern)
                let file = new FileInfo(fileName)
                orderby file.Length
                select (file,File.GetLastWriteTime(fileName));
        }
    }
}
