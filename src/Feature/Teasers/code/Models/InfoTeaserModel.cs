using Sitecore.Data.Fields;
using Sitecore.Data.Items;
using System.Collections.Generic;
using System.Linq;

namespace Sitecore.Feature.Teasers.Models
{
  public class InfoTeaserModel
  {
    public InfoTeaserModel(Item item)
    {
      this.Item = item;
      this.Title = item[Templates.InfoTeaser.Fields.Title];
      this.Text = item[Templates.InfoTeaser.Fields.Summary];
       
     var list = (MultilistField)item.Fields[Templates.InfoTeaser.Fields.InfoItems];
      var infoItems = list.GetItems();
      this.InfoItems = infoItems.Select(i=>new IconTeaserModel(i)).ToList();
    }

    public InfoTeaserModel()
    {

    }

    public Item Item { get; set; }
    public string Title { get; set; }
    public string Text { get; set; }
    public List<IconTeaserModel> InfoItems { get; set; }
  }
}