using System;
using System.IO;

namespace DirenctoryAndDirectoryInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            // always security check by sistem
            Directory.CreateDirectory(@"c:\temp\myfile.txt");
            var files = Directory.GetFiles(@"/Users/alenvlahovljak", "*.*", SearchOption.AllDirectories);
            foreach (var file in files)
            {
                Console.WriteLine(file);
            }

            var directories = Directory.GetDirectories(@"/Users/alenvlahovljak", "*.*", SearchOption.AllDirectories);
            foreach (var directory in directories)
            {
                Console.WriteLine(directory);
            }

            Directory.Exists(@"/Users/alenvlahovljak");

            // same as 
            var directoryInfo = new DirectoryInfo(@"/Users/alenvlahovljak");
            directoryInfo.GetFiles();
            directoryInfo.GetDirectories();
        }
    }
}