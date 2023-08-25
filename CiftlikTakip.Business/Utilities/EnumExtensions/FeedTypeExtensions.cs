using CiftlikTakip.Business.Utilities.EnumExtensions.Enums;

namespace CiftlikTakip.Business.Utilities.EnumExtensions
{
    public class FeedTypeExtensions
    {
        public static EnumFeedType ConvertToEnum(byte? enumType)
        {
            if (enumType == null)
            {
                return EnumFeedType.Null;
            }

            switch (enumType)
            {
                case 100:
                    return EnumFeedType.Kaba;
                case 101:
                    return EnumFeedType.Kesif;
                default:
                    return EnumFeedType.Null;
            }
        }
        public static byte ConvertToString(string? stringType)
        {
            if (stringType == null)
            {
                return 0;
            }

            switch (stringType)
            {
                case "Kaba":
                    return 100;
                case "Kesif":
                    return 101;
                default:
                    return 0;
            }
        }
    }
}
