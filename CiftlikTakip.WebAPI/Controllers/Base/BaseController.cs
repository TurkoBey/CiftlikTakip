using Infrastructure.Utilities.ApiResponses;
using Microsoft.AspNetCore.Mvc;

namespace CiftlikTakip.WebAPI.Controllers.Base
{

    [Route("api/[controller]")]
    [ApiController]
    public class BaseController : ControllerBase
    {
        [NonAction]
        public async Task<ActionResult> SendResponseAsync<T>(ApiResponse<T> response)
        {
            if (response.StatusCode == StatusCodes.Status204NoContent)
            {
                return new ObjectResult(null) { StatusCode = response.StatusCode };
            }
            await Task.Delay(100);
            return new ObjectResult(response) { StatusCode = response.StatusCode };
        }
    }
}
