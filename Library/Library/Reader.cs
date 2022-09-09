using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Reader
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

        public void TakeBook(string reader, int booksQuantity)
        {
            Console.WriteLine($"{reader}, have {booksQuantity} book/s on his account");
        }
        public void TakeBook(string reader, params string[] books)
        {
            Console.WriteLine($"{reader}, have next book/s on his account:");
        }
        public int ReturnBook(int quantity)
        {
            return quantity;
        }

        public void AnswerInToTheBoard()
        {
            Console.WriteLine($"Full Name{FullName}, Membership: {membershipNumber}, Faculty: {Faculty}, " +
                        $"DAte of Birth: {DateOfBirth}, Phone Number: {PhoneNumber}");
        }
        //public int CountBooks()

    }
}
