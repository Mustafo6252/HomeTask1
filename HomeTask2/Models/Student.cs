using System.ComponentModel.DataAnnotations;

namespace HomeTask2.Models;

public class Student
{
    [Required]
    public int Id { get; set; }
    [Required]
    [MaxLength(20)]
    public string FirstName { get; set; }
    [Required]
    [MaxLength(20)]
    public string LastName { get; set; }
    [Required]
    [MaxLength(20)]
    public double Score { get; set; }
    [Required]
    [MaxLength(20)]
    public string Phone { get; set; }
}