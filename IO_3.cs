using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Compression;

namespace IO_3
{
    class IO_3
    {
        static FileInfo Find(string path, string file)
        {
            DirectoryInfo dir = new DirectoryInfo(path);
            FileInfo res = dir.GetFiles(file).FirstOrDefault();
            if (res ==null)
            {
                foreach (DirectoryInfo d in dir.GetDirectories())
                {
                    if((d.Attributes & FileAttributes.System) == FileAttributes.System || (d.Attributes & FileAttributes.Archive) == FileAttributes.Archive || (d.Attributes & FileAttributes.Hidden) == FileAttributes.Hidden) { continue; }
                    if ((res = Find(d.FullName, file)) != null) {  break; }
                }
            }
            else { Console.WriteLine("Найдено: "+res.FullName); return res; }
            return res;
        }

        static void ShowFile(string filePath)
        {
            using (FileStream fs = new FileStream(filePath, FileMode.Open))
            {
                byte[] byteText = new byte[fs.Length];
                fs.Read(byteText, 0, byteText.Length);
                string readText = Encoding.Default.GetString(byteText);
                Console.WriteLine("Текст из файла:\n" + readText);
            }
        }

        static void CompressFile(string inputFilePath, string compressedFilePath)
        {
            Console.WriteLine("Сжатие:");
            using (FileStream infs = new FileStream(inputFilePath, FileMode.Open))
            {
                using (FileStream resfs = new FileStream(compressedFilePath, FileMode.CreateNew))
                {
                    using (GZipStream compfs = new GZipStream(resfs, CompressionMode.Compress))
                    {
                        infs.CopyTo(compfs);
                        Console.WriteLine("Сжатие завершено.\nРазмер сжатого файла: " + resfs.Length + ".\nРазмер исходного файла: " + infs.Length);
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            try
            {
                Console.Write("Введите имя диска [D|C|...]: ");
                string driveName = Console.ReadLine() + @":\";
                Console.Write("Введите имя файла: ");
                string fileName = Console.ReadLine();
                FileInfo file = Find(driveName, fileName);
                if (file != null)
                {
                    string show = "";
                    while (show != "д" && show != "н")
                    {
                        Console.WriteLine("Хотите просмотреть файл? [д/н]");
                        show = Console.ReadLine();
                    }
                    if (show == "д")
                    {
                        ShowFile(file.FullName);
                    }

                    string compress = "";
                    while (compress != "д" && compress != "н")
                    {
                        Console.WriteLine("Хотите сжать файл? [д/н]");
                        compress = Console.ReadLine();
                    }
                    if (compress == "д")
                    {
                        CompressFile(file.FullName, file.FullName + ".gz");
                    }
                }
                else { Console.WriteLine("Не найдено."); }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            Console.ReadKey();
        }
    }
}
