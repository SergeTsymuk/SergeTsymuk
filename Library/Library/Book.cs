using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Book
    {
        private string bookTitle;
        private string bookAuthor;
        //int quantity;

        public string BookTitle { get; set; }
        public string BookAuthor { get; set; }
        public int Quantity { get; set; }
        
        //public Book(int quantity)
        //{
        //    Quantity = quantity;
        //}
        public Book(string title, string author)
        {
            BookAuthor = author;
            bookTitle = title;
        }

        public int CountBooks(params int[] books)
        {
            return Quantity = books.Length;
        }

        public void ShowBooks(string reader, params int[] books)
        {
            foreach (var item in books)
            {
                Console.WriteLine($"{books}, ");
            }
        }
    }
}
