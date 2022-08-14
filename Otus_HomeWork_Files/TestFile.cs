using System;
using System.IO;

namespace OtusHomeWork_File
{
    public static class TestFile
    {
        public static void WriteToFile(string path, string message)
        {
            FileInfo info = new FileInfo(path);
            using StreamWriter writer = info.CreateText();
            writer.WriteLine(message);
        }

        public static void ReadFile(string path)
        {
            var dir = new DirectoryInfo(path);

            foreach (FileInfo file in dir.GetFiles())
            {
                using StreamReader reader = new StreamReader(file.FullName, false);
                Console.Write($"{Path.GetFileNameWithoutExtension(file.FullName)}: {reader.ReadToEnd()}");
                reader.Close();
            }
        }

        public static void Append(string path)
        {
            File.AppendAllLines(path, new[] { DateTime.Now.ToString("HH:mm dd MMMM yyyy") });
        }
    }
}