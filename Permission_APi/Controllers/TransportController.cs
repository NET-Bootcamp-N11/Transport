using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.FileProviders;
using Permission_APi.AttributeS;
using Permission_Application.Dto_s;
using Permission_Application.Services.Teacher_S;
using Permission_Domen.Entityes;
using Permission_Domen.Enums;
using System.Linq.Expressions;
using VehicleManagement_Application.Dto_s;
using VehicleManagementAPI.Extentions;

namespace Permission_APi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    [Authorize]
    public class TransportController : ControllerBase
    {
        private readonly IServiceTransport _serviceTransport;

        private readonly IWebHostEnvironment _webHostEnvironment;

        public TransportController(IWebHostEnvironment webHostEnvironment, IServiceTransport serviceTeacher)
        {
            _webHostEnvironment = webHostEnvironment;
            _serviceTransport = serviceTeacher;
        }

        [FilterAttribute(Permissitions.GetAllTransports)]
        [HttpGet]
        public async Task<IActionResult> GetAll() => Ok(await _serviceTransport.GetAllAsync());

        [FilterAttribute(Permissitions.GetTransportById)]
        [HttpGet]
        public async Task<IActionResult> GetById(int id) => Ok(await _serviceTransport.GetById(id));

        [FilterAttribute(Permissitions.CreateTransport)]
        [HttpPost]
        public async Task<IActionResult> Create([FromForm]TransportDto transportDto, IFormFile Imageurl)
        {
            var Extention = new MetodExtention(_webHostEnvironment);

            var picturepath =await  Extention.AddPictureAndGetPath(Imageurl);
            var result = await _serviceTransport.CreateAsync(transportDto, picturepath);
            return Ok(result);

        }
        [FilterAttribute(Permissitions.UpdateTransport)]
        [HttpPut]
        public async Task<IActionResult> Update(int id, [FromForm]TransportDto transportDto) => Ok(await _serviceTransport.UpdateAsync(id,transportDto));

        [FilterAttribute(Permissitions.DeleteTransport)]
        [HttpDelete]
        public async Task<IActionResult> Delete(int id) => Ok(await _serviceTransport.DeleteAsync(id));
    }
}
