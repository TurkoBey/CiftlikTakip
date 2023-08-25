namespace CiftlikTakip.Business.Implementations.Base
{
    public static class BaseBs
    {
        public static DateTime ConvertToTurkeyTimeZone(DateTime utcDateTime)
        {
            return TimeZoneInfo.ConvertTimeFromUtc(utcDateTime, TimeZoneInfo.FindSystemTimeZoneById("Turkey Standard Time"));
        }
        public static byte[] GenerateVersionNumber()
        {
            return BitConverter.GetBytes(DateTime.Now.Ticks);
        } 
    }
}
