using CiftlikTakip.Business.Interfaces;
using CiftlikTakip.Model.Dtos.Employee;
using CiftlikTakip.WebAPI.Controllers.Base;
using Infrastructure.Utilities.ApiResponses;
using Microsoft.AspNetCore.Mvc;

namespace CiftlikTakip.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : BaseController
    {
        private readonly IEmployeeBs _employeeBs;
        public EmployeesController(IEmployeeBs employeeBs)
        {
            _employeeBs = employeeBs;
        }

        #region Swagger
        [Produces("application/json", "text/plain")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ApiResponse<NoData>))]
        #endregion
        [HttpPut]
        public async Task<IActionResult> Update([FromBody] EmployeePutDto dto)
        {
            var response = await _employeeBs.UpdateAsync(dto);
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
            var response = await _employeeBs.SDeleteAsync(sid);
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
            var response = await _employeeBs.RDeleteAsync(rid);
            return await SendResponseAsync(response);
        }

        #region SWAGGER
        [Produces("application/json", "text/plain")]
        [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(ApiResponse<List<EmployeeGetDto>>))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ApiResponse<NoData>))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ApiResponse<NoData>))]
        #endregion
        [HttpPost]
        public async Task<IActionResult> SaveNew([FromBody] EmployeePostDto dto)
        {
            var response = await _employeeBs.InsertAsync(dto);
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
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ApiResponse<EmployeeGetDto>))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ApiResponse<NoData>))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ApiResponse<NoData>))]
        #endregion
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById([FromRoute] Guid id)
        {
            var response = await _employeeBs.GetByIdAsync(id);
            return await SendResponseAsync(response);
        }

        #region SWAGGER
        [Produces("application/json", "text/plain")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<EmployeeGetDto>))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(List<EmployeeGetDto>))]
        #endregion
        [HttpGet]
        public async Task<IActionResult> GetEmployees()
        {
            var response = await _employeeBs.GetEmployeesAsync();
            return await SendResponseAsync(response);
        }

        #region SWAGGER
        [Produces("application/json", "text/plain")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ApiResponse<EmployeeGetDto>))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ApiResponse<NoData>))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ApiResponse<NoData>))]
        #endregion
        [HttpGet("getbytckn/{tckn}")]
        public async Task<IActionResult> GetByTckn([FromRoute] string tckn)
        {
            var response = await _employeeBs.GetByTcknAsync(tckn);
            return await SendResponseAsync(response);
        }
    }
}
