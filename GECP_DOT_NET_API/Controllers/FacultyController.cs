using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using GECP_DOT_NET_API.Dtos.Faculty;
using GECP_DOT_NET_API.Repository.FacultyRepository;
using GECP_DOT_NET_API.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GECP_DOT_NET_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FacultyController : ControllerBase
    {
        private readonly IFaculty _faculty;

        public FacultyController(IFaculty faculty)
        {
            _faculty = faculty;
        }

        [HttpGet("List")]

        public async Task<ActionResult<ServiceResponse<List<Faculty>>>> GetAllFaculty()
        {
            return Ok(await _faculty.GetAllFaculty());
        }

        [HttpPost("Add")]
        public async Task<ActionResult<ServiceResponse<List<Faculty>>>> AddFaculty(Faculty newFaculty)
        {
            return Ok(await _faculty.AddFaculty(newFaculty));
        }

        [HttpPut("Edit")]
        public async Task<ActionResult<ServiceResponse<List<Faculty>>>> UpdateFaculty(Faculty updatedFaculty)
        {
            var response = await _faculty.UpdateFaculty(updatedFaculty);
            if (response.Data == null)
            {
                return NotFound(response);
            }
            return Ok(response);
        }
        [HttpPut("Delete")]
        public async Task<ActionResult<ServiceResponse<List<Faculty>>>> DeleteFaculty(int id)
        {
            var response = await _faculty.DeleteFaculty(id);
            if (response.Data == null)
            {
                return NotFound(response);
            }
            return Ok(response);
        }
    }
}
