using GECP_DOT_NET_API.Database;
using GECP_DOT_NET_API.Models;
using GECP_DOT_NET_API.Repository.LabWorkshop;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GECP_DOT_NET_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LabWorkshopController : ControllerBase
    {
        private readonly ILabWorkshop _labworkshop;

        public LabWorkshopController(ILabWorkshop labworkshop)
        {
            _labworkshop = labworkshop;
        }

        [HttpGet("List")]
        public async Task<ActionResult<ServiceResponse<List<LabWorkshopDetail>>>> GetAllLabWorkshop()
        {
            return Ok(await _labworkshop.GetAllLabWorkshop());
        }

        [HttpPost("Add")]
        public async Task<ActionResult<ServiceResponse<List<LabWorkshopDetail>>>> AddLabWorkshop(LabWorkshopDetail labWorkshopDetail)
        {
            return Ok(await _labworkshop.AddLabWorkshop(labWorkshopDetail));
        }

        [HttpPut("Edit")]
        public async Task<ActionResult<ServiceResponse<List<LabWorkshopDetail>>>> EditLabWorkshop(LabWorkshopDetail labWorkshopDetail)
        {
            var response = await _labworkshop.EditLabWorkshop(labWorkshopDetail);
            if (response.Data == null)
            {
                return NotFound(response);
            }
            return Ok(response);
        }

        [HttpPut("Delete")]
        public async Task<ActionResult<ServiceResponse<LabWorkshopDetail>>> DeleteLabWorkshop(int id)
        {
            var response = await _labworkshop.DeleteLabWorkshop(id);
            if (response.Data == null)
            {
                return NotFound(response);
            }
            return Ok(response);
        }

    }
}