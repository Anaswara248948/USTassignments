using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQExtnMthds
{
    public class Program
    {
        static void Main(string[] args)
        {
            string str = "Welcome to Dotnet World!!!";
            string str1 = "Hello";
            string str2 = "World";

            int wordCount=str.GetWordCount();
            Console.WriteLine($"Word Count : {wordCount}");

            //string wordCon = GetConcat(str1, str2);
            //Console.WriteLine("wordCon");

            //string rslt = str1.Concat(str2);
            //Console.WriteLine(rslt);
        }
    }

    public static class ExtensionHelper
    {
        public static int GetWordCount(this string s)
        {
            if(!String.IsNullOrEmpty(s))
            {
                return s.Split(' ').Length;
            }
            return 0;
        }

        //public static string GetConcat(string s1, string s2)
        //{
        //    string rslt=s1.Concat(s2);

        //    return rslt;
        //}
    }
}
