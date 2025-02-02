using System.ComponentModel.DataAnnotations;

namespace Firstcore.Models;

public class User
{
    [Required(ErrorMessage = "Username is required")]
    public string UserName { get; set; }

    [Required(ErrorMessage = "Password is required")]
    public string Password { get; set; }
}