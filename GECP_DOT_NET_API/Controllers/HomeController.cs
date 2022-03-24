using GECP_DOT_NET_API.Models;
using GECP_DOT_NET_API.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GECP_DOT_NET_API.Controllers
{
   
    [ApiController]
    public class HomeController : ControllerBase
    {
        IDemo iDemo;
        public HomeController()
        {
            iDemo = new Demo();

        }
        [HttpGet]
        [Route("a")]
        public IActionResult CollegeList()
        {
            FacultyDetailsVM obj = new FacultyDetailsVM()
            {
                Id = 1,
                Name = "XYZ",
                DeptId = 1,
                DesignationId = 1,
                IsDeleted = false,
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now
            };

            FacultyDetailsVM obj3 = new FacultyDetailsVM()
            {
                Id = 0,
                Name = "XYZ",
                DeptId = 1,
                DesignationId = 1,
                IsDeleted = true,
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now
            };

            FacultyDetailsVM obj2 = new FacultyDetailsVM()
            {
                Id = 0,
                Name = "ABC",
                DeptId = 1,
                DesignationId = 1,
                IsDeleted = false,
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now
            };
            //var status = iDemo.AddFacultyDetail(obj);
            //var status2 = iDemo.UpdateFacultyDetail(obj2);
            //var status3 = iDemo.DeleteFacultyDetail(obj3);
            var status4 = iDemo.GetFacultyDetail(0);
            return Ok(status4);
        }
    }
}
