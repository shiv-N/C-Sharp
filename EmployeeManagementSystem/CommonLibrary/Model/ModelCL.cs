using System;
using System.ComponentModel.DataAnnotations;
namespace CommonLibrary
{
    public class ModelCL
    {
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Age { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string EmployeeAddress { get; set; }
    }
}
