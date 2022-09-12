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


namespace GECP_DOT_NET_API.Controllers
{
    [ApiController]
    public class DepartmentAmentyController : ControllerBase
    {
        private IDepartmentAmentyRepo idepartmentAmentyRepo;
        private IWebHostEnvironment _hostingEnvironment;

        public DepartmentAmentyController(IWebHostEnvironment environment)
        {
            idepartmentAmentyRepo = new DepartmentAmentyRepo();
            _hostingEnvironment = environment;
        }

        [HttpGet, Route("api/GetDepartmentAmentyDetails")]
        public IActionResult GetDepartmentAmentyDetails()
        {
            var response = idepartmentAmentyRepo.GetDepartmentAmentyDetails();
            return Ok(response);
        }

        [HttpPost, Route("api/AddDepartmentAmentyDetail")]
        public IActionResult AddDepartmentAmentyDetail(DepartmentAmentyVM departmentAmentyVM)
        {
            return Ok(idepartmentAmentyRepo.AddDepartmentAmentyDetail(departmentAmentyVM));
        }

        [HttpPut, Route("api/UpdateDepartmentAmentyDetail")]
        public IActionResult UpdateDepartmentAmentyDetail(DepartmentAmentyVM departmentAmentyVM)
        {
            return Ok(idepartmentAmentyRepo.UpdateDepartmentAmentyDetail(departmentAmentyVM));
        }

        [HttpPut, Route("api/DeleteDepartmentAmentyDetail")]
        public IActionResult DeletePlacementDetail(DepartmentAmentyVM departmentAmentyVM)
        {
            return Ok(idepartmentAmentyRepo.DeleteDepartmentAmentyDetail(departmentAmentyVM));
        }
    }
}
