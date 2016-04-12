namespace Sitecore.Feature.PageContent
{
  using Sitecore.Data;

  public struct Templates
  {
    public struct HasPageContent
    {
      public static ID ID = new ID("{AF74A00B-8CA7-4C9A-A5C1-156A68590EE2}");

      public struct Fields
      {
        public static readonly ID Title = new ID("{C30A013F-3CC8-4961-9837-1C483277084A}");
        public const string Title_FieldName = "Title";
        public static readonly ID Summary = new ID("{AC3FD4DB-8266-476D-9635-67814D91E901}");
        public const string Summary_FieldName = "Summary";
        public static readonly ID Body = new ID("{D74F396D-5C5E-4916-BD0A-BFD58B6B1967}");
        public const string Body_FieldName = "Body";
        public static readonly ID Image = new ID("{9492E0BB-9DF9-46E7-8188-EC795C4ADE44}");
      }
    }

    public struct Fact
    {
      public static ID ID = new ID("{743D21A4-CED7-4F20-9DF5-85FD78348728}");

      public struct Fields
      {
        public static readonly ID Ico_Class = new ID("{D7F4B6BB-374D-44CC-A967-7D119FFB162C}");
        public const string Ico_Class_FieldName = "Ico Class";

        public static readonly ID Number = new ID("{E7CA32C5-BC6D-4763-9E38-9FCCE2BCE645}");
        public const string Number_FieldName = "Number";

        public static readonly ID Description = new ID("{9546F0C5-31AA-4959-A4F3-2BB1AAE52483}");
        public const string Description_FieldName = "Description";
      }
    }

    public struct Highlight
    {
      public static ID ID = new ID("{7A670D41-2C9A-4C77-A67D-19269ACBB6A5}");

      public struct Fields
      {
        public static readonly ID Title = new ID("{AD6D30AC-C636-4313-9806-E8076BF19AEF}");
        public const string Title_FieldName = "Title";

        public static readonly ID Text = new ID("{D1FFA3E4-4C14-423E-B6E3-71FAE7F079AC}");
        public const string Text_FieldName = "Text";

        public static readonly ID Date_Countdown = new ID("{CA978C84-962C-44B1-BEC2-AD22885A9079}");
        public const string Date_Countdown_FieldName = "Date Countdown"; 
      }
    }
  }
}