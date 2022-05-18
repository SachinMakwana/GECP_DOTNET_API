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

namespace GECP_DOT_NET_API.Controllers
{
    [ApiController]
    public class CollegeDetailController : ControllerBase
    {
        private ICollegeRepo icollegeRepo;
        private IWebHostEnvironment _hostingEnvironment;

        public CollegeDetailController(IWebHostEnvironment environment)
        {
            icollegeRepo = new CollegeRepo();
            _hostingEnvironment = environment;
        }

        [HttpGet, Route("api/GetCollegeDetails")]
        public IActionResult GetCollegeDetails()
        {
            var response = icollegeRepo.GetCollegeDetails();
            return Ok(response);
        }

        [HttpPut, Route("api/UpdateCollegeDetail")]
        public IActionResult UpdateCollegeDetail(IFormCollection collection)
        {
            var file = collection.Files.FirstOrDefault();
            var collegeVM = new CollegeVM();
            TryUpdateModelAsync<CollegeVM>(collegeVM);
            string filepath = string.Empty;
            string dir;
            if (_hostingEnvironment.WebRootPath != null)
            {
                dir = Path.Combine(_hostingEnvironment.WebRootPath, "uploads/College/img");
            }
            else
            {
                dir = "uploads/College/img";

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
