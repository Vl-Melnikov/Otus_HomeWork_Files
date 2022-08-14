using System.IO;

namespace OtusHomeWork_File
{
    public static class TestDirectory
    {
        public static void CreateDir(string path)
        {
            var directory = new DirectoryInfo(path);
            if (!directory.Exists)
            {
                directory.Create();
            }
        }
    }
}