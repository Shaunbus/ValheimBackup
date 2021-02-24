using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ValheimBackup
{
    class DirectoryPaths
    {
        //extracting curret user
        string currentUser = Environment.UserName;
        public string GetSourcePath(string folder)
        {
            //Test Path
            string charDirPath = @"C:\Users\" + currentUser + @"\Desktop\Coding\Projects\ValheimBackup\ValheimBackup\Test\" + folder;

            //Real Path
            //string charDirPath = @"C:\Users\" + currentUser + @"\AppData\LocalLow\IronGate\Valheim\" + folder;

            return charDirPath;
        }

        public string GetZipPath(string folder)
        {
            string nowTime = (DateTime.Now.ToString("yyyyMMdd-HHmm"));
            string charZipPath = @"C:\Users\" + currentUser + @"\Desktop\Coding\Projects\ValheimBackup\ValheimBackup\Test\" + folder + nowTime + @".zip";

            //Console.WriteLine(Environment.CurrentDirectory);

            return charZipPath;
        }
    }
}
