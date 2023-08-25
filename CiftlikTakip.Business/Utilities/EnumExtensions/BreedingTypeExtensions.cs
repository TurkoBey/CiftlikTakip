using CiftlikTakip.Business.CustomExceptions;
using CiftlikTakip.Business.Utilities.EnumExtensions.Enums;

namespace CiftlikTakip.Business.Utilities.EnumExtensions
{
    public class BreedingTypeExtensions
    {
        public static EnumBreedingType ConvertToEnum(byte? enumType)
        {
            if (enumType == null)
            {
                return EnumBreedingType.Null;
            }

            switch (enumType)
            {
                case 100:
                    return EnumBreedingType.Suni;
                case 101:
                    return EnumBreedingType.Doğal;
                default:
                    return EnumBreedingType.Null;
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
                case "Suni":
                    return 100;
                case "Doğal":
                    return 101;
                default:
                    return 0;
            }
        }
    }
}
