using GECP_DOT_NET_API.Models;
using GECP_DOT_NET_API.Repository;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GECP_DOT_NET_API.Controllers
{
    [ApiController]
    public class CircularController : ControllerBase
    {
        private ICircular icircular;
        private IWebHostEnvironment _hostingEnvironment;

        public CircularController(IWebHostEnvironment environment)
        {
            icircular = new CircularRepo();
            _hostingEnvironment = environment;
        }

        [HttpGet, Route("api/GetAllCircularDetails")]
        public IActionResult GetAllCircularDetails()
        {
            var response = icircular.GetAllCircularDetails();
            return Ok(response);
        }
        
        [HttpPost, Route("api/AddCircularDetail")]
        public IActionResult AddCircularDetail()
        {
            var circularVMM = new CircularVM();
            TryUpdateModelAsync<CircularVM>(circularVMM);
            return Ok(icircular.AddCircularDetail(circularVMM));
        }

        [HttpPut, Route("api/UpdateCircularDetail")]
        public IActionResult UpdateCircularDetail(IFormCollection collection)
        {
            var circularVM = new CircularVM();
            TryUpdateModelAsync<CircularVM>(circularVM);
            return Ok(icircular.UpdateCircularDetail(circularVM));
        }

        [HttpPut, Route("api/DeleteCircularDetail")]
        public IActionResult DeleteCircularDetail(CircularVM circularVM)
        {
            return Ok(icircular.DeleteCircularDetail(circularVM));
        }
    }
}
