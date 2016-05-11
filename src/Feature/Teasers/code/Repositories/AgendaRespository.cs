namespace Sitecore.Feature.Teasers.Repositories
{
  using System.Collections.Generic;
  using System.Linq;
  using Sitecore.Data.Items;
  using Sitecore.Diagnostics;
  using Sitecore.Foundation.SitecoreExtensions.Extensions;

  public static class AgendaElementsRespository
  {
    public static IEnumerable<Item> Get(Item item)
    {
      Assert.IsNotNull(item, "item");
      return item.GetMultiListValues(Templates.AccordionElementTeaser.Fields.Presenters);
    }
  }
}