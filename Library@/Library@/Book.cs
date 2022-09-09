using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_
{
    internal class Book
    {
        private string bookTitle;
        private string bookAuthor;
        
        public string BookTitle { get; set; }
        public string BookAuthor { get; set; }

        public Book(string title, string author)
        {
            BookAuthor = author;
            BookTitle = title;
        }
    }
}
