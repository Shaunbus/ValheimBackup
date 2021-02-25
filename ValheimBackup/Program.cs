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
            string userName = Environment.UserName;

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
                }
                else if (answer == "B" || answer == "b")
                {
                    newBackup.zipFile("characters");
                    newBackup.zipFile("worlds");
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
