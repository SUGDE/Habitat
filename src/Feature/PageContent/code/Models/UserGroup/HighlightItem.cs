using System;
using System.Web;
using Sitecore.Data.Items;
using Sitecore.Data.Fields;
using Sitecore.Web.UI.WebControls;

namespace Sitecore.Feature.PageContent.Models.UserGroup
{
  public class HighlightItem
  {
    public HighlightItem(Item item)
    {
      this.Item = item;
      this.Title = new HtmlString(FieldRenderer.Render(item, Templates.Highlight.Fields.Title.ToString()));
      this.Text = new HtmlString(FieldRenderer.Render(item, Templates.Highlight.Fields.Text.ToString()));

      DateCountdown = new HtmlString(FieldRenderer.Render(item, Templates.Highlight.Fields.Date_Countdown.ToString()));
       
      DateCountdownStr = ((DateField)item.Fields[Templates.Highlight.Fields.Date_Countdown]).DateTime.ToString("MM dd yyyy HH:mm:ss");

      // DateTime object
      //this.DateCountdown = dateField.DateTime;
      //this.DateCountdownStr = dateField.DateTime.ToString("MM dd yyyy HH:mm:ss");
    }

    public Item Item { get; set; }
    public HtmlString Title { get; set; }
    public HtmlString Text { get; set; }
    public HtmlString DateCountdown { get; set; }
    public string DateCountdownStr { get; set; } 
  }
}