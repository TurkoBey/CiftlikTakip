using CiftlikTakip.Business.Utilities.EnumExtensions.Enums;

namespace Infrastructure.Utilities.EnumExtensions
{
    public static class BreedTypeExtensions
    {
        public static EnumBreedType ConvertToEnum(byte? enumType)
        {
            if (enumType == null)
            {
                return EnumBreedType.Null;
            }

            switch (enumType)
            {
                case 100:
                    return EnumBreedType.Buzağı;
                case 101:
                    return EnumBreedType.Dana;
                case 102:
                    return EnumBreedType.Düve;
                case 103:
                    return EnumBreedType.Tosun;
                case 104:
                    return EnumBreedType.İnek;
                case 105:
                    return EnumBreedType.Boğa;
                default:
                    return EnumBreedType.Null;
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
                case "Buzağı":
                    return 100;
                case "Dana":
                    return 101;
                case "Düve":
                    return 102;
                case "Tosun":
                    return 103;
                case "İnek":
                    return 104;
                case "Boğa":
                    return 105;
                default:
                    return 0;
            }
        }
    }
}
