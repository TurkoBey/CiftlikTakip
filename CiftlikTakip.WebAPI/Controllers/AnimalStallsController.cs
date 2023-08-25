using CiftlikTakip.Business.Interfaces;
using CiftlikTakip.Model.Dtos.AnimalStall;
using CiftlikTakip.WebAPI.Controllers.Base;
using Infrastructure.Utilities.ApiResponses;
using Microsoft.AspNetCore.Mvc;

namespace CiftlikTakip.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnimalStallsController : BaseController
    {
        private readonly IAnimalStallBs _animalStallBs;
        public AnimalStallsController(IAnimalStallBs animalStallBs)
        {
            _animalStallBs = animalStallBs;
        }
        #region Swagger
        [Produces("application/json", "text/plain")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ApiResponse<NoData>))]
        #endregion
        [HttpPut]
        public async Task<IActionResult> UpdateProject([FromBody] AnimalStallPutDto dto)
        {
            var response = await _animalStallBs.UpdateAsync(dto);
            return await SendResponseAsync(response);
        }

        #region SWAGGER
        [Produces("application/json", "text/plain")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(string))]
        #endregion
        [HttpDelete("deleteS/{sid}")]
        public async Task<IActionResult> DeleteProduct([FromRoute] Guid sid)
        {
            var response = await _animalStallBs.SDeleteAsync(sid);
            return await SendResponseAsync(response);
        }

        #region Swagger
        [Produces("application/json", "text/plain")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ApiResponse<NoData>))]
        #endregion
        [HttpPut("RestoreById")]
        public async Task<IActionResult> RDeleteProduct([FromQuery] Guid rid)
        {
            var response = await _animalStallBs.RDeleteAsync(rid);
            return await SendResponseAsync(response);
        }

        #region SWAGGER
        [Produces("application/json", "text/plain")]
        [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(ApiResponse<List<AnimalStallGetDto>>))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ApiResponse<NoData>))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ApiResponse<NoData>))]
        #endregion
        [HttpPost]
        public async Task<IActionResult> SaveNewProduct([FromBody] AnimalStallPostDto dto)
        {
            var response = await _animalStallBs.InsertAsync(dto);
            if (response.ErrorMessages != null && response.ErrorMessages.Count > 0)
            {
                return await SendResponseAsync(response);
            }
            else
            {
                return CreatedAtAction(nameof(GetById), new { id = response.Data.Id }, response);
            }
        }
        #region SWAGGER
        [Produces("application/json", "text/plain")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ApiResponse<AnimalStallGetDto>))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ApiResponse<NoData>))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ApiResponse<NoData>))]
        #endregion
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById([FromRoute] Guid id)
        {
            var response = await _animalStallBs.GetByIdAsync(id);
            return await SendResponseAsync(response);
        }

        #region SWAGGER
        [Produces("application/json", "text/plain")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<AnimalStallGetDto>))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(List<AnimalStallGetDto>))]
        #endregion
        [HttpGet]
        public async Task<IActionResult> GetStalls()
        {
            var response = await _animalStallBs.GetStallsAsync();
            return await SendResponseAsync(response);
        }
    }
}
