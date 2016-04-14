using System;
using System.Web.Mvc;
using System.Web.Security;
using Sitecore;
using Sitecore.Diagnostics;
using Sitecore.Feature.Accounts.Attributes;
using Sitecore.Feature.Accounts.Models;
using Sitecore.Feature.Accounts.Repositories;
using Sitecore.Feature.Accounts.Services;
using Sitecore.Feature.Accounts.Texts;
using Sitecore.Foundation.SitecoreExtensions.Extensions;

namespace Sitecore.Feature.Accounts.Controllers
{
  public class UgAccountsController : AccountsController
  { 
    public ActionResult SubscribeNews()
    { 
      return this.View("~/Views/Accounts/UserGroup/SubsribeNews.cshtml", new SubscribeNews());
    }

    [HttpPost] 
    public ActionResult SubscribeNews(SubscribeNews model)
    {
      return this.View("~/Views/Accounts/UserGroup/SubsribeNews.cshtml", model);
    }
  }
}