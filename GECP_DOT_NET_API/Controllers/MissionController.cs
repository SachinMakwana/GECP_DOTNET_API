using GECP_DOT_NET_API.Models;
using GECP_DOT_NET_API.Repository;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;

namespace GECP_DOT_NET_API.Controllers
{
    [ApiController]
    public class MissionController : ControllerBase
    {
        private IMissionRepo imissionRepo;
        private IWebHostEnvironment _hostingEnvironment;

        public MissionController(IWebHostEnvironment environment)
        {
            imissionRepo = new MissionRepo();
            _hostingEnvironment = environment;
        }

        [HttpGet, Route("api/GetAllMissionDetails")]
        public IActionResult GetAllMissionDetails()
        {
            var response = imissionRepo.GetAllMissionDetails();
            return Ok(response);
        }

        [HttpPost, Route("api/AddMissionDetail")]
        public IActionResult AddMissionDetail(MissionVM missionVM)
        {
            return Ok(imissionRepo.AddMissionDetail(missionVM));
        }

        [HttpPut, Route("api/UpdateMissionDetail")]
        public IActionResult UpdateMissionDetail(MissionVM missionVM)
        {
            return Ok(imissionRepo.UpdateMissionDetail(missionVM));
        }

        [HttpPut, Route("api/DeleteMissionDetail")]
        public IActionResult DeleteMissionDetail(MissionVM missionVM)
        {
            return Ok(imissionRepo.DeleteMissionDetail(missionVM));
        }
    }
}
