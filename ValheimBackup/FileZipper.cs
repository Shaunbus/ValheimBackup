using System;
using System.IO;
using System.IO.Compression;

namespace ValheimBackup
{
    class FileZipper
    {
        public void zipFile(string folder)
        {
            // Extracting current UserName for accurate pathname for source and target directory
            string currentUser = Environment.UserName;
            string nowTime = (DateTime.Now.ToString("yyyyMMdd-HHmm"));
            string sourceFilePath = @"C:\Users\" + currentUser + @"\AppData\LocalLow\IronGate\Valheim\" + folder;

            //This is the path that the .dll resides so wherever you run the exe it should place the backups there
            string destZipPath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + @"\" + folder + nowTime + @".zip";

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
