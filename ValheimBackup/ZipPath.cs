using System;
using System.Collections.Generic;
using System.Text;

namespace ValheimBackup
{
    class ZipPath : Paths
    {
        string currentUser = Environment.UserName;
        //extracting current time down to the minute and adding it to the filepath of the compressed file
        public string GetSourcePath(string folder)
        {
            //excracting current time
            string nowTime = (DateTime.Now.ToString("yyyyMMdd-HHmm"));

            //Test Path
            string charZipPath = @"C:\Users\" + currentUser + @"\Desktop\Coding\Projects\ValheimBackup\ValheimBackup\Test\" + folder + nowTime + @".zip";

            //Real Path


            //Console.WriteLine(Environment.CurrentDirectory);

            return charZipPath;
        }
    }
}
