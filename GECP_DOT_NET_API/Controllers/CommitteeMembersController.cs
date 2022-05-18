using GECP_DOT_NET_API.Helper;
using GECP_DOT_NET_API.Models;
using GECP_DOT_NET_API.Repository;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace GECP_DOT_NET_API.Controllers
{
    [ApiController]
    public class CommitteeMembersController : ControllerBase
    {
        private ICommitteeMemberRepo icommitteeMemberRepo;
        private IWebHostEnvironment _hostingEnvironment;

        public CommitteeMembersController(IWebHostEnvironment environment)
        {
            icommitteeMemberRepo = new CommitteeMemberRepo();
            _hostingEnvironment = environment;
        }

        [HttpGet, Route("api/GetAllCommitteeMembersDetails")]
        public IActionResult GetCommitteeMembersDetails()
        {
            var response = icommitteeMemberRepo.GetAllCommitteeMembersDetails();
            return Ok(response);
        }

        [HttpPost, Route("api/AddCommitteeMemberDetail")]
        public IActionResult AddCommitteeMemberDetail()
        {
            var committeeMemberVM = new CommitteeMembersVM();
            TryUpdateModelAsync<CommitteeMembersVM>(committeeMemberVM);
            return Ok(icommitteeMemberRepo.AddCommitteeMemberDetail(committeeMemberVM));
        }

        [HttpPut, Route("api/UpdateCommitteeMemberDetail")]
        public IActionResult UpdateCommitteeMemberDetail()
        {
            var committeeMemberVM = new CommitteeMembersVM();
            TryUpdateModelAsync<CommitteeMembersVM>(committeeMemberVM);
            return Ok(icommitteeMemberRepo.UpdateCommitteeMemberDetail(committeeMemberVM));
        }

        [HttpPut, Route("api/DeleteCommitteeMemberDetail")]
        public IActionResult DeletePlacementDetail(CommitteeMembersVM committeeMemberVM)
        {
            return Ok(icommitteeMemberRepo.DeleteCommitteeMemberDetail(committeeMemberVM));
        }
    }
}
