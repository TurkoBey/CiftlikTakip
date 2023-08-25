using CiftlikTakip.Business.CustomExceptions;

namespace CiftlikTakip.Business.Utilities
{
    public static class IPHelper
    {
        public static async Task<string> GetPublicIPAddressAsync(TimeSpan timeout)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    client.Timeout = timeout;
                    string url = "https://api.ipify.org?format=text";

                    HttpResponseMessage response = await client.GetAsync(url);
                    response.EnsureSuccessStatusCode();

                    string ipAddress = await response.Content.ReadAsStringAsync();
                    return ipAddress.Trim();
                }
            }
            catch (HttpRequestException ex)
            {
                throw new BadRequestException("HTTP İstek Hatası: " + ex.Message);
            }
            catch (TaskCanceledException ex)
            {
                throw new BadRequestException("İstek Zaman Aşımı Hatası: " + ex.Message);
            }
            catch (Exception ex)
            {
                throw new BadRequestException("Genel Hata: " + ex.Message);
            }
        }
    }
}
