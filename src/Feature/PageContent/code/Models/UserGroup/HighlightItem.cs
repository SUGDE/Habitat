using System;
using Sitecore.Data.Items;
using Sitecore.Data.Fields;

namespace Sitecore.Feature.PageContent.Models.UserGroup
{
  public class HighlightItem
  {
    public HighlightItem(Item item)
    {
      this.Item = item;
      this.Title = item[Templates.Highlight.Fields.Title];
      this.Text = item[Templates.Highlight.Fields.Text];
      DateField dateField = (DateField)item.Fields["Date Created"];

      // DateTime object
      this.DateCountdown = dateField.DateTime;
    }

    public Item Item { get; set; }
    public string Title { get; set; }
    public string Text { get; set; }
    public DateTime DateCountdown { get; set; }
  }
}