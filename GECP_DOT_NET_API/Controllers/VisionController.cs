using GECP_DOT_NET_API.Models;
using GECP_DOT_NET_API.Repository;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GECP_DOT_NET_API.Properties
{
    [ApiController]
    public class VisionController : ControllerBase
    {
        private IVisionRepo ivisionRepo;
        private IWebHostEnvironment _hostingEnvironment;

        public VisionController(IWebHostEnvironment environment)
        {
            ivisionRepo = new VisionRepo();
            _hostingEnvironment = environment;
        }

        [HttpGet, Route("api/GetAllVisionDetails")]
        public IActionResult GetAllVisionDetails()
        {
            var response = ivisionRepo.GetAllVisionDetails();
            return Ok(response);
        }

        [HttpPost, Route("api/GetVissionDetail")]
        public IActionResult GetVissionDetail(VisionVM vission)
        {
            //var vission = new VisionVM();
            //TryUpdateModelAsync<VisionVM>(vission);
            var response = ivisionRepo.GetVissionDetail(vission);
            if (response == null)
            {
                return NotFound();
            }
            return Ok(response);
        }

        [HttpPost, Route("api/AddVisionDetail")]
        public IActionResult AddVisionDetail(VisionVM visionVM)
        {
            return Ok(ivisionRepo.AddVisionDetail(visionVM));
        }

        [HttpPut, Route("api/UpdateVisionDetail")]
        public IActionResult UpdateVisionDetail(VisionVM visionVM)
        {
            return Ok(ivisionRepo.UpdateVisionDetail(visionVM));
        }

        [HttpPut, Route("api/DeleteVisionDetail")]
        public IActionResult DeleteVisionDetail(VisionVM visionVM)
        {
            return Ok(ivisionRepo.DeleteVisionDetail(visionVM));
        }
    }
}
