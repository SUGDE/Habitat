namespace Sitecore.Feature.Accounts.Models
{
  using System.ComponentModel.DataAnnotations;
  using Texts;

  public class SubscribeNews
  { 
      [Display(Name = nameof(Captions.FirstName), ResourceType = typeof(Captions))]
      [Required]
      public string FirstName { get; set; }

      [Display(Name = nameof(Captions.LastName), ResourceType = typeof(Captions))]
    [Required]
    public string LastName { get; set; }

      [Display(Name = nameof(Captions.Email), ResourceType = typeof(Captions))]
    [Required]
    public string Email { get; set; } 
  }
}
