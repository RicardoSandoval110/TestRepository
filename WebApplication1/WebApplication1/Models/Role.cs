
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models {

[Table("roles")]
public class Role {

    [Key]
    public int Id { get; set; }

    [Required(ErrorMessage = "The name of the role is required")]
    public string Name { get; set; }

    public virtual List<User> Users { get; }

}

}