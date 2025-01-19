

using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRUD_MVC.Models;

[Table("StudentsRecords")]
public class Student
{
    [Column("StudentId")]
    public int Id { get; set; }

    [Required(ErrorMessage ="Student Name is required"), StringLength(100,ErrorMessage = "Student's name cannot exceed 100 characters."), DisplayName("Enter Student Name")]
    [Column("StudentName")]
    public string Name { get; set; }

    [Required(ErrorMessage ="Student's Age is required"),DisplayName("Enter Student Age")]
    public int Age { get; set; }

    [Required(ErrorMessage ="Please Enter Student Cource"), StringLength(20,ErrorMessage = "Student's Course cannot exceed 100 characters."),DisplayName("Enter Student Course")]
    public string Course { get; set; }
    [NotMapped]
    public string? Description { get; set; }
    [StringLength(50, ErrorMessage = "Student's FatherName cannot exceed 100 characters."),DisplayName("Enter Student's Father Name")]
    public string? FatherName { get; set; }
}
