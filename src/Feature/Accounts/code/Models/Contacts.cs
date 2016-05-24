namespace Sitecore.Feature.Accounts.Models
{
  using Foundation.SitecoreExtensions.Repositories;
  using System.ComponentModel.DataAnnotations;
  using Texts;

  public class Contacts
  {
    public static string RegisterButton => DictionaryRepository.Get("/Accounts/SubscribeNews/RegistrationButton", "Register");

    [Display(Name = nameof(Captions.YourName), ResourceType = typeof(Captions))]
    [Required]
    public string Name { get; set; }

    [Display(Name = nameof(Captions.Subject), ResourceType = typeof(Captions))] 
    [Required]
    public string Subject { get; set; }


    [Display(Name = nameof(Captions.YourNews), ResourceType = typeof(Captions))]
    [Required]
    public string News { get; set; }

    [Display(Name = nameof(Captions.YourEmail), ResourceType = typeof(Captions))]
    [Required]
    public string Email { get; set; }
  }
}
