using System.Text.Json;

namespace CiftlikTakip.MvcUI.Areas.admin.Extensions
{
    public static class SessionExtension
    {
        public static void SetObject(this ISession session, string key, object data)
        {
            session.SetString(key, JsonSerializer.Serialize(data));
        }
        public static T GetObject<T>(this ISession session, string key)
        {
            var sessionJsonData = session.GetString(key);
            return JsonSerializer.Deserialize<T>(sessionJsonData);
        }
    }
}
