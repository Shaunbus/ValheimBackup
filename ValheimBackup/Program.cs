using System;

namespace ValheimBackup
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string sourceDir = @"C:\Users\Shaun\Desktop\Projects\ValheimBackup\ValheimBackup\Test\characters.rar";
            string backupDir = @"C:\Users\Shaun\Desktop\Projects\ValheimBackup\ValheimBackup\Test\characters" + 1 + @".rar";

            System.IO.File.Copy(sourceDir, backupDir);
           
        }
    }
}
