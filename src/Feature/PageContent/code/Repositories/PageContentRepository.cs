using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sitecore.Feature.PageContent.Repositories
{
  public class PageContentRepository : IPageContentRepository
  {
    public Item ContextItem { get; }

    public PageContentRepository(Item contextItem)
    {
      ContextItem = contextItem;
    }

    public HighlightItem GetHighlightItem()
    {
      return new HighlightItem(ContextItem);
    }
  }
}