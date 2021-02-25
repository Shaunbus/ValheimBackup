using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.IO.Compression;

namespace ValheimBackup
{
    class FileZipper
    {
        public void zipFile(string folder)
        {
            // Extracting current UserName for accurate pathname for source and target directory
            // Setting up paths with Username in strings after
            string currentUser = Environment.UserName;
            string nowTime = (DateTime.Now.ToString("yyyyMMdd-HHmm"));


            //Test Path
            //string sourceFilePath = @"C:\Users\" + currentUser + @"\Desktop\Coding\Projects\ValheimBackup\ValheimBackup\Test\" + folder;

            //Real Path
            string sourceFilePath = @"C:\Users\" + currentUser + @"\AppData\LocalLow\IronGate\Valheim\" + folder;

            //test zip path
            //string destZipPath = @"C:\Users\" + currentUser + @"\Desktop\Coding\Projects\ValheimBackup\ValheimBackup\Test\" + folder + nowTime + @".zip";
            string destZipPath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + @"\" + folder + nowTime + @".zip";

            //Want to Zip File here
            try
            {
                Console.WriteLine("backing up " + folder);
                ZipFile.CreateFromDirectory(sourceFilePath, destZipPath, CompressionLevel.Fastest, true);
                Console.WriteLine(folder + " backed up");
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
