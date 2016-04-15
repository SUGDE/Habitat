namespace Sitecore.Feature.Teasers
{
  using Sitecore.Data;

  public struct Templates
  {
    public struct Accordeon
    {
      public static ID ID = new ID("{C7D9D293-4EF8-4380-8E10-C4632E729F39}");

      public struct Fields
      {
        public static readonly ID AccordeonSelector = new ID("{9E942565-677F-491C-A0AC-6B930E37342A}");
      }
    }

    public struct TeaserContent
    {
      public static ID ID = new ID("{FEC0E62A-01FD-40E5-88F3-E5229FE79527}");

      public struct Fields
      {
        public static readonly ID Title = new ID("{4A59D072-5B41-4A79-A157-2B2CCAC10F2B}");
        public static readonly ID Summary = new ID("{13D97A52-7C4E-407C-960D-FADDE8A3C1B1}");
        public static readonly ID Image = new ID("{0F6B5546-E0AB-4487-81DE-640C1AA1B65B}");
        public static readonly ID Link = new ID("{E8AB122C-6F54-4D4E-AEC6-F81ADDC558FC}");
      }
    }
    
    public struct IcoTeaser
    {
      public static ID ID = new ID("{224E6A57-60DF-438A-9AF4-D63FFC36BBD6}");

      public struct Fields
      {
        public static readonly ID IcoClass = new ID("{3B14FCF1-F30C-4339-9F78-08218931C6C4}");
        public const string IcoClass_FieldName = "IcoClass";

        public static readonly ID Title = new ID("{4A59D072-5B41-4A79-A157-2B2CCAC10F2B}");
        public static readonly ID Summary = new ID("{13D97A52-7C4E-407C-960D-FADDE8A3C1B1}");
        public static readonly ID Image = new ID("{0F6B5546-E0AB-4487-81DE-640C1AA1B65B}");
        public static readonly ID Link = new ID("{E8AB122C-6F54-4D4E-AEC6-F81ADDC558FC}");
      }
    }
     
    public struct AccordionElementTeaser
    {
      public static ID ID = new ID("{49073CB7-D9A4-426C-8581-8FD84E522B97}");

      public struct Fields
      {
        public static readonly ID Time = new ID("{5F084F71-A92C-4512-9E76-FECD94E528F8}");
        public const string Time_FieldName = "Time";

        public static readonly ID Presenter = new ID("{54B9CF7E-7958-4915-A640-05CE804CF3E4}");
        public const string Presenter_FieldName = "Presenter";

        public static readonly ID Duration = new ID("{9441D365-53B0-4DAF-A8E3-D6A7F1C79229}");
        public const string Duration_FieldName = "Duration";

        public static readonly ID PresentersTitle = new ID("{0C670E0D-0CAE-4DBD-8DE9-F4DC210464C8}");
        public const string PresentersTitle_FieldName = "Presenters Title";

        public static readonly ID Title = new ID("{4A59D072-5B41-4A79-A157-2B2CCAC10F2B}");
        public static readonly ID Summary = new ID("{13D97A52-7C4E-407C-960D-FADDE8A3C1B1}");
        public static readonly ID Image = new ID("{0F6B5546-E0AB-4487-81DE-640C1AA1B65B}");
        public static readonly ID Link = new ID("{E8AB122C-6F54-4D4E-AEC6-F81ADDC558FC}");
      }
    }

    public struct InfoTeaser
    {
      public static ID ID = new ID("{6B4D1DD5-9D04-4BFC-8780-518E77E6A7D3}");

      public struct Fields
      {
        public static readonly ID Title = new ID("{4A59D072-5B41-4A79-A157-2B2CCAC10F2B}");
        public static readonly ID Summary = new ID("{13D97A52-7C4E-407C-960D-FADDE8A3C1B1}");
        public static readonly ID Image = new ID("{0F6B5546-E0AB-4487-81DE-640C1AA1B65B}");
        public static readonly ID Link = new ID("{E8AB122C-6F54-4D4E-AEC6-F81ADDC558FC}");

        public static readonly ID InfoItems = new ID("{102A6AEE-C4B8-4D12-B4ED-347B0B9ED66D}");
        public const string InfoItems_FieldName = "InfoItems"; 
      }
    }

    public struct ThreeImagesTeaser
    {
      public static ID ID = new ID("{6B4D1DD5-9D04-4BFC-8780-518E77E6A7D3}");

      public struct Fields
      {
        public static readonly ID Title = new ID("{3205889F-8EFC-4F2F-AA50-95E7AC7C5D52}");
        public const string Title_FieldName = "Title";
        public static readonly ID Text = new ID("{7C7EA1D5-BF8A-435B-91D3-8A809A1BF3D2}");
        public const string Text_FieldName = "Text";
        public static readonly ID Image1 = new ID("{AC49CE89-F884-4DFA-BDBE-5D24F765F17A}");
        public const string Image1_FieldName = "Image 1";
        public static readonly ID Image2 = new ID("{BCCF5D01-2938-4181-810B-FF82F27814F0}");
        public const string Image2_FieldName = "Image 2";
        public static readonly ID Image3 = new ID("{AE028312-A96C-4651-970A-3ECEB19049D4}");
        public const string Image3_FieldName = "Image 3";
      }
    }
  }
}