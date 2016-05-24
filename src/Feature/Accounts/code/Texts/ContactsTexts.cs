
using Sitecore.Foundation.SitecoreExtensions.Repositories;

namespace Sitecore.Feature.Accounts.Texts
{
  public class ContactsTexts
  {
    public static string Title => DictionaryRepository.Get("/Accounts/ContactsTexts/Title", "Fragen und Anregungen?"); 
  }
}