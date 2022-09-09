using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_
{
    internal class Reader
    {
        private string fullName;
        private string membershipNumber;
        private string faculty;
        private DateTime dateOfBirth;
        private string phoneNumber;

        public string FullName { get; set; }
        public string MembershipNumber { get; set; }
        public string Faculty { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string PhoneNumber { get; set; }

        public Reader(string name, string membership, string faculty, DateTime birthDate, string phone)
        {
            FullName = name;
            MembershipNumber = membership;
            Faculty = faculty;
            DateOfBirth = birthDate;
            PhoneNumber = phone;
        }
        public void TakeBook(int number)
        {
            Console.WriteLine($"\n{FullName} borrowed: {number} book/s");
        }
        public void TakeBook(params string[] books)
        {
            Console.WriteLine($"\n{FullName} borrowed next book/s:");
            foreach (var book in books)
            {
                Console.WriteLine($" - {book}");
            }
        }
        public void TakeBook(params Book[] books)
        {
            Console.WriteLine($"\n{FullName} borrowed:");
            for (int i = 0; i < books.Length; i++)
            {
                Console.WriteLine(String.Format($"{0, -10} | {1, -10}Book title: {books[i].BookTitle}, by Author: {books[i].BookAuthor}"));
            }
        }
        public void ReturnBook(int number)
        {
            Console.WriteLine($"\n{FullName} returned: {number} book/s");
        }
        public void ReturnBook(params string[] books)
        {
            Console.WriteLine($"\n{FullName} reternad:");
            for(int i = 0; i < books.Length; i++)
            {
                Console.WriteLine($" - {books[i]}");
            }
        }
        public void ReturnBook(params Book[] books)
        {
            Console.WriteLine($"\n{FullName} return:");
            for (int i = 0; i < books.Length; i++)
            {
                Console.WriteLine($"Book title {books[i].BookTitle}, {books[i].BookAuthor}");
            }
        }
    }
}
