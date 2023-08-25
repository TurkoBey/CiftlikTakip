using CiftlikTakip.Business.CustomExceptions;
using Infrastructure.Utilities.ApiResponses;
using Microsoft.AspNetCore.Diagnostics;
using System.Text.Json;

namespace CiftlikTakip.WebAPI.Middlewares
{
    public static class UseCusstomExceptionHandler
    {
        public static void UseCustomException(this IApplicationBuilder application)
        {
            application.UseExceptionHandler(configure =>
            {
                configure.Run(async context =>
                {
                    context.Response.ContentType = "application/json";

                    var exceptionFeuture = context.Features.Get<IExceptionHandlerFeature>();

                    var statusCode = StatusCodes.Status500InternalServerError;

                    switch (exceptionFeuture.Error)
                    {
                        case BadRequestException:
                            statusCode = StatusCodes.Status400BadRequest;
                            break;
                        case NotFoundException:
                            statusCode = StatusCodes.Status404NotFound;
                            break;
                        case NoContentException:
                            statusCode = StatusCodes.Status204NoContent;
                            break;
                        default:
                            break;
                    }

                    context.Response.StatusCode = statusCode;
                    var response = ApiResponse<NoData>.Fail(statusCode, exceptionFeuture.Error.Message);
                    await context.Response.WriteAsync(JsonSerializer.Serialize(response));
                });
            });
        }
    }
}
