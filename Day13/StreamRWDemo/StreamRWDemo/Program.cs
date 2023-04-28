using System;
using System.Text;
using System.IO;

namespace StreamRWDemo
{
    public class Program
    {
        static string file = @"D:\Dot Net\Day13\sample.txt";
        static void Main()
        {
            Write();
            Read();
        }


        static void Write()
        {
            StreamWriter fileStream = new StreamWriter(file);
            fileStream.WriteLine("What is the");
            fileStream.WriteLine("dghhgdfg");
            fileStream.Close();
        }

        static void Read()
        {
            //while((static=FileStream.Read))
            //FileStream.Close();
        }
    }
}
