using CiftlikTakip.Business.Interfaces;
using CiftlikTakip.Model.Dtos.FPricing;
using CiftlikTakip.WebAPI.Controllers.Base;
using Infrastructure.Utilities.ApiResponses;
using Microsoft.AspNetCore.Mvc;

namespace CiftlikTakip.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FPricingsController : BaseController
    {
        private readonly IFPricingBs _fpricing;
        public FPricingsController(IFPricingBs fpricing)
        {
            _fpricing = fpricing;
        }
        #region SWAGGER
        [Produces("application/json", "text/plain")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ApiResponse<FPricingGetDto>))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ApiResponse<NoData>))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ApiResponse<NoData>))]
        #endregion
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById([FromRoute] Guid id)
        {
            var response = await _fpricing.GetByIdAsync(id);
            return await SendResponseAsync(response);
        }

        #region Swagger
        [Produces("application/json", "text/plain")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ApiResponse<NoData>))]
        #endregion
        [HttpPut]
        public async Task<IActionResult> Update([FromBody] FPricingPutDto dto)
        {
            var response = await _fpricing.UpdateAsync(dto);
            return await SendResponseAsync(response);
        }

        #region SWAGGER
        [Produces("application/json", "text/plain")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<FPricingGetDto>))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(List<FPricingGetDto>))]
        #endregion
        [HttpGet]
        public async Task<IActionResult> GetPricings()
        {
            var response = await _fpricing.GetPricingsAsync();
            return await SendResponseAsync(response);
        }

        #region SWAGGER
        [Produces("application/json", "text/plain")]
        [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(ApiResponse<List<FPricingPostDto>>))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ApiResponse<NoData>))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ApiResponse<NoData>))]
        #endregion
        [HttpPost]
        public async Task<IActionResult> SaveNewProduct([FromBody] FPricingPostDto dto)
        {
            var response = await _fpricing.InsertAsync(dto);
            if (response.ErrorMessages != null && response.ErrorMessages.Count > 0)
            {
                return await SendResponseAsync(response);
            }
            else
            {
                return CreatedAtAction(nameof(GetById), new { id = response.Data.Id }, response);
            }
        }
    }
}
