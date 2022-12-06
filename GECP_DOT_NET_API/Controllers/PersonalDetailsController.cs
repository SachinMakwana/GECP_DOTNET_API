using GECP_DOT_NET_API.Models;
using GECP_DOT_NET_API.Repository;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;

namespace GECP_DOT_NET_API.Controllers
{
    public class PersonalDetailsController : Controller
    {
        private IPersonalDetailRepo ipersonalDetailRepo;
        private IWebHostEnvironment _hostingEnvironment;

        public PersonalDetailsController(IWebHostEnvironment environment)
        {
            ipersonalDetailRepo = new PersonalDetailRepo();
            _hostingEnvironment = environment;
        }

        [HttpGet, Route("api/GetAllPersonalDetails")]
        public IActionResult GetAllPersonalDetails()
        {
            var response = ipersonalDetailRepo.GetAllPersonalDetails();
            return Ok(response);
        }

        [HttpPost, Route("api/AddPersonalDetail")]
        public IActionResult AddPersonalDetail(PersonalDetailVM personalDetailVM)
        {

            return Ok(ipersonalDetailRepo.AddPersonalDetail(personalDetailVM));
        }
        [HttpPost, Route("api/UpdatePersonalDetail")]
        public IActionResult UpdatePersonalDetail(PersonalDetailVM personalDetailVM)
        {

            return Ok(ipersonalDetailRepo.UpdatePersonalDetail(personalDetailVM));
        }

        [HttpPost, Route("api/DeletePersonalDetail")]
        public IActionResult DeletePersonalDetail(PersonalDetailVM personalDetailVM)
        {
            return Ok(ipersonalDetailRepo.DeletePersonalDetail(personalDetailVM));
        }
    }
}
