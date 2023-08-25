using CiftlikTakip.Business.CustomExceptions;

namespace CiftlikTakip.Business.Utilities
{
    public static class ValidationHelper<T>
    {
        public static T IdCheck(T id)
        {
            if (!Guid.TryParse(id.ToString(), out Guid resultGuid))
            {
                throw new BadRequestException("Id değeri uygunsuz format içeriyor.");
            }
            return id;
        }
        public static bool IsGuid(T id)
        {
            return Guid.TryParse(id.ToString(), out _);
        }
    }
}
