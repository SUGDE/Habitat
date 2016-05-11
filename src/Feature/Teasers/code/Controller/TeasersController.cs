namespace Sitecore.Feature.Teasers.Controller
{
  using System.Web.Mvc;
  using Sitecore.Feature.Teasers.Models;
  using Sitecore.Mvc.Presentation;

  public class TeasersController : Controller
  {
    public ActionResult AccordeonTeaser()
    {
      var model = new AccordeonModel(RenderingContext.Current.Rendering.Item);
      return this.View("AccordeonTeaser", model);
    }

    public ActionResult IcoTeaser()
    {
      var model = new IconTeaserModel(RenderingContext.Current.Rendering.Item);
      return this.View("~/Views/PageContent/UserGroup/IcoTeaser.cshtml", model);
    }

    public ActionResult LeftIcoTeaser()
    {
      var model = new IconTeaserModel(RenderingContext.Current.Rendering.Item);
      return this.View("~/Views/PageContent/UserGroup/LeftIcoTeaser.cshtml", model);
    }
  }
}