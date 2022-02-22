using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GECP_DOT_NET_API.Repository.CollegeRepository;
using GECP_DOT_NET_API.Models;

namespace GECP_DOT_NET_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CollegeController : ControllerBase
    {
        private readonly ICollege _college;

        public CollegeController(ICollege college)
        {
            _college = college;
        }

        [HttpGet("List")]

        public async Task<ActionResult<ServiceResponse<List<CollegeVM>>>> GetAllCollege()
        {
            return Ok(await _college.GetAllCollege());
        }

        [HttpPut("Edit")]
        public async Task<ActionResult<ServiceResponse<List<CollegeVM>>>> UpdateCollege(CollegeVM updatedCollegeVM)
        {
            var response = await _college.UpdateCollege(updatedCollegeVM);
            if (response.Data == null)
            {
                return NotFound(response);
            }
            return Ok(response);
        }
      
    }
}
