using CiftlikTakip.Business.Utilities.EnumExtensions.Enums;

namespace Infrastructure.Utilities.EnumExtensions
{
    public static class ContactTypeExtensions
    {
        public static EnumContactType ConvertToEnum(byte? enumType)
        {
            if (enumType == null)
            {
                return EnumContactType.Null;
            }

            switch (enumType)
            {
                case 100:
                    return EnumContactType.Aktif;
                case 101:
                    return EnumContactType.Pasif;
                case 102:
                    return EnumContactType.Referans;
                default:
                    return EnumContactType.Null;
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
                case "Aktif":
                    return 100;
                case "Pasif":
                    return 101;
                case "Referans":
                    return 102;
                default:
                    return 0;
            }
        }
    }
}
