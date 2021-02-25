using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ValheimBackup
{
    class DirectoryPath : Paths
    {
        private string userName;
        private string folderPath;

        public DirectoryPath(string folder, string user)
        {
            folderPath = folder;
            userName = user;
        }
        
        public string GetPath()
        {
            //Test Path
            return @"C:\Users\" + userName + @"\Desktop\Coding\Projects\ValheimBackup\ValheimBackup\Test\" + folderPath;

            //Real Path
            //string charDirPath = @"C:\Users\" + currentUser + @"\AppData\LocalLow\IronGate\Valheim\" + folder;

        }

        
    }
}
