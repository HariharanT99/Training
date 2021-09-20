using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Specialized;
using System.IO;

namespace FileHandling
{
    class FileDirectoryInfo
    {
        public void Directory()
        {
            System.IO.DriveInfo di = new System.IO.DriveInfo(@"D:\");

            System.IO.DirectoryInfo dirInfo = di.RootDirectory;
            Console.WriteLine(dirInfo.Attributes.ToString());

            DirectoryInfo[] dirInfos = dirInfo.GetDirectories("*.*");

            Console.WriteLine($"Main Folder \t Root1 \t\t\t Root2 \t\t Root3");
            Console.WriteLine("\n\n");

            foreach (DirectoryInfo d in dirInfos)
            {
                if (d.Name.EndsWith("Handling"))
                {
                    PrintDirectories(d);
                }
            }
        }

        private void PrintDirectories(DirectoryInfo dir)
        {
            DirectoryInfo[] dirInfos = dir.GetDirectories("*.*");

            if (dirInfos.Length > 0)
            {
                foreach (var d in dirInfos)
                {
                    Console.Write($"{d.Name} \t\t");
                    PrintDirectories(d);
                }
                if (dirInfos.Length > 1)
                {
                    Console.WriteLine("\n\n");
                    Console.Write("\t\t");
                }
            }
            else
            {
                Console.WriteLine();
                Console.Write("\t\t\t\t\t");
            }
        }

    }
}

