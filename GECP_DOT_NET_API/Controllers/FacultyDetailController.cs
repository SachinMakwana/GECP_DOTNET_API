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
    public class FacultyDetailController : ControllerBase
    {
        private IFacultyRepo ifacultyRepo;
        private IWebHostEnvironment _hostingEnvironment;

        public FacultyDetailController(IWebHostEnvironment environment)
        {
            ifacultyRepo = new FacultyRepo();
            _hostingEnvironment = environment;
        }

        [HttpGet, Route("api/GetAllFacultyDetails")]
        public IActionResult GetFacultyDetails()
        {
            var response = ifacultyRepo.GetAllFacultyDetails();
            return Ok(response);
        }

        [HttpPost, Route("api/AddFacultyDetail")]
        public IActionResult AddFacultyDetail(IFormCollection collection)
        {
            var facultyVM = new FacultyDetailsVM();
            return Ok(ifacultyRepo.AddFacultyDetail(facultyVM));
        }

        [HttpPut, Route("api/UpdateFacultyDetail")]
        public IActionResult UpdateFacultyDetail(IFormCollection collection)
        {
            
            var facultyVM = new FacultyDetailsVM();
            return Ok(ifacultyRepo.UpdateFacultyDetail(facultyVM));
        }

        [HttpPut, Route("api/DeleteFacultyDetail")]
        public IActionResult DeleteFacultyDetail(FacultyDetailsVM facultyVM)
        {
            return Ok(ifacultyRepo.DeleteFacultyDetail(facultyVM));
        }
    }
}
