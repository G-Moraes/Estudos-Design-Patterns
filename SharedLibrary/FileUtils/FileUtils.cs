namespace SharedLibrary.FileUtils
{
    public static class FileUtils
    {
        public static string LoadFileFromPath(string filePath)
        {
            if (String.IsNullOrEmpty(filePath))
            {
                Console.WriteLine("File Path was null or empty!");
                return null;
            }

            if (!File.Exists(filePath))
            {
                Console.WriteLine("Path or File doesn't exist!");
                return null;
            }

            string readText = File.ReadAllText(filePath);

            if (String.IsNullOrEmpty(readText))
            {
                Console.WriteLine("File was empty!");
                return null;
            }

            return readText;
        }
    }
}
