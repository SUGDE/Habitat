﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sitecore.Feature.PageContent.Repositories
{
    public interface IPageContentRepository
    {
        HighlightItem GetHighlightItem();
    }
}