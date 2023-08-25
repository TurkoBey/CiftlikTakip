using CiftlikTakip.Business.Interfaces;
using CiftlikTakip.Model.Dtos.BreedingRecord;
using CiftlikTakip.WebAPI.Controllers.Base;
using Infrastructure.Utilities.ApiResponses;
using Microsoft.AspNetCore.Mvc;

namespace CiftlikTakip.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BreedingRecordsController : BaseController
    {
        private readonly IBreedingRecordBs _breedingRecordBs;
        public BreedingRecordsController(IBreedingRecordBs breedingRecordBs)
        {
            _breedingRecordBs = breedingRecordBs;
        }
        #region Swagger
        [Produces("application/json", "text/plain")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ApiResponse<NoData>))]
        #endregion
        [HttpPut]
        public async Task<IActionResult> Update([FromBody] BreedingRecordPutDto dto)
        {
            var response = await _breedingRecordBs.UpdateAsync(dto);
            return await SendResponseAsync(response);
        }

        #region SWAGGER
        [Produces("application/json", "text/plain")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(string))]
        #endregion
        [HttpDelete("deleteS/{sid}")]
        public async Task<IActionResult> Delete([FromRoute] Guid sid)
        {
            var response = await _breedingRecordBs.SDeleteAsync(sid);
            return await SendResponseAsync(response);
        }

        #region Swagger
        [Produces("application/json", "text/plain")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ApiResponse<NoData>))]
        #endregion
        [HttpPut("RestoreById")]
        public async Task<IActionResult> RDelete([FromQuery] Guid rid)
        {
            var response = await _breedingRecordBs.RDeleteAsync(rid);
            return await SendResponseAsync(response);
        }

        #region SWAGGER
        [Produces("application/json", "text/plain")]
        [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(ApiResponse<List<BreedingRecordGetDto>>))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ApiResponse<NoData>))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ApiResponse<NoData>))]
        #endregion
        [HttpPost]
        public async Task<IActionResult> SaveNew([FromBody] BreedingRecordPostDto dto)
        {
            var response = await _breedingRecordBs.InsertAsync(dto);
            if (response.ErrorMessages != null && response.ErrorMessages.Count > 0)
            {
                return await SendResponseAsync(response);
            }
            else
            {
                return CreatedAtAction(nameof(GetById), new { id = response.Data.Id }, response.Data);
            }
        }

        #region SWAGGER
        [Produces("application/json", "text/plain")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ApiResponse<BreedingRecordGetDto>))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ApiResponse<NoData>))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ApiResponse<NoData>))]
        #endregion
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById([FromRoute] Guid id)
        {
            var response = await _breedingRecordBs.GetByIdAsync(id);
            return await SendResponseAsync(response);
        }

        #region SWAGGER
        [Produces("application/json", "text/plain")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<BreedingRecordGetDto>))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(List<BreedingRecordGetDto>))]
        #endregion
        [HttpGet]
        public async Task<IActionResult> GetBreeds()
        {
            var response = await _breedingRecordBs.GetBreedsAsync();
            return await SendResponseAsync(response);
        }
    }
}
