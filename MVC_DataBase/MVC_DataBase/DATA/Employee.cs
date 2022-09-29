using System.ComponentModel.DataAnnotations;
using X.PagedList;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC_DataBase.DATA
{
    public class Employee
    {
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Department { get; set; }
        [Required]
        public decimal Basic { get; set; }
        [Required]
        public decimal DA { get; set; }
        [Required]
        public decimal HRA { get; set; }
        [Required]
        public decimal NetSalary { get; set; }
        [Required]
        [DataType(DataType.EmailAddress, ErrorMessage ="Email is not valid!") ]
        public string Email { get; set; }
        [Required]
        public string WebUrl { get; set; }
        [Required]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Phone number format: 123-456-7890")]
        public string PhoneNumber { get; set; }
    }
}
