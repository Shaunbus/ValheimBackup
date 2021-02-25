using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.IO.Compression;

namespace ValheimBackup
{
    class FileZip
    {
        public void zipFile(string folder)
        {
            // Extracting current UserName for accurate pathname for source and target directory
            // Setting up paths with Username in strings after
            string currentUser = Environment.UserName;
            DirectoryPath dirPath = new DirectoryPath(folder, currentUser);
            ZipPath zipPath = new ZipPath(folder, currentUser);

            string sourceFilePath = dirPath.GetPath();
            string destZipPath = zipPath.GetPath();

            //Want to Zip File here
            try
            {
                Console.WriteLine("Backing up");
                ZipFile.CreateFromDirectory(sourceFilePath, destZipPath, CompressionLevel.Fastest, true);
                Console.WriteLine("File Backed up");
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
