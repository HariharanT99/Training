using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

namespace FileSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create source folder
            string sourceFilePath = @"D:\Training\Assign\09-Aug-2021\FileOperation\Source\Source1\Source2";
            string targetFilePath = @"D:\FileSystem";
            string fileName = "testc.txt";  
            var pathString1 = System.IO.Path.Combine(targetFilePath, fileName);

            File.Create(pathString1);

            if(!(Directory.Exists(sourceFilePath)))
            {
                Console.WriteLine("create");
                Directory.CreateDirectory(sourceFilePath);
            }
                

            if (!(Directory.Exists(targetFilePath)))
                Directory.CreateDirectory(targetFilePath);


            //string imagePath = @"D:\Training\Assign\09-Aug-2021\FileOperation\Images";


            //Move
           /* if (Directory.Exists(imagePath))
            {
                string[] files = Directory.GetFiles(imagePath);

                foreach (string s in files)
                {
                    var fileName = Path.GetFileName(s);
                    var destFile = Path.Combine(sourceFilePath, fileName);
                    //File.Copy(s, destFile, true);
                }
            }*/


            string[] filesText = Directory.GetFiles(sourceFilePath);
            Console.WriteLine(filesText);
            foreach (var file in filesText)
            {
                FileInfo fi = new FileInfo(file);


                var text = File.ReadAllText(file);
                //Console.WriteLine(text);
                if (Regex.IsMatch(file, @"\.txt$") && text.Contains("Gislen Software"))
                {
                    var pathString = Path.Combine(targetFilePath, fi.Name);
                    File.Copy(file, pathString);
                }

                if (Regex.IsMatch(file, @"\.jpg$|\.png$|\.gif$") && fi.Length <= 2e+6)
                {
                    var pathString = Path.Combine(targetFilePath, fi.Name);
                    File.Move(file, pathString);
                }
            }






            //List<string> fileList = new List<string>() { "file1.txt", "text.txt", "file2.txt", "some.txt", "file3.txt", "name.txt" };

            //foreach (var file in fileList)
            //{
            //    var pathString = Path.Combine(sourceFilePath, file);
            //    File.Create(pathString);
            //}

            //List<string> innerText = new List<string>() { "Gislen Software", "This some text. Text", "Gislen Software", "The purpose of our lives is to be happy.", "Gislen Software", "Ram, Sam, Candy" };

            //foreach (var filename in fileList)
            //{
            //    var pathString = Path.Combine(sourceFilePath, filename);

            //    foreach (var text in innerText)
            //    {
            //        File.WriteAllTextAsync(pathString, text);
            //        break;
            //    }
            //}

        }
    }
}
