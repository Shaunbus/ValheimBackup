using System;
using System.IO;
using System.IO.Compression;

namespace ValheimBackup
{
    /// <summary>
    /// to do - backup folder
    /// 
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            FileZipper newBackup = new FileZipper();
            string userName = Environment.UserName;
            Console.WriteLine(System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location));
            Console.WriteLine("Is the user " + userName + "? Type 'Y' if correct."); 
            string answer = Console.ReadLine();
            if (answer == "Y" || answer == "y")
            {
                Console.WriteLine("What would you like to backup? Type 'C' for characters, 'W' for worlds, or 'B' for both.");
                answer = Console.ReadLine();
                if (answer == "C" || answer == "c")
                {
                    newBackup.zipFile("characters");
                    return;
                }
                else if (answer == "W" || answer == "w")
                {
                    newBackup.zipFile("worlds");
                    return;
                }
                else if (answer == "B" || answer == "b")
                {
                    newBackup.zipFile("characters");
                    newBackup.zipFile("worlds");
                    return;
                }
                else 
                {
                    return;
                }
            }
            else
            {
                return;
            }
        }
    }
}
