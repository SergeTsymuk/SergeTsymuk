using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strim
{
    public class StreamEx
    {
        public void DoWork()
        {
            string path = @"SomeDir";
            DirectoryInfo dir = new DirectoryInfo(path);

            if (!dir.Exists)
            {
                dir.Create();
            }
            var file = new FileInfo($"{path}/note.txt");

            using (FileStream fs = file.Open(FileMode.OpenOrCreate, FileAccess.ReadWrite))
            {
                byte[] bArr = Encoding.Default.GetBytes("My name is Serge!");
                fs.Write(bArr, 0, bArr.Length);
            }
            using (FileStream fs = file.OpenRead())
            {
                byte[] data = new byte[fs.Length];
                fs.Read(data, 0, data.Length);
                string str = Encoding.Default.GetString(data);
                Console.WriteLine(str);
            }

        }
    }
}
