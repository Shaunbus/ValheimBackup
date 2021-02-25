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
            
            newBackup.zipFile("characters");
            newBackup.zipFile("worlds");
            
        }
    }
}
