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
    }
}