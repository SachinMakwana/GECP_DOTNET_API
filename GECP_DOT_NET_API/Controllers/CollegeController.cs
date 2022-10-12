using GECP_DOT_NET_API.Helper;
using GECP_DOT_NET_API.Models;
using GECP_DOT_NET_API.Repository;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using System;
using System.Linq;

namespace GECP_DOT_NET_API.Controllers
{
    public class CollegeController : ControllerBase
    {
        private ICollegeRepo icollegeRepo;
        private IWebHostEnvironment _hostingEnvironment;

        public CollegeController(IWebHostEnvironment environment)
        {
            icollegeRepo = new CollegeRepo();
            _hostingEnvironment = environment;
        }

        [HttpGet, Route("api/GetCollegeDetail")]
        public IActionResult GetCollegeDetail()
        {
            var response = icollegeRepo.GetCollegeDetail();
            return Ok(response);
        }

        [HttpPost, Route("api/AddCollegeDetail")]
        public IActionResult AddCollegeDetail(IFormCollection collection)
        {
            var file = collection.Files.FirstOrDefault();
            var collegeVM = new CollegeVM();
            TryUpdateModelAsync<CollegeVM>(collegeVM);
            string filepath = string.Empty;
            string fileName = Guid.NewGuid().ToString() + "." + file.FileName.Split('.')[1];
            string dir;
            if (_hostingEnvironment.WebRootPath != null)
            {
                dir = Path.Combine(_hostingEnvironment.WebRootPath, "uploads/college");
            }
            else
            {
                dir = "uploads/college";

            }
            filepath = dir + "/" + fileName;
            var fileUploadTask = FileUpload.SaveFile(file, filepath, dir);
            fileUploadTask.Wait();
            bool status = fileUploadTask.Result;
            if (status)
            {
                collegeVM.Image = filepath;
                return Ok(icollegeRepo.AddCollegeDetail(collegeVM));
            }
            return Ok();
        }

        [HttpPost, Route("api/UpdateCollegeDetail")]
        public IActionResult UpdateCollegeDetail(IFormCollection collection)
        {
            var file = collection.Files.FirstOrDefault();
            var collegeVM = new CollegeVM();
            TryUpdateModelAsync<CollegeVM>(collegeVM);
            string filepath = string.Empty;
            string dir;
            if (_hostingEnvironment.WebRootPath != null)
            {
                dir = Path.Combine(_hostingEnvironment.WebRootPath, "uploads/college");
            }
            else
            {
                dir = "uploads/college";

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
                    collegeVM.Image = filepath;
                    return Ok(icollegeRepo.UpdateCollegeDetail(collegeVM));
                }
            }
            else
            {
                collegeVM.Image = string.Empty;
                return Ok(icollegeRepo.UpdateCollegeDetail(collegeVM));
            }
            return Ok();
        }
    }
}
