using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ValheimBackup
{
    class DirectoryPath : Paths
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

        
    }
}
