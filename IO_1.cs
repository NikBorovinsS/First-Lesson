using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace IO_1
{
    class IO_1
    {
        static void Main(string[] args)
        {
            string path = @"C:\TestDir";
            string subpath;

            const int maxFolder = 99;

            DirectoryInfo DI = new DirectoryInfo(path);

            if (!DI.Exists)
            {
                DI.Create();
            }

            for (int i = 0; i <= maxFolder; ++i)
            {
                subpath = "Folder_" + i.ToString();
                DI.CreateSubdirectory(subpath);
            }
            Console.ReadKey();

            DI.Delete(true);
        }
    }
}
