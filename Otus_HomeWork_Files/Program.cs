using System;
using System.IO;

namespace OtusHomeWork_File
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string[] directory = { @"c:\Otus\TestDir1", @"c:\Otus\TestDir2" };

            for (int i = 0; i < directory.Length; i++)
            {
                TestDirectory.CreateDir(directory[i]);

                string[] arrFileName = { "File1.txt", "File2.txt", "File3.txt", "File4.txt", "File5.txt", "File6.txt",
                "File7.txt", "File8.txt", "File9.txt", "File10.txt"};
                for (int j = 0; j < arrFileName.Length; j++)
                {
                    var dir = directory[i];
                    dir = Path.Combine(dir, arrFileName[j]);
                    try
                    {
                        var message = arrFileName[j];
                        TestFile.WriteToFile(dir, message);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Возникло исключение: {ex.Message}");
                    }
                }
            }

            for (int i = 0; i < directory.Length; i++)
            {
                var dir = directory[i];
                string[] filesArr = Directory.GetFiles(dir);

                foreach (var file in filesArr)
                {
                    TestFile.Append(file);
                }
            }

            for (int i = 0; i < directory.Length; i++)
            {
                var dir = directory[i];
                TestFile.ReadFile(dir);
            }
        }
    }
}