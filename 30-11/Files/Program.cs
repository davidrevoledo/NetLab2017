using System;
using System.IO;
using System.Text;

namespace Files
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //Directory();
            //WriteLinesAndRead();
            //GetFilesFromDirectory();
            //OpenFile();
            //StreamWriterReader();
            //BinaryWriterReader();

            Console.ReadLine();
        }

        private static void BinaryWriterReader()
        {
            var textFilePath = @"C:\test\sample4.txt";

            FileInfo datFile = new FileInfo(textFilePath);

            BinaryWriter bw = new BinaryWriter(datFile.OpenWrite());

            var randText = "Random text";
            int myAge = 4;
            double h = 6.25;

            bw.Write(randText);
            bw.Write(myAge);
            bw.Write(h);

            bw.Close();

            BinaryReader br = new BinaryReader(datFile.OpenRead());
            Console.WriteLine(br.ReadString());
            br.Close();
        }

        private static void StreamWriterReader()
        {
            // StreamReader, StreamWriter

            var textFilePath = @"C:\test\sample4.txt";

            //if (!File.Exists(textFilePath))
            //    File.Create(textFilePath);

            StreamWriter sw = File.CreateText(textFilePath);
            //sw.Write("This is a random ");
            //sw.WriteLine("This is a another sentences");
            sw.WriteLine("First Line");
            sw.WriteLine("Secod Line");

            sw.Close();

            StreamReader sr = File.OpenText(textFilePath);

            var s = sr.ReadToEnd();

            Console.WriteLine(sr.ReadToEnd());
            //sr.Peek();
            //sr.ReadLine();
            //sr.ReadToEnd();
        }

        private static void OpenFile()
        {
            var textFilePath = @"C:\test\sample2.txt";

            // Open File

            // write bytes
            var fs = File.Open(textFilePath, FileMode.Create);

            var randString = "This is a random string";
            var rsBytesArray = Encoding.ASCII.GetBytes(randString);

            fs.Write(rsBytesArray, 0, rsBytesArray.Length);
            fs.Position = 0;

            // read bytes
            byte[] fileByteArray = new byte[rsBytesArray.Length];

            for (var i = 0; i < rsBytesArray.Length; i++)
                fileByteArray[i] = (byte) fs.ReadByte();

            Console.WriteLine(Encoding.ASCII.GetString(fileByteArray));

            fs.Close();
        }

        private static void GetFilesFromDirectory()
        {
            var current = new DirectoryInfo(@"C:\test");

            // Get Files from Directory
            var txtFiles = current.GetFiles("*.txt");

            foreach (var file in txtFiles)
            {
                Console.WriteLine($"Archivo : {file.Name}");
                Console.WriteLine($"ReadOnly : {file.IsReadOnly}");
            }
        }

        private static void WriteLinesAndRead()
        {
            var textFilePath = @"C:\test\sample.txt";
            // Files 
            string[] test =
            {
                "David",
                "Net",
                "Lab"
            };

            File.WriteAllLines(textFilePath, test);

            foreach (var line in File.ReadAllLines(textFilePath))
                Console.WriteLine(line);
        }

        private static void Directory()
        {
            var current = new DirectoryInfo(@"C:\test");

            Console.WriteLine(current.FullName);
            Console.WriteLine(current.Name);
            Console.WriteLine(current.CreationTime);

            current.Delete(true);
        }
    }
}