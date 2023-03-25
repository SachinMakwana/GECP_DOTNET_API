using GECP_DOT_NET_API.Models;
using GECP_DOT_NET_API.Repository;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;

namespace GECP_DOT_NET_API.Controllers
{
    public class UsersDetailController : Controller
    {
        private IUsersDetailsRepo iuserdetailRepo;
        private IWebHostEnvironment _hostingEnvironment;

        public UsersDetailController(IWebHostEnvironment environment)
        {
            iuserdetailRepo = new UsersDetailsRepo();
            _hostingEnvironment = environment;
        }

        [HttpGet, Route("api/GetAllUsersDetails")]
        public IActionResult GetUsersDetails()
        {
            var response = iuserdetailRepo.GetUsersDetails();
            return Ok(response);
        }

        [HttpPost, Route("api/AddUsersDetail")]
        public IActionResult AddUsersDetail(UserDetailVM userVM)
        {
            return Ok(iuserdetailRepo.AddUsersDetail(userVM));
        }
        [HttpPost, Route("api/RestPasswordUsersDetail")]
        public IActionResult RestPasswordUsersDetail(UserDetailVM userVM)
        {
            return Ok(iuserdetailRepo.RestPasswordUsersDetail(userVM));
        }

        [HttpPost, Route("api/DeleteUsersDetail")]
        public IActionResult DeleteUsersDetail(UserDetailVM userVM)
        {
            return Ok(iuserdetailRepo.DeleteUsersDetail(userVM));
        }
    }
}
