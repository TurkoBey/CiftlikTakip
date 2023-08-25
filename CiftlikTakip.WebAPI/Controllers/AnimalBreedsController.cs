using CiftlikTakip.Business.Interfaces;
using CiftlikTakip.Model.Dtos.AnimalBreed;
using CiftlikTakip.WebAPI.Controllers.Base;
using Infrastructure.Utilities.ApiResponses;
using Microsoft.AspNetCore.Mvc;

namespace CiftlikTakip.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnimalBreedsController : BaseController
    {
        private readonly IAnimalBreedBs _animalBreedBs;
        public AnimalBreedsController(IAnimalBreedBs animalBreedBs)
        {
            _animalBreedBs = animalBreedBs;
        }

        #region Swagger
        [Produces("application/json", "text/plain")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ApiResponse<NoData>))]
        #endregion
        [HttpPut]
        public async Task<IActionResult> Update([FromBody] AnimalBreedPutDto dto)
        {
            var response = await _animalBreedBs.UpdateAsync(dto);
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
            var response = await _animalBreedBs.SDeleteAsync(sid);
            return await SendResponseAsync(response);
        }

        #region SWAGGER
        [Produces("application/json", "text/plain")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(string))]
        #endregion
        [HttpDelete("deleteH/{hid}")]
        public async Task<IActionResult> HDelete([FromRoute] Guid hid)
        {
            var response = await _animalBreedBs.HDeleteAsync(hid);
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
            var response = await _animalBreedBs.RDeleteAsync(rid);
            return await SendResponseAsync(response);
        }

        #region SWAGGER
        [Produces("application/json", "text/plain")]
        [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(ApiResponse<List<AnimalBreedGetDto>>))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ApiResponse<NoData>))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ApiResponse<NoData>))]
        #endregion
        [HttpPost]
        public async Task<IActionResult> AddNew([FromBody] AnimalBreedPostDto dto)
        {
            var response = await _animalBreedBs.InsertAsync(dto);
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
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ApiResponse<AnimalBreedGetDto>))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ApiResponse<NoData>))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ApiResponse<NoData>))]
        #endregion
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById([FromRoute] Guid id)
        {
            var response = await _animalBreedBs.GetByIdAsync(id);
            return await SendResponseAsync(response);
        }

        #region SWAGGER
        [Produces("application/json", "text/plain")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<AnimalBreedGetDto>))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(List<AnimalBreedGetDto>))]
        #endregion
        [HttpGet]
        public async Task<IActionResult> GetBreeds()
        {
            var response = await _animalBreedBs.GetBreedsAsync();
            return await SendResponseAsync(response);
        }

        #region SWAGGER   
        [Produces("application/json", "text/plain")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<AnimalBreedGetDto>))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(List<AnimalBreedGetDto>))]
        #endregion
        [HttpGet("getbyBreedType")]
        public async Task<IActionResult> GetByBreedType([FromQuery] string typeName)
        {
            var response = await _animalBreedBs.GetByBreedTypeAsync(typeName);
            return await SendResponseAsync(response);
        }

        #region SWAGGER   
        [Produces("application/json", "text/plain")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<AnimalBreedGetDto>))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(List<AnimalBreedGetDto>))]
        #endregion
        [HttpGet("getbyTitle")]
        public async Task<IActionResult> GetByTitle([FromQuery] string name)
        {
            var response = await _animalBreedBs.GetByTitleAsync(name);
            return await SendResponseAsync(response);
        }
    }
}
