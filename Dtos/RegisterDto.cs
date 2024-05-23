using System.ComponentModel.DataAnnotations;

namespace Dtos;

public class Register
{
  [Required]
  public string? Email { get; set; }
  [Required]
  public string? Password { get; set; }
  public string? Name { get; set; }
  [Required]
  public string? Username { get; set; }
  [Required]
  public bool? isPrivate { get; set; }
  [Required]
  public DateTime? CreatedAt { get; set; }
  [Required]
  public DateTime? LastUpdated { get; set; }
}
