using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace razor_page_lab3;

public class User
{
    public int UserId { get; set; }
    public string? Name { get; set; }
    [DataType(DataType.Password)]
    public string? Password { get; set; }

    [NotMapped, DataType(DataType.Password)]
    [Compare(nameof(Password), ErrorMessage = "Password do not match!")]
    public string? VerifyPassword { get; set; }

    [RegularExpression(@"^([a-zA-Z0-9_\-\.]+)@([a-zA-Z0-9_\-\.]+)\.([a-zA-Z]{2,5})$", ErrorMessage = "Please enter the valide email!")]
    public string? Email { get; set; }
    public string? Phone { get; set; }
    public int StreetNumber { get; set; }

    public string? StreetName { get; set; }

    [RegularExpression(@"^[A-Za-z][0-9][A-Za-z]【 】*[0-9][A-Za-z][0-9]$", ErrorMessage = "Please type valide postalcode!")]
    public string? Postalcode { get; set; }
    [Required]
    public string? City { get; set; }
    public string? Province { get; set; }
}