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

            string charDirPath = new DirectoryPaths().GetSourcePath(folder);
            string charZipPath = new DirectoryPaths().GetZipPath(folder);

            //Want to Zip File here
            try
            {
                ZipFile.CreateFromDirectory(charDirPath, charZipPath, CompressionLevel.Fastest, true);
            }
            catch (IOException e)
            {
                //Console.WriteLine("File already exists");
                Console.WriteLine(e.Message);
            }
        }
    }
}
