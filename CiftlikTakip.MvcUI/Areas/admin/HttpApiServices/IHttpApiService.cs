namespace CiftlikTakip.MvcUI.Areas.admin.HttpApiServices
{
    public interface IHttpApiService
    {
        Task<T> GetData<T>(string endPoint);
        Task<T> PostData<T>(string endPoint, string jsonData);
        Task<T> PostOrPutData<T>(string endPoint, string jsonData, HttpMethod httpMethod);
        Task<T> PutData<T>(string endPoint, string jsonData);
        Task<T> DeleteData<T>(string endPoint);
    }
}
