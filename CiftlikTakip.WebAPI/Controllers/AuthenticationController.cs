using CiftlikTakip.Business.Interfaces;
using CiftlikTakip.Model.Dtos.UserAccessPermission;
using CiftlikTakip.WebAPI.Controllers.Base;
using Infrastructure.Utilities.ApiResponses;
using Microsoft.AspNetCore.Mvc;

namespace CiftlikTakip.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : BaseController
    {
        private readonly IUserAccessPermissionBs _userAccessPermissionBs;
        public AuthenticationController(IUserAccessPermissionBs userAccessPermissionBs)
        {
            _userAccessPermissionBs = userAccessPermissionBs;
        }

        #region Swagger
        [Produces("application/json", "text/plain")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ApiResponse<NoData>))]
        #endregion
        [HttpPut]
        public async Task<IActionResult> Update([FromBody] UserAccessPermissionPutDto dto)
        {
            var response = await _userAccessPermissionBs.UpdateAsync(dto);
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
            var response = await _userAccessPermissionBs.SDeleteAsync(sid);
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
            var response = await _userAccessPermissionBs.RDeleteAsync(rid);
            return await SendResponseAsync(response);
        }
        #region SWAGGER
        [Produces("application/json", "text/plain")]
        [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(ApiResponse<List<UserAccessPermissionPostDto>>))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ApiResponse<NoData>))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ApiResponse<NoData>))]
        #endregion
        [HttpPost]
        public async Task<IActionResult> SaveNew([FromBody] UserAccessPermissionPostDto dto)
        {
            var response = await _userAccessPermissionBs.InsertAsync(dto);
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
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ApiResponse<UserAccessPermissionGetDto>))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ApiResponse<NoData>))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ApiResponse<NoData>))]
        #endregion
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById([FromRoute] Guid id)
        {
            var response = await _userAccessPermissionBs.GetByIdAsync(id, "Employee");
            return await SendResponseAsync(response);
        }

        #region SWAGGER
        [Produces("application/json", "text/plain")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<UserAccessPermissionGetDto>))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(List<UserAccessPermissionGetDto>))]
        #endregion
        [HttpGet]
        public async Task<IActionResult> GetUsers()
        {
            var response = await _userAccessPermissionBs.GetUsersAsync("Employee");
            return await SendResponseAsync(response);
        }

        #region SWAGGER DOC
        [Produces("application/json", "text/plain")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ApiResponse<List<UserAccessPermissionGetDto>>))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ApiResponse<NoData>))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ApiResponse<NoData>))]
        #endregion
        [HttpGet("logIn")]
        public async Task<IActionResult> LogIn([FromQuery] string email, [FromQuery] string password)
        {
            var response = await _userAccessPermissionBs.LogIn(email, password, "Employee");
            return await SendResponseAsync(response);
        }
    }
}
