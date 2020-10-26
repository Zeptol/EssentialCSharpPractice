using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace ConsoleApp1
{
    class LinqExample
    {
        private static readonly string[] Keywords = { "class", "void", "private", "public*", "protected*" };
        /// <summary>
        /// "let"用法
        /// </summary>
        /// <param name="rootDirectory"></param>
        /// <param name="searchPattern"></param>
        private protected static void ListByFileSize(string rootDirectory, string searchPattern)
        {
            IEnumerable<(FileInfo file, DateTime)> files = from fileName in Directory.EnumerateFiles(rootDirectory, searchPattern)
                let file = new FileInfo(fileName)
                orderby file.Length
                select (file,File.GetLastWriteTime(fileName));
        }

        internal static void GroupKeywords()
        {
            var selection = Keywords.GroupBy(k => k.Contains("*")).Select(k=>(k.Key,k)).SelectMany(k =>k.k).ToList();
            foreach (var value in selection)
            {
                Console.Write(value + " ");
            }
        }
        internal static void GroupKeywords2()
        {
            var selection = from keyword in Keywords
                group keyword by keyword.Contains("*")
                into groups
                select (groups.Key, groups);
            foreach (var value in selection.SelectMany(g=>g.groups))
            {
                Console.Write(value + " ");
            }
        }

        protected internal static void ListMemberNames()
        {
            var enumerableMethodNames =
                (from method in typeof(Enumerable).GetMembers(BindingFlags.Public | BindingFlags.Static)
                    orderby method.Name
                    select method.Name).Distinct();
            foreach (var methodName in enumerableMethodNames)
            {
                Console.Write($"{methodName}, ");
            }
        }
    }
}
