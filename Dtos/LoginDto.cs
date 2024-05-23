using System.ComponentModel.DataAnnotations;

namespace AuthApi.Dtos
{
  public class Login
  {
    [Required]
    public string? Username { get; set; }
    [Required]
    public string? Password { get; set; }
  }
}