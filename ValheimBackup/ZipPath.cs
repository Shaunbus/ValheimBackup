using System;
using System.Collections.Generic;
using System.Text;

namespace ValheimBackup
{
    class ZipPath : Paths
    {

        private string userName;
        private string folderPath;

        public ZipPath(string folder, string user)
        {
            folderPath = folder;
            userName = user;
        }
        //extracting current time down to the minute and adding it to the filepath of the compressed file
        public string GetPath()
        {
            //excracting current time
            string nowTime = (DateTime.Now.ToString("yyyyMMdd-HHmm"));

            //Test Path
            string charZipPath = @"C:\Users\" + userName + @"\Desktop\Coding\Projects\ValheimBackup\ValheimBackup\Test\" + folderPath + nowTime + @".zip";

            //Real Path


            //Console.WriteLine(Environment.CurrentDirectory);

            return charZipPath;
        }
    }
}
