using GECP_DOT_NET_API.Database;
using GECP_DOT_NET_API.Models;
using GECP_DOT_NET_API.Repository.Committee;
using GECP_DOT_NET_API.Repository.CommitteeRepositoty;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GECP_DOT_NET_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommitteeController : ControllerBase
    {
        private readonly ICommittee _committee;

        public CommitteeController(ICommittee committees)
        {
            _committee = committees;
        }

        [HttpGet("List")]
        public async Task<ActionResult<ServiceResponse<List<Committee>>>> GetAllCommittee()
        {
            return Ok(await _committee.GetAllCommittee());
        }
    }
}
