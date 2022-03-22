using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GECP_DOT_NET_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GrievanceController : ControllerBase
    {
        //Get All the Grievance if 0
        //else get Grievance by department id
        public IActionResult GetAllGrievance(int deptID=0)
        {
            return Ok();
        }

        public IActionResult AddGrievance()
        {
            return Ok();
        }

        public IActionResult UpdateGrievanceStatus()
        {
            return Ok();
        }
    }
}
