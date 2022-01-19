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
            
            return Ok(iDemo.GetNames());
        }
    }
}
