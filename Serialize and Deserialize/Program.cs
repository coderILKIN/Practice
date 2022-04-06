using Serialize_and_Deserialize.Models;
using System;
using System.IO;

namespace Serialize_and_Deserialize
{
    class Program
    {
        static void Main(string[] args)
        {
            //string filePath = Path.Combine(@"C:/Users/ilkin/OneDrive/Masaüstü/ap200Directory", "text.txt");
            //Console.WriteLine(filePath);
            //string path = @"C:/Users/ilkin/OneDrive/Masaüstü/ap200Directory";
            //string anotherPath = Path.Combine(@"C:/Users/ilkin/OneDrive/Masaüstü/ap200Directory", "Parviz");
            //string DbPath = Path.Combine(@"C:/Users/ilkin/OneDrive/Masaüstü/ap200Directory", "Parviz","Db.txt");
            //string abouthPath = Path.Combine(@"C:/Users/ilkin/OneDrive/Masaüstü/ap200Directory", "Parviz", "about.txt");
            //string galeryPath = Path.Combine(@"C:/Users/ilkin/OneDrive/Masaüstü/ap200Directory", "Parviz", "galery.txt");





            //StreamWriter streamWriter = new StreamWriter(DbPath,true);
            // streamwriter.write("hello world");
            //streamwriter.writeline("hello world");
            //streamwriter.writeline("hello world");
            //streamwriter.writeline("hello world");
            //streamwriter.writeline("hello world");
            //streamwriter.flush();
            //streamWriter.Close();

            //StreamReader streamReader = new StreamReader(DbPath);

            //string data = streamReader.ReadLine();
            //string data = streamReader.ReadToEnd();
            //Console.WriteLine(data);

            //streamReader.Close();

            //using (StreamWriter streamWriter = new StreamWriter(DbPath, true))
            //{
            //    for (int i = 1; i < 5; i++)
            //    {
            //        streamWriter.WriteLine("world");
            //    }
            //}

            //using (StreamReader streamReader = new StreamReader(DbPath))
            //{
            //    string data = streamReader.ReadToEnd();
            //    Console.WriteLine(data);
            //}


            //Directory.CreateDirectory(anotherPath);
            //File.Create(filePath);
            //File.Create(DbPath);
            //File.Create(abouthPath);
            //File.Create(galeryPath);
            //Directory.Delete(path,true);

            //foreach (var item in Directory.GetFiles(anotherPath))
            //{
            //    Console.WriteLine(item);
            //}

            //foreach (var item in Directory.GetDirectories(@"C:/Users/ilkin/OneDrive/Masaüstü/ap200Directory/Ilkin"))
            //{
            //    Console.WriteLine(item);
            //}

            //if (File.Exists(filePath))
            //{
            //    File.Delete(filePath);
            //}
            //else
            //{
            //    Console.WriteLine("Bele bir fayl yoxdur");
            //}

            Computer computer = new Computer {Id =1, Brand = "Acer", Ram="8gb", GraphicCard= "Intel", Price = 600.30};
            Computer computer1 = new Computer { Id = 1, Brand = "Asus", Ram = "8gb", GraphicCard = "Amd", Price = 1000.30 };
            Computer computer2 = new Computer { Id = 1, Brand = "Acernitro", Ram = "32gb", GraphicCard = "RTX3090", Price = 3000.30 };

        }
    }
}
