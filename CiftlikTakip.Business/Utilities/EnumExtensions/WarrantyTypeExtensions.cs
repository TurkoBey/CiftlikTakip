using CiftlikTakip.Business.Utilities.EnumExtensions.Enums;

namespace Infrastructure.Utilities.EnumUtilities
{
    public static class WarrantyTypeExtensions
    {
        public static EnumWarrantyType ConvertToEnum(byte? enumType)
        {
            if (enumType == null)
            {
                return EnumWarrantyType.Null;
            }

            switch (enumType)
            {
                case 100:
                    return EnumWarrantyType.Var;
                case 101:
                    return EnumWarrantyType.Yok;
                default:
                    return EnumWarrantyType.Null;
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
                case "Var":
                    return 100;
                case "Yok":
                    return 101;
                default:
                    return 0;
            }
        }
    }
}
