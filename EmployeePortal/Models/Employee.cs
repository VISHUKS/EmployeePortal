using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeePortal.Models
{
    public class Employee
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Full Name is required")]
        [StringLength(100, ErrorMessage = "Full Name cannot be longer then 100 characters")]
        public string FullName { get; set; } = null!;

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invaild Email Address")]
        public string Email { get; set; } = null!;

        [Required(ErrorMessage = "Department is required")]
        public int DepartmentId { get; set; }
        public Department Department { get; set; } = null!;

        [Required(ErrorMessage = "Designation is required")]
        public int DesignationId { get; set; }

        public Designation Designation { get; set; } = null!;

        [Required(ErrorMessage = "HireDate is required")]
        [DataType(DataType.Date)]
        public DateTime HireDate { get; set; }

        [Required(ErrorMessage = "DateOfBirth is required")]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }

        [Required(ErrorMessage = "EmployeeTypeId is required")]
        public int EmployeeTypeId { get; set; }
        public EmployeeType EmployeeType { get; set; } = null!;

        [Required(ErrorMessage = "Gender is required")]
        [StringLength(6, ErrorMessage = "Gender should be Male,Female or Others")]
        public string Gender { get; set; } = null!;

        [Required(ErrorMessage = "Salary is required")]
        [Range(0, double.MaxValue, ErrorMessage = "Salary must be positive")]
        [Column(TypeName = "decimal(18,2)")]

        public decimal Salary { get; set; }



    }
}
