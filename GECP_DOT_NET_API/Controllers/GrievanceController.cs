using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GECP_DOT_NET_API.Repository;
using GECP_DOT_NET_API.Models;

namespace GECP_DOT_NET_API.Controllers
{
    [ApiController]
    public class GrievanceController : ControllerBase
    {
        IGrievanceRepo iGrievanceRepo;
        public GrievanceController()
        {
            iGrievanceRepo = new GrievanceRepo();
        }
        //Get All the Grievance if 0
        //else get Grievance by department id
        [HttpGet,Route("api/GetAllGrievances")]
        public IActionResult GetAllGrievance(int deptID=0)
        {
            return Ok(iGrievanceRepo.GetAllGrievances());
        }
        [HttpPost,Route("api/AddGrievance")]
        public IActionResult AddGrievance(GrievanceVM grievanceVM)
        {
            return Ok(iGrievanceRepo.AddGrievance(grievanceVM));
        }
        [HttpPost, Route("api/UpdateGrievanceStatus")]
        public IActionResult UpdateGrievanceStatus(GrievanceStatusVM grievanceStatusVM)
        {
            return Ok(iGrievanceRepo.AddGrievanceStatus(grievanceStatusVM));
        }
    }
}
