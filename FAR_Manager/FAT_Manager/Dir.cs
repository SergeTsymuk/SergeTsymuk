using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FAT_Manager
{
    public class Dir
    {
            
            public void ShowFolders(string rootPath)
            {
            string[] dirs = Directory.GetDirectories(rootPath);
            Console.WriteLine(new string('=', 50));
            Console.WriteLine("||    Name    \t\t\t\t\t||");
            Console.WriteLine("|| ...\t\t\t\t\t\t||");
            
            foreach (string dir in dirs)
            {
                Console.WriteLine($"|| {Path.GetFileName(dir)} \t\t\t\t||");
            }
            }
            
            

            public void ShowFiles(string rootPath)
            {
            string[] files = Directory.GetFiles(rootPath);
            
            foreach (var file in files)
            {
                Console.WriteLine($"|| {file}             \t\t\t\t||");
            }
        }
    }
}
