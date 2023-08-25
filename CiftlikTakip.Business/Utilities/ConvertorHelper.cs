using System.Text;

namespace CiftlikTakip.Business.Utilities
{
    public static class ConvertorHelper
    {
        public static string ByteArrayToString(byte[] ba)
        {
            StringBuilder hex = new StringBuilder(ba.Length * 2);
            foreach (byte b in ba)
                hex.AppendFormat("{0:x2}", b);
            return "0x" + hex.ToString();
        }
    }
}
