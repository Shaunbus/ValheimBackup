using System;

namespace ValheimBackup
{
    class Program
    {
        static void Main(string[] args)
        {
            // Extracting current UserName for accurate pathname for source and target directory
            // Setting up paths with Username in strings after

            string currentUser = Environment.UserName;
            string sourceDir = @"C:\Users\" + currentUser + @"\Desktop\Projects\ValheimBackup\ValheimBackup\Test\characters.rar";
            string backupDir = @"C:\Users\" + currentUser + @"\Desktop\Projects\ValheimBackup\ValheimBackup\Test\characters" + 1 + @".rar";

            //Copying File
            System.IO.File.Copy(sourceDir, backupDir);
           
        }
    }
}
