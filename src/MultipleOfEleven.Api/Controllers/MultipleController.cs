using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MultipleOfEleven.Application.Models;
using MultipleOfEleven.Application.Services.Multiple;

namespace MultipleOfEleven.Api.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class MultipleController : Controller
    {
        private readonly IMultipleApplication _multipleApplication;

        public MultipleController(IMultipleApplication multipleApplication)
        {
            _multipleApplication = multipleApplication;
        }

        [HttpPost]
        public IActionResult Post(PostNumbersModel obj)
        {
            var result = _multipleApplication.IsMultipleOfEleven(obj);
            return Ok(result);
        }
    }
}
