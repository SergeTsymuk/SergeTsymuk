using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00001
{
    internal class Reader
    {
        Library library = new Library();
        //Lazy<Library> library = new Lazy<Library>();
        public void ReadBook()
        {
            library.GetBook();
            Console.WriteLine("Reading papar book");
        }

        public void ReadEbook()
        {
            Console.WriteLine("Reeding book on the computer");
        }
    }
}
