
using Sitecore.Foundation.SitecoreExtensions.Repositories;

namespace Sitecore.Feature.Accounts.Texts
{
  public class SubscribeNewsTexts
  {
    public static string Title => DictionaryRepository.Get("/Accounts/SubscribeNews/Title", "Newsletter");
    public static string Subtitle => DictionaryRepository.Get("/Accounts/SubscribeNews/Subtitle", "RegisterSubtitle");
    public static string RegisterButton => DictionaryRepository.Get("/Accounts/SubscribeNews/RegistrationButton", "Register");
  }
}