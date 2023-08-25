using CiftlikTakip.Business.Interfaces;
using CiftlikTakip.Model.Dtos.Company;
using CiftlikTakip.WebAPI.Controllers.Base;
using Infrastructure.Utilities.ApiResponses;
using Microsoft.AspNetCore.Mvc;

namespace CiftlikTakip.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompaniesController : BaseController
    {
        private readonly ICompanyBs _companyBs;
        public CompaniesController(ICompanyBs companyBs)
        {
            _companyBs = companyBs;
        }

        #region SWAGGER
        [Produces("application/json", "text/plain")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ApiResponse<CompanyGetDto>))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ApiResponse<NoData>))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ApiResponse<NoData>))]
        #endregion
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById([FromRoute] Guid id)
        {
            var response = await _companyBs.GetByIdAsync(id);
            return await SendResponseAsync(response);
        }

        #region SWAGGER
        [Produces("application/json", "text/plain")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<CompanyGetDto>))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(List<CompanyGetDto>))]
        #endregion
        [HttpGet]
        public async Task<IActionResult> GetCompanies()
        {
            var response = await _companyBs.GetCompaniesAsync();
            return await SendResponseAsync(response);
        }
        
        #region SWAGGER   
        [Produces("application/json", "text/plain")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<CompanyGetDto>))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(List<CompanyGetDto>))]
        #endregion
        [HttpGet("getbyCompanyName")]
        public async Task<IActionResult> GetByCompanyName([FromQuery] string companyName)
        {
            var response = await _companyBs.GetByCompanyNameAsync(companyName);
            return await SendResponseAsync(response);
        }
       
        #region Swagger
        [Produces("application/json", "text/plain")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ApiResponse<NoData>))]
        #endregion
        [HttpPut]
        public async Task<IActionResult> Update([FromBody] CompanyPutDto dto)
        {
            var response = await _companyBs.UpdateAsync(dto);
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
            var response = await _companyBs.RDeleteAsync(rid);
            return await SendResponseAsync(response);
        }

        #region SWAGGER
        [Produces("application/json", "text/plain")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(string))]
        #endregion
        [HttpDelete("deleteS/{sid}")]
        public async Task<IActionResult> SDelete([FromRoute] Guid sid)
        {
            var response = await _companyBs.SDeleteAsync(sid);
            return await SendResponseAsync(response);
        }

        #region SWAGGER
        [Produces("application/json", "text/plain")]
        [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(ApiResponse<List<CompanyGetDto>>))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ApiResponse<NoData>))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ApiResponse<NoData>))]
        #endregion
        [HttpPost]
        public async Task<IActionResult> SaveNew([FromBody] CompanyPostDto dto)
        {
            var response = await _companyBs.InsertAsync(dto);
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
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(string))]
        #endregion
        [HttpDelete("deleteH/{hid}")]
        public async Task<IActionResult> HDelete([FromRoute] Guid hid)
        {
            var response = await _companyBs.HDeleteAsync(hid);
            return await SendResponseAsync(response);
        }
    }
}
