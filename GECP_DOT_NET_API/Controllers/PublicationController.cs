using GECP_DOT_NET_API.Models;
using GECP_DOT_NET_API.Repository;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;

namespace GECP_DOT_NET_API.Controllers
{
    [ApiController]
    public class PublicationController : ControllerBase
    {
        private IPublicationRepo ipublicationRepo;
        private IWebHostEnvironment _hostingEnvironment;

        public PublicationController(IWebHostEnvironment environment)
        {
            ipublicationRepo = new PublicationRepo();
            _hostingEnvironment = environment;
        }

        [HttpGet, Route("api/GetAllPublicationDetails")]
        public IActionResult GetAllPublicationDetails()
        {
            var response = ipublicationRepo.GetAllPublicationDetails();
            return Ok(response);
        }

        [HttpPost, Route("api/AddPublicationDetail")]
        public IActionResult AddPublicationDetail()
        {
            var publicationVM = new PublicationVM();
            TryUpdateModelAsync<PublicationVM>(publicationVM);
            return Ok(ipublicationRepo.AddPublicationDetail(publicationVM));
        }

        [HttpPut, Route("api/UpdatePublicationDetail")]
        public IActionResult UpdatePublicationDetail()
        {
            var publicationVM = new PublicationVM();
            TryUpdateModelAsync<PublicationVM>(publicationVM);
            return Ok(ipublicationRepo.UpdatePublicationDetail(publicationVM));
        }

        [HttpPut, Route("api/DeletePublicationDetail")]
        public IActionResult DeletePublicationDetail(PublicationVM publicationVM)
        {
            return Ok(ipublicationRepo.DeletePublicationDetail(publicationVM));
        }

    }
}
