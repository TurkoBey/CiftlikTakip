using System.Globalization;
using System.Text.RegularExpressions;

namespace Infrastructure.Utilities.CustomExtensions
{
    public static class StringExtensions
    {
        public static bool RakamMi(this string input)
        {
            return Regex.IsMatch(input, @"^\d+$");
        }
        public static bool BesKarakterMi(this string input)
        {
            return input.Length == 5;
        }
        public static string KupeNoDuzenle(this string str)
        {
            if (str.Length > 14)
            {
                int kupeUzun = 10;
                string ilk4Hane = str.Substring(0, 4);
                string tumHane = str.Substring(4);
                string sifirEkle = new string('0', kupeUzun - tumHane.Length);
                str = ilk4Hane + sifirEkle + tumHane;
            }
            return str;
        }
        public static bool KupeNoKontrolEt(this string str)
        {
            int kupeUzun = 14;
            int val = int.Parse(str.Substring(2, 2));

            if (!str.StartsWith("TR") || str.Length != kupeUzun || !(val > 1 && val <= 81))
            {
                return false;
            }
            for (int i = 4; i < str.Length; i++)
            {
                if (!char.IsDigit(str[i]))
                {
                    return false;
                }
            }
            return true;
        }
        public static bool TCKNKontrolEt(this string str)
        {
            char[] arr = str.ToCharArray();
            int toplaCift = 0, toplaTek = 0, toplaIlk10 = 0, i = 0;

            bool result = (str.Length != 11 || arr[0] == '0') ? false : true;

            if (result)
            {
                while (i <= 8)
                {
                    int deger = int.Parse(arr[i].ToString());
                    toplaIlk10 += deger;
                    if (i % 2 == 1) 
                        toplaCift += deger;
                    else toplaTek += deger;
                    i++;
                }

                toplaIlk10 += int.Parse(arr[9].ToString());

                result = (!(((toplaCift * 9) + (toplaTek * 7)) % 10 == int.Parse(arr[9].ToString()) && (toplaIlk10 % 10 == int.Parse(arr[10].ToString())))) ? false : true;
            }
            return result;
        }
        public static string BasHarflerBuyukYap(this string str)
        {
            if (string.IsNullOrEmpty(str))
                return str;

            TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;
            return textInfo.ToTitleCase(str.ToLower());
        }
        public static bool TelefonNumarasiKontrolEt(this string input)
        {
            string phoneNumberPattern = @"^(05\d{9})|(5\d{10})$";
            Match match = Regex.Match(input, phoneNumberPattern, RegexOptions.IgnoreCase);
            return match.Success && match.Value == input;
        }
    }
}
