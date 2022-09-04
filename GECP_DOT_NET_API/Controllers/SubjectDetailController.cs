using GECP_DOT_NET_API.Helper;
using GECP_DOT_NET_API.Models;
using GECP_DOT_NET_API.Repository;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace GECP_DOT_NET_API.Controllers
{
    [ApiController]
    public class SubjectDetailController : ControllerBase
    {
        private ISubjectRepo isubjectRepo;
        private IWebHostEnvironment _hostingEnvironment;

        public SubjectDetailController(IWebHostEnvironment environment)
        {
            isubjectRepo = new SubjectRepo();
            _hostingEnvironment = environment;
        }

        [HttpGet, Route("api/GetSubjectDetails")]
        public IActionResult GetSubjectDetails()
        {
            var response = isubjectRepo.GetSubjectDetails();
            return Ok(response);
        }

        [HttpPost, Route("api/AddSubjectDetails")]
        public IActionResult AddSubjectDetails(IFormCollection collection)
        {
            var subjectVM = new SubjectVM();
            TryUpdateModelAsync<SubjectVM>(subjectVM);

            return Ok(isubjectRepo.AddSubjectDetails(subjectVM));
        }

        [HttpPut, Route("api/UpdateSubjectDetails")]
        public IActionResult UpdateSubjectDetails(IFormCollection collection)
        {
            var subjectVM = new SubjectVM();
            TryUpdateModelAsync<SubjectVM>(subjectVM);
            return Ok(isubjectRepo.UpdateSubjectDetails(subjectVM));
        }

        [HttpPut, Route("api/DeleteSubjectDetails")]
        public IActionResult DeleteSubjectDetails(SubjectVM subjectVM)
        {
            return Ok(isubjectRepo.DeleteSubjectDetails(subjectVM));
        }
    }
}
