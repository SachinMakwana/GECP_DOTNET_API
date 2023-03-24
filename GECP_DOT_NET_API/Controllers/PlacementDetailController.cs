using GECP_DOT_NET_API.Models;
using GECP_DOT_NET_API.Repository;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;

namespace GECP_DOT_NET_API.Controllers
{
    [ApiController]
    public class PlacementDetailController : ControllerBase
    {
        private IPlacementDetailRepo iplacementDetailRepo;
        private IWebHostEnvironment _hostingEnvironment;
        public PlacementDetailController(IWebHostEnvironment environment)
        {
            iplacementDetailRepo = new PlacementDetailRepo();
            _hostingEnvironment = environment;
        }

        [HttpGet, Route("api/GetPlacementDetailsForGraph")]
        public IActionResult GetPlacementDetails()
        {
            var response = iplacementDetailRepo.GetPlacementDetails();
            return Ok(response);
        }
        [HttpPost, Route("api/AddPlacementDetailForGraph")]
        public IActionResult AddPlacementDetail(PlacementDetailsVM detailsVM)
        {
            var response = iplacementDetailRepo.AddPlacementDetail(detailsVM);
            return Ok(response);
        }
        [HttpPost, Route("api/UpdatePlacementDetailForGraph")]
        public IActionResult UpdatePlacementDetail(PlacementDetailsVM detailsVM)
        {

            return Ok(iplacementDetailRepo.UpdatePlacementDetail(detailsVM));
        }
        [HttpPost, Route("api/DeletePlacementDetailForGraph")]
        public IActionResult DeletePlacementDetailForGraph(PlacementDetailsVM detailsVM)
        {
            return Ok(iplacementDetailRepo.DeletePlacementDetailForGraph(detailsVM));
        }
    }
}
