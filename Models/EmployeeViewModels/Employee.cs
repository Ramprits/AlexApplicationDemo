using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AlexApplicationDemo.Models.EmployeeViewModels
{
     public class Employee
     {
          [Key]
          [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
          public int EmployeeId { get; set; }
          [Required]
          public string EmployeeName { get; set; }
          [Required]
          public Gender Gender { get; set; }
          [Required]
          public string Email { get; set; }
          public string MobileNumber { get; set; }

          public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
          [ForeignKeyAttribute("DepartmentId")]
          public int DepartmentId { get; set; }
          public virtual Department Departments { get; set; }
     }

     public enum Gender
     {
          Male = 1,
          Female = 2,
          Student = 3
     }
}