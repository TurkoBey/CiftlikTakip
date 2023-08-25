using CiftlikTakip.Business.Utilities.EnumExtensions.Enums;

namespace Infrastructure.Utilities.EnumUtilities
{
    public static class PriorityTypeExtensions
    {
        public static EnumPriorityType ConvertToEnum(byte? enumType)
        {
            if (enumType == null)
            {
                return EnumPriorityType.Null;
            }

            switch (enumType)
            {
                case 100:
                    return EnumPriorityType.Yüksek;
                case 101:
                    return EnumPriorityType.Orta;
                case 102:
                    return EnumPriorityType.Düşük;
                default:
                    return EnumPriorityType.Null;
            }
        }
        public static byte ConvertToString(string? stringType)
        {
            switch (stringType)
            {
                case "Yüksek":
                    return 100;
                case "Orta":
                    return 101;
                case "Düşük":
                    return 102;
                default:
                    return 0;
            }
        }
    }
}
