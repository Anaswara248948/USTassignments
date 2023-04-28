using System;
using System.IO;

namespace IODemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            //DirectoryInfo d1 = new DirectoryInfo(@"D:\\Dot Net\\Day12\\FileDemo\\prgm1");


            Console.WriteLine("***** Directory Info *****\n");

            DirectoryInfo dir = new DirectoryInfo(@"D:\Dot Net\Day12");

            Console.WriteLine("FullName: {0}", dir.FullName);

            Console.WriteLine("Name: {0}", dir.Name);

            Console.WriteLine("Parent: {0}", dir.Parent);

            Console.WriteLine("Creation: {0}", dir.CreationTime);

            Console.WriteLine("Attributes: {0}", dir.Attributes);

            Console.WriteLine("Root: {0}", dir.Root);

            Console.WriteLine("**************************\n");

            //DriveInfo[] myDrives = DriveInfo.GetDrives();

            // File Creation

            string path = @"D:\Dot Net\Day12\FileDemo\sample.txt";
            FileInfo f1=new FileInfo(path);
            f1.Create();
            {
                Console.WriteLine("File has been created...");
            }

            Console.WriteLine("******************************\n");

            string path1 = @"D:\Dot Net\Day12\FileDemo\sample1.txt";
            FileInfo f2 = new FileInfo(path1);
            f2.Delete();
            Console.WriteLine("File has been deleted");

            Console.WriteLine("*************************************\n");


        }
    }
}
