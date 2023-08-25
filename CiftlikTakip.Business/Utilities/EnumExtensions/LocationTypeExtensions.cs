using CiftlikTakip.Business.Utilities.EnumExtensions.Enums;

namespace Infrastructure.Utilities.EnumUtilities
{
    public static class LocationTypeExtensions
    {
        public static EnumLocationType ConvertToEnum(byte? enumType)
        {
            if (enumType == null)
            {
                return EnumLocationType.Null;
            }

            switch (enumType)
            {
                case 100:
                    return EnumLocationType.Çiftlik;
                case 101:
                    return EnumLocationType.İş;
                case 102:
                    return EnumLocationType.Ev;
                case 103:
                    return EnumLocationType.Diğer;
                default:
                    return EnumLocationType.Null;
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
                case "Çiftlik":
                    return 100;
                case "İş":
                    return 101;
                case "Ev":
                    return 102;
                case "Diğer":
                    return 103;
                default:
                    return 0;
            }
        }
    }
}
