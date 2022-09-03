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
    public class CommitteeController : ControllerBase
    {
        private ICommitteeRepo icommitteeRepo;
        private IWebHostEnvironment _hostingEnvironment;

        public CommitteeController(IWebHostEnvironment environment)
        {
            icommitteeRepo = new CommitteeRepo();
            _hostingEnvironment = environment;
        }

        [HttpGet, Route("api/GetAllCommitteeDetails")]
        public IActionResult GetCommitteeDetails()
        {
            var response = icommitteeRepo.GetAllCommitteeDetails();
            return Ok(response);
        }

        [HttpGet, Route("api/GetCommitteeDetail")]
        public ActionResult<CommitteeVM> GetCommitteeDetail(IFormCollection collection)
        {
            var committee = new CommitteeVM();
            TryUpdateModelAsync<CommitteeVM>(committee);
            var response = icommitteeRepo.GetCommitteeDetail(committee);
            if(response == null)
            {
                return NotFound();
            }
            return Ok(response);
        }

        [HttpPost, Route("api/AddCommitteeDetail")]
        public IActionResult AddCommitteeDetail(IFormCollection collection)
        {
            var file = collection.Files.FirstOrDefault();
            var committeeVM = new CommitteeVM();
            TryUpdateModelAsync<CommitteeVM>(committeeVM);
            string filepath = string.Empty;
            string fileName = Guid.NewGuid().ToString() + "." + file.FileName.Split('.')[1];
            string dir;
            if (_hostingEnvironment.WebRootPath != null)
            {
                dir = Path.Combine(_hostingEnvironment.WebRootPath, "uploads/committee/img");
            }
            else
            {
                dir = "uploads/committee/img";

            }
            filepath = dir + "/" + fileName;
            var fileUploadTask = FileUpload.SaveFile(file, filepath, dir);
            fileUploadTask.Wait();
            bool status = fileUploadTask.Result;
            if (status)
            {
                committeeVM.Image = filepath;
                return Ok(icommitteeRepo.AddCommitteeDetail(committeeVM));
            }
            return Ok();
        }

        [HttpPut, Route("api/UpdateCommitteeDetail")]
        public IActionResult UpdateCommitteeDetail(IFormCollection collection)
        {
            var file = collection.Files.FirstOrDefault();
            var committeeVM = new CommitteeVM();
            TryUpdateModelAsync<CommitteeVM>(committeeVM);
            string filepath = string.Empty;
            string dir;
            if (_hostingEnvironment.WebRootPath != null)
            {
                dir = Path.Combine(_hostingEnvironment.WebRootPath, "uploads/committee/img");
            }
            else
            {
                dir = "uploads/committee/img";

            }
            if (file != null && file.Length > 0)
            {
                string fileName = Guid.NewGuid().ToString() + "." + file.FileName.Split('.')[1];
                filepath = dir + "/" + fileName;
                var fileUploadTask = FileUpload.SaveFile(file, filepath, dir);
                fileUploadTask.Wait();
                bool status = fileUploadTask.Result;
                if (status)
                {
                    committeeVM.Image = filepath;
                    return Ok(icommitteeRepo.UpdateCommitteeDetail(committeeVM));
                }
            }
            else
            {
                committeeVM.Image = string.Empty;
                return Ok(icommitteeRepo.UpdateCommitteeDetail(committeeVM));
            }
            return Ok();
        }

        [HttpPut, Route("api/DeleteCommitteeDetail")]
        public IActionResult DeleteCommitteeDetail(CommitteeVM committeeVM)
        {
            return Ok(icommitteeRepo.DeleteCommitteeDetail(committeeVM));
        }
    }
}
