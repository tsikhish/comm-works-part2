using Newtonsoft.Json;
using System;
using System.IO;
using System.IO.Compression;
using System.IO.Enumeration;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json.Serialization;
namespace strategy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string fileName = ".txt";
            //string fileName = ".json";
            string fileName = ".zip";
            if (fileName == ".txt")
            {
                context context;
                context = new context(new strategyTXT());
                context.contextinterface();
            }
            if(fileName == ".zip")
            {
                context context;
                context = new context(new strategyZIP());
                context.contextinterface();
            }
            if (fileName == ".json")
            {
                context context;
                context = new context(new strategyJSON());
                context.contextinterface();
            }


        }
    }
    class context
    {
        strategy strategy;
        public context (strategy strategy)
        {
            this.strategy = strategy;
        }
        public void contextinterface()
        {
            strategy.algorithm();
        }
    }
    abstract class strategy
    {
        public abstract void algorithm();
    }
    class strategyJSON : strategy
    {
        public override void algorithm()
        {
            StreamReader r = new StreamReader(@"C:\Users\Mari\source\repos\homework13\strategy\jsonFile.json");
            var jsonString= r.ReadToEnd();
            Console.WriteLine(jsonString);
        }
    }
    class strategyZIP :strategy
    {
        public override void algorithm()
        {
            var inputFilePath = @"C:\Users\Mari\source\repos\homework13\strategy\myfolder\text.txt";
            var backUp = "backup";
            var rootDirectoryPath = new DirectoryInfo(inputFilePath).Parent.Parent.FullName;
            var backupDirectory = Path.Combine(rootDirectoryPath, backUp);
            if (!Directory.Exists(backupDirectory))
            {
                Console.WriteLine("trying to create new directory");
                Directory.CreateDirectory(backupDirectory);
            }
            else
            {
                if (File.Exists(inputFilePath) && Path.GetExtension(inputFilePath).Equals(".zip", StringComparison.OrdinalIgnoreCase))
                {
                    ZipFile.ExtractToDirectory(inputFilePath, backupDirectory);
                }
                else
                {
                    Console.WriteLine("Input file is not a valid ZIP archive.");
                }
            }
        }

    }
    class strategyTXT : strategy
    {
        public override void algorithm()
        {
            var inputFilePath = @"C:\Users\Mari\source\repos\homework13\strategy\myfolder\text.txt";
            string extension = Path.GetExtension(inputFilePath);
            if (extension == ".txt")
            {
                File.Delete(inputFilePath);
                Console.WriteLine("file deleted");
            }
            else
            {
                Console.WriteLine("file isnt txt file");
            }
        }

    }

}
