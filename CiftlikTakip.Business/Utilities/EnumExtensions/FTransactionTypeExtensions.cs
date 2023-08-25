using CiftlikTakip.Business.Utilities.EnumExtensions.Enums;

namespace Infrastructure.Utilities.EnumUtilities
{
    public static class FTransactionTypeExtensions
    {
        public static EnumFTransactionType ConvertToEnum(byte? enumType)
        {
            switch (enumType)
            {
                case 100:
                    return EnumFTransactionType.Havale;
                case 101:
                    return EnumFTransactionType.EFT;
                default:
                    return EnumFTransactionType.Null;
            }
        }
        public static byte ConvertToString(string? stringType)
        {
            switch (stringType)
            {
                case "Havale":
                    return 100;
                case "EFT":
                    return 101;
                default:
                    return 0;
            }
        }
    }
}
