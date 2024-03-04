using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Permission_Application.Abstractions.Repositories;

namespace VehicleManagementAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    [Authorize(Roles = "Admin")]

    public class UserController : ControllerBase
    {
        private readonly IUserRepositories _userRepositories;
        public UserController(IUserRepositories userRepositories)
        {
            _userRepositories = userRepositories;
        }
        [HttpGet]
        public async Task<IActionResult> Get() => Ok(await _userRepositories.GetAllAsync());
        [HttpGet]
        public async Task<IActionResult> GetById(int id) => Ok(await _userRepositories.GetAsync(id));
        [HttpDelete]
        public async Task<IActionResult> Delete(int id) => Ok(await _userRepositories.DeleteAsync(id));
    }
}
