using GECP_DOT_NET_API.Models;
using GECP_DOT_NET_API.Repository;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace GECP_DOT_NET_API.Controllers
{
    [ApiController]
    public class WorkExperienceController : ControllerBase
    {
        private IWorkExperienceRepo iworkExperienceRepo;
        private IWebHostEnvironment _hostingEnvironment;

        public WorkExperienceController(IWebHostEnvironment environment)
        {
            iworkExperienceRepo = new WorkExperienceRepo();
            _hostingEnvironment = environment;
        }

        [HttpGet, Route("api/GetWorkExperienceDetails")]
        public IActionResult GetWorkExperienceDetails()
        {
            var response = iworkExperienceRepo.GetWorkExperienceDetails();
            return Ok(response);
        }

        [HttpPost, Route("api/AddWorkExperienceDetail")]
        public IActionResult AddWorkExperienceDetail()
        {
            var workExperienceVM = new WorkExperienceVM();
            TryUpdateModelAsync<WorkExperienceVM>(workExperienceVM);
            return Ok(iworkExperienceRepo.AddWorkExperienceDetail(workExperienceVM));
        }

        [HttpPost, Route("api/UpdateWorkExperienceDetail")]
        public IActionResult UpdateWorkExperienceDetail()
        {
            var workExperienceVM = new WorkExperienceVM();
            TryUpdateModelAsync<WorkExperienceVM>(workExperienceVM);
            return Ok(iworkExperienceRepo.UpdateWorkExperienceDetail(workExperienceVM));
        }

        [HttpPost, Route("api/DeleteWorkExperienceDetail")]
        public IActionResult DeleteWorkExperienceDetail(WorkExperienceVM workExperienceVM)
        {
            return Ok(iworkExperienceRepo.DeleteWorkExperienceDetail(workExperienceVM));
        }
    }
}
