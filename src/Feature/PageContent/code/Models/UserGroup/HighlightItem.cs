using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sitecore.Feature.PageContent.Models.UserGroup
{
    public class HighlightItem
    {
        public HighlightItem(Item item)
        {
            this.Item = item;
            this.Text = item.
        }

        public Item Item { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public DateTime DateCountdown { get; set; }
    }
}