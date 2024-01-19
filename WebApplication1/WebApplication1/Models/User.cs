

using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models {

[Table("users")]
public class User {

    public long Id { get; set; }

    [MinLength(4, ErrorMessage = "The minimum lenght is 4 characters for username")]
    [Required(ErrorMessage = "The username field is required")]
    public string Username { get; set; } = null!;

    [MinLength(8, ErrorMessage = "The minimum length of the password are 8 characters")]
    [Required(ErrorMessage = "The password field is required")]
    public string Password { get; set; }

    [DefaultValue(3)]
    [Required(ErrorMessage = "Select a valid role for this user")]
    public int RoleId { get; set; }

    public virtual Role Role { get; set; }
}

}
