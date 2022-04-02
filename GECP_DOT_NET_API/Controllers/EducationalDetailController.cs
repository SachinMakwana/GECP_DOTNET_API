using GECP_DOT_NET_API.Models;
using GECP_DOT_NET_API.Repository;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace GECP_DOT_NET_API.Controllers
{
    [ApiController]
    public class EducationalDetailController : ControllerBase
    {
        private IEducationalDetailRepo ieducationalDetailRepo;
        private IWebHostEnvironment _hostingEnvironment;

        public EducationalDetailController(IWebHostEnvironment environment)
        {
            ieducationalDetailRepo = new EducationalDetailRepo();
            _hostingEnvironment = environment;
        }

        [HttpGet, Route("api/GetAllEducationalDetails")]
        public IActionResult GetAllEducationalDetails()
        {
            var response = ieducationalDetailRepo.GetAllEducationalDetails();
            return Ok(response);
        }

        [HttpPost, Route("api/AddPlacementDetail")]
        public IActionResult AddEducationDetail()
        {
            var educationDetailVM = new EducationalDetailsVM();
            TryUpdateModelAsync<EducationalDetailsVM>(educationDetailVM);
            return Ok(ieducationalDetailRepo.AddEducationDetail(educationDetailVM));
        }

        [HttpPut, Route("api/UpdateEducationDetail")]
        public IActionResult UpdateEducationDetail()
        {
            var educationDetailVM = new EducationalDetailsVM();
            TryUpdateModelAsync<EducationalDetailsVM>(educationDetailVM);
            return Ok(ieducationalDetailRepo.UpdateEducationDetail(educationDetailVM));
        }

        [HttpPut, Route("api/DeleteEducationDetail")]
        public IActionResult DeletePlacementDetail(EducationalDetailsVM educationalDetailsVM)
        {
            return Ok(ieducationalDetailRepo.DeleteEducationDetail(educationalDetailsVM));
        }
    }
}
