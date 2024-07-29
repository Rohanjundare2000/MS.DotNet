namespace FileHandling
{
    internal class Program
    {
        static void Main()
        {
            writeFormatedTextFile();
            ReadFormatedTextFile();
        }

        private static void writeFormatedTextFile()
        {
            StreamWriter writer = File.CreateText("D:\\b.txt");
            writer.WriteLine("Hello World");
            writer.WriteLine("ROhan");
            writer.WriteLine("Jundare");
            writer.Close();
        }

        private static void ReadFormatedTextFile()
        {
            string s;
            StreamReader reader = File.OpenText("D:\\b.txt");
            while ((s = reader.ReadLine()) != null)
            {
                Console.WriteLine(s);
            }
            reader.Close();
        }
    }
}