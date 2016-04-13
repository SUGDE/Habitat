namespace Sitecore.Feature.Identity
{
  using Sitecore.Data;

  public struct Templates
  {
    public struct Identity
    {
      public static readonly ID ID = new ID("{FA8DE5B9-D5D8-40A7-866A-23AF4F5A9629}");

      public struct Fields
      {
        public static readonly ID Logo = new ID("{E748D808-64C1-4DEC-9718-F35CF9689E4B}");
        public static readonly ID Copyright = new ID("{02115632-FE1E-4B3D-9AD4-A4DDF1F782F0}");
      }
    } 
    public struct Map
    {
      public static readonly ID ID = new ID("{993E00EF-B292-446B-BF98-9E783B44270B}");

      public struct Fields
      {
        public static readonly ID Logo = new ID("{0948AA52-7461-4242-B621-DDBADCE77B1B}");
        public static readonly string Logo_FieldName = "Logo";
        public static readonly ID Latitude  = new ID("{7B8CB591-76DF-428D-8BDE-1C225D9F3DCE}");
        public static readonly string Latitude_FieldName = "Latitude";
        public static readonly ID Longitude = new ID("{477D9545-3770-4228-AB9F-5FD82BAA10A5}");
        public static readonly string Longitude_FieldName = "Longitude";
      }
    }
  }
}