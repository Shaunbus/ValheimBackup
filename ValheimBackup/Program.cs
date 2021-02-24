using System;
using System.IO;
using System.IO.Compression;

namespace ValheimBackup
{
    class Program
    {
        static void Main(string[] args)
        {
            FileZip newBackup = new FileZip();
            Console.WriteLine("Backing up");
            newBackup.zipFile("characters");
            Console.WriteLine("File Backed up");
        }
    }
}
