namespace Sitecore.Feature.Teasers.Models
{
  using Data.Items;

  public class IconTeaserModel
  {
    public IconTeaserModel(Item item)
    {
      this.Item = item;
      this.IcoClass = item[Templates.IcoTeaser.Fields.IcoClass];
      this.Title = item[Templates.IcoTeaser.Fields.Title];
      this.Summary = item[Templates.IcoTeaser.Fields.Summary];
      this.Link = item[Templates.IcoTeaser.Fields.Link];
    }

    public IconTeaserModel()
    {

    }

    public Item Item { get; set; }
    public string IcoClass { get; set; }
    public string Title { get; set; }
    public string Summary { get; set; }
    public string Link { get; set; }
  }
}