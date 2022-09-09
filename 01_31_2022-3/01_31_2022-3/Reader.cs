using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_31_2022_3
{
    internal class Reader
    {
        private string fullName;
        private double membershipNumber;
        private string department;
        private string dateOfBirth;
        private string phone;

        public string[] books =
            {
            "THE GREAT GATSBY", "A PORTRAIT OF THE ARTIST AS A YOUNG MAN", "BRAVE NEW WORLD", "THE SOUND AND THE FURY", "DARKNESS AT NOON",
            "SONS AND LOVERS", "THE GRAPES OF WRATH", "UNDER THE VOLCANO", "THE WAY OF ALL FLESH", "TO THE LIGHTHOUSE", "AN AMERICAN TRAGEDY"
            }; 

        public void TakeBook(string fullName, int countOfBooks)
        {
            Console.WriteLine($"{fullName}, have {countOfBooks}");
        }
        public void TakeBook(string fullName, ????)
        {
            for (int i = 0; i < books.Length; i++)
            {
                Console.WriteLine($"{fullName}, have {books[i]}");
            }
        }
        public void TakeBook(string fullName
            {
            Console.WriteLine($"{fullName}, 0" +
                $"");
            }
        public void ReturnBook(string fullName, int countOfBooks)
        {
            Console.WriteLine($"{fullName}, returned {countOfBooks}");
        }
        public void ReturnBook(string fullName, ????)
        {
            for (int i = 0; i < books.Length; i++)
            {
                Console.WriteLine($"{fullName}, have {books[i]}");
            }
            ;
        }
    }
}
