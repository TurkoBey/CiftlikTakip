using CiftlikTakip.Business.Utilities.EnumExtensions.Enums;

namespace Infrastructure.Utilities.EnumExtensions
{
    public static class FTypeExtensions
    {

        public static EnumFType ConvertToEnum(byte? enumType)
        {
            switch (enumType)
            {
                case 100:
                    return EnumFType.Avans;
                case 101:
                    return EnumFType.Maaş;
                default:
                    return EnumFType.Null;
            }
        }
        public static byte ConvertToString(string? stringType)
        {
            switch (stringType)
            {
                case "Avans":
                    return 100;
                case "Maaş":
                    return 101;
                default:
                    return 0;
            }
        }
    }
}
