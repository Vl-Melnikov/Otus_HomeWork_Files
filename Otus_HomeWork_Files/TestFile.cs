using System;
using System.IO;
using System.Text;

namespace OtusHomeWork_File
{
    public static class TestFile
    {
        //public static void CreateFile(string path)
        //{
        //    FileInfo fileInfo = new FileInfo(path);
        //    if (!fileInfo.Exists)
        //        fileInfo.Create();
        //}
        public static void WriteToFile(string path, string message)
        {
            FileInfo fileInfo = new FileInfo(path);

            using (FileStream fs = fileInfo.Create())
            {
                Byte[] info =
                    new UTF8Encoding(true).GetBytes(message);

                fs.Write(info, 0, info.Length);
            }
        }
        //public static void WriteToFile(string path, string message)
        //{
        //    FileInfo info = new FileInfo(path);
        //    using StreamWriter writer = info.CreateText();
        //    writer.WriteLine(message);
        //}

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
            File.AppendAllLines(path, new[] { DateTime.Now.ToString(" HH:mm dd MMMM yyyy") });
        }
    }
}