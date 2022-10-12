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
    public class DesignationController : ControllerBase
    {
        private IDesignationRepo idesignationRepo;
        private IWebHostEnvironment _hostingEnvironment;

        public DesignationController(IWebHostEnvironment environment)
        {
            idesignationRepo = new DesignationRepo();
            _hostingEnvironment = environment;
        }

        [HttpGet, Route("api/GetAllDesignationDetails")]
        public IActionResult GetDesignationDetails()
        {
            var response = idesignationRepo.GetAllDesignationDetails();
            return Ok(response);
        }

        [HttpPost, Route("api/AddDesignationDetail")]
        public IActionResult AddDesignationDetail()
        {
            var designationVM = new DesignationVM();
            TryUpdateModelAsync<DesignationVM>(designationVM);
            return Ok(idesignationRepo.AddDesignationDetail(designationVM));
        }
        [HttpPost, Route("api/UpdateDesignationDetail")]     
        public IActionResult UpdateDesignationDetail()
        {
            var designationVM = new DesignationVM();
            TryUpdateModelAsync<DesignationVM>(designationVM);
            return Ok(idesignationRepo.UpdateDesignationDetail(designationVM));
        }


        [HttpPost, Route("api/DeleteDesignationDetail")]
        public IActionResult DeleteDesignationDetail(DesignationVM designationVM)
        {
            return Ok(idesignationRepo.DeleteDesignationDetail(designationVM));
        }
    }
}
