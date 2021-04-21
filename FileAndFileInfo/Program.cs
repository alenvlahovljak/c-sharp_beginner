using System;
using System.IO;

namespace FileAndFileInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"c\temp\myfile.jpg";

            // true if file exist overite
            File.Copy(@"c\temp\myfile.jpg", @"d:\temp\myfile.jpg", true);
            File.Delete(path);

            if (File.Exists(path))
            {
                
            }

            var content = File.ReadAllText(path);
            
            
            // equivalent methods
            var fileInfo = new FileInfo(path);

            fileInfo.CopyTo(@"d:\temp\myfile.jpg", true);
            fileInfo.Delete();

            if (fileInfo.Exists)
            {
                
            }
            
        }
    }
}