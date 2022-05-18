using GECP_DOT_NET_API.Models;
using GECP_DOT_NET_API.Repository;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;

namespace GECP_DOT_NET_API.Controllers
{
    [ApiController]
    public class DynamicPageController : ControllerBase
    {
        private IDynamicPageRepo idynamicPageRepo;
        private IWebHostEnvironment _hostingEnvironment;

        public DynamicPageController(IWebHostEnvironment environment)
        {
            idynamicPageRepo = new DynamicPageRepo();
            _hostingEnvironment = environment;
        }

        [HttpGet, Route("api/GetAllDynamicPageDetails")]
        public IActionResult GetAllDynamicPageDetails()
        {
            var response = idynamicPageRepo.GetAllDynamicPageDetails();
            return Ok(response);
        }

        [HttpPost, Route("api/AddDynamicPageDetail")]
        public IActionResult AddDynamicPageDetail()
        {
            var dynamicPageVM = new DynamicPageVM();
            TryUpdateModelAsync<DynamicPageVM>(dynamicPageVM);
            return Ok(idynamicPageRepo.AddDynamicPageDetail(dynamicPageVM));
        }

        [HttpPut, Route("api/UpdateDynamicPageDetail")]
        public IActionResult UpdateDynamicPageDetail()
        {
            var dynamicPageVM = new DynamicPageVM();
            TryUpdateModelAsync<DynamicPageVM>(dynamicPageVM);
            return Ok(idynamicPageRepo.UpdateDynamicPageDetail(dynamicPageVM));
        }

        [HttpPut, Route("api/DeleteDynamicPageDetail")]
        public IActionResult DeleteDynamicPageDetail(DynamicPageVM dynamicPageVM)
        {
            return Ok(idynamicPageRepo.DeleteDynamicPageDetail(dynamicPageVM));
        }
    }
}
