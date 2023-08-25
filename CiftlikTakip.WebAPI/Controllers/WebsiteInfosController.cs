using CiftlikTakip.Business.Interfaces;
using CiftlikTakip.Model.Dtos.WebsiteInfo;
using CiftlikTakip.WebAPI.Controllers.Base;
using Infrastructure.Utilities.ApiResponses;
using Microsoft.AspNetCore.Mvc;

namespace CiftlikTakip.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WebsiteInfosController : BaseController
    {
        private readonly IWebsiteInfoBs _websiteInfoBs;
        public WebsiteInfosController(IWebsiteInfoBs websiteInfoBs)
        {
            _websiteInfoBs = websiteInfoBs;
        }

        #region SWAGGER DOC
        [Produces("application/json", "text/plain")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ApiResponse<WebsiteInfoGetDto>))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ApiResponse<NoData>))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ApiResponse<NoData>))]
        #endregion
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById([FromRoute] Guid id)
        {
            var response = await _websiteInfoBs.GetByIdAsync(id);
            return await SendResponseAsync(response);
        }

        //#region SWAGGER
        //[Produces("application/json", "text/plain")]
        //[ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<WebsiteInfoGetDto>))]
        //[ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(List<WebsiteInfoGetDto>))]
        //#endregion
        //[HttpGet]
        //public async Task<IActionResult> GetWebInfos()
        //{
        //    var response = await _websiteInfoBs.GetWebInfosAsync();
        //    return await SendResponseAsync(response);
        //}

        #region Swagger Doc
        [Produces("application/json", "text/plain")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ApiResponse<NoData>))]
        #endregion
        [HttpPut]
        public async Task<IActionResult> Update([FromBody] WebsiteInfoPutDto dto)
        {
            var response = await _websiteInfoBs.UpdateAsync(dto);
            return await SendResponseAsync(response);
        }
    }
}
