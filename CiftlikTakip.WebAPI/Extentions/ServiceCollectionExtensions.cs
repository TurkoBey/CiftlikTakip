using Serilog;
using System.Text.Json.Serialization;

namespace CiftlikTakip.WebAPI.Extentions
{
    public static class ServiceCollectionExtensions
    {
        public static void AddApiServices(this IServiceCollection services)
        {
            services.AddControllers()
                     .AddJsonOptions(opt => opt.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();
        }
        public static void AddMyLogger(this ILoggingBuilder logging, WebApplicationBuilder applicationBuilder)
        {
            var fromFile = new LoggerConfiguration()
                        .ReadFrom.Configuration(applicationBuilder.Configuration)
                        .CreateLogger();

            logging.AddSerilog(fromFile);
        }
    }
}
