using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Frontend_Webapp.Data;

// Add profile data for application users by adding properties to the ApplicationUser class
public class ApplicationUser : IdentityUser
{
    public string FirstName { get; set; } = null!;
    public string LastName { get; set;} = null!;
    public string Biography { get; set; } = null!;
    public string? ProfileImage { get; set; } = "avatar.jpg";


    public int? AddressId { get; set; }
    public AddressEntity? Address { get; set; }
}

public class AddressEntity
{
    [Key]
    public int Id { get; set; }
    public string Address1 { get; set; } = null!;
    public string? Address2 { get; set; }
    public string PostalCode { get; set; } = null!;
    public string City { get; set; } = null!;


}