using CiftlikTakip.Business.Utilities.EnumExtensions.Enums;

namespace CiftlikTakip.Business.Utilities.EnumExtensions
{
    public class QuantityTypeExtensions
    {
        public static EnumQuantityType ConvertToEnum(byte? enumType)
        {
            if (enumType == null)
            {
                return EnumQuantityType.Null;
            }

            switch (enumType)
            {
                case 100:
                    return EnumQuantityType.KG;
                case 101:
                    return EnumQuantityType.TON;
                case 102:
                    return EnumQuantityType.Balya;
                case 103:
                    return EnumQuantityType.Adet;
                default:
                    return EnumQuantityType.Null;
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
                case "KG":
                    return 100;
                case "TON":
                    return 101;
                case "Balya":
                    return 102;
                case "Adet":
                    return 103;
                default:
                    return 0;
            }
        }
    }
}
