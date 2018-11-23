using System;
using System.IO;

namespace BrowseDirectory
{
    /// <summary>
    /// This Program will go through all the files from given directory and sub-directory recursively.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\ravi\Desktop\CV";
            GetAllFiles(path);
            Console.ReadLine();
        }
        static void GetAllFiles(string path)
        {
            try
            {
                string[] files;
                string[] directories;

                files = Directory.GetFiles(path);
                foreach (string file in files)
                {
                    // Some function to do something with this file
                    using (FileStream fileStream = File.Open(file, FileMode.Open, FileAccess.ReadWrite))
                    {
                        //do something to file
                    }
                }
                //Find all the subdirectories
                directories = Directory.GetDirectories(path);
                foreach (string directory in directories)
                {
                    GetAllFiles(directory);
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }

}
