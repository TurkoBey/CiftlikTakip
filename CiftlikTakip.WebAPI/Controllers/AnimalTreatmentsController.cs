using CiftlikTakip.Business.Interfaces;
using CiftlikTakip.Model.Dtos.AnimalTreatment;
using CiftlikTakip.WebAPI.Controllers.Base;
using Infrastructure.Utilities.ApiResponses;
using Microsoft.AspNetCore.Mvc;

namespace CiftlikTakip.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnimalTreatmentsController : BaseController
    {
        private readonly IAnimalTreatmentBs _animalTreatmentBs;
        public AnimalTreatmentsController(IAnimalTreatmentBs animalTreatmentBs)
        {
            _animalTreatmentBs = animalTreatmentBs;
        }
        #region Swagger
        [Produces("application/json", "text/plain")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ApiResponse<NoData>))]
        #endregion
        [HttpPut]
        public async Task<IActionResult> UpdateProject([FromBody] AnimalTreatmentPutDto dto)
        {
            var response = await _animalTreatmentBs.UpdateAsync(dto);
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
            var response = await _animalTreatmentBs.SDeleteAsync(sid);
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
            var response = await _animalTreatmentBs.RDeleteAsync(rid);
            return await SendResponseAsync(response);
        }

        #region SWAGGER
        [Produces("application/json", "text/plain")]
        [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(ApiResponse<List<AnimalTreatmentGetDto>>))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ApiResponse<NoData>))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ApiResponse<NoData>))]
        #endregion
        [HttpPost]
        public async Task<IActionResult> SaveNewProduct([FromBody] AnimalTreatmentPostDto dto)
        {
            var response = await _animalTreatmentBs.InsertAsync(dto);
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
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ApiResponse<AnimalTreatmentGetDto>))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ApiResponse<NoData>))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ApiResponse<NoData>))]
        #endregion
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById([FromRoute] Guid id)
        {
            var response = await _animalTreatmentBs.GetByIdAsync(id, "BreedingRecord", "Employee");
            return await SendResponseAsync(response);
        }
        #region SWAGGER
        [Produces("application/json", "text/plain")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<AnimalTreatmentGetDto>))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(List<AnimalTreatmentGetDto>))]
        #endregion
        [HttpGet]
        public async Task<IActionResult> GetTreatments()
        {
            var response = await _animalTreatmentBs.GetTreatmentsAsync("BreedingRecord", "Employee");
            return await SendResponseAsync(response);
        }
    }
}
