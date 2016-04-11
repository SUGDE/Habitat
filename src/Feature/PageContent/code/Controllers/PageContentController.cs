using Sitecore.Feature.PageContent.Repositories;
using Sitecore.Mvc.Presentation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace Sitecore.Feature.PageContent.Controllers
{
    public class PageContentController : Controller
    {
        private readonly IPageContentRepository _pageContentRepository;

        public PageContentController() : this(new PageContentRepository(RenderingContext.Current.Rendering.Item))
        {
        }

        public PageContentController(IPageContentRepository pageContentRepository)
        {
            this._pageContentRepository = pageContentRepository;
        }

        public ActionResult HighlightItem()
        {
            var item = this._pageContentRepository.GetHighlightItem();
            return this.View("Highlight", item);
        }
    }
}