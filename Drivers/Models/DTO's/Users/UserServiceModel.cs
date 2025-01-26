using System.ComponentModel.DataAnnotations;
using Drivers.Models.DTO_s.Bank_Cards;
using Microsoft.EntityFrameworkCore;


public class UserServiceModel
{
    [Key]
    public Guid Id { get; set; }

    [Required, MaxLength(100)]
    public string FirstName { get; set; } = "";

    [Required, MaxLength(100)]
    public string LastName { get; set; } = "";
    [Required, MaxLength (10),Unicode]
    public string PublicId { get; set; } = "";

    [Required, EmailAddress]
    public string Email { get; set; } = "";

    [Required]
    public DateTime DateOfBirth { get; set; }

    [Required]

    public ICollection<BankCardServiceModel> BankCards { get; set; } = new List<BankCardServiceModel>();
    public bool IsActive { get; set; } = true;


}
