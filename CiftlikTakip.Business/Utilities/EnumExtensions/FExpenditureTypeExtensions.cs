using CiftlikTakip.Business.Utilities.EnumExtensions.Enums;

namespace Infrastructure.Utilities.EnumExtensions
{
    public static class FExpenditureTypeExtensions
    {
        public static EnumFExpenditureType ConvertToEnum(byte? enumType)
        {
            switch (enumType)
            {
                case 100:
                    return EnumFExpenditureType.Gelir;
                case 101:
                    return EnumFExpenditureType.Gider;
                default:
                    return EnumFExpenditureType.Null;
            }
        }
        public static byte ConvertToString(string? stringType)
        {
            switch (stringType)
            {
                case "Gelir":
                    return 100;
                case "Gider":
                    return 101;
                default:
                    return 0;
            }
        }
    }
}
