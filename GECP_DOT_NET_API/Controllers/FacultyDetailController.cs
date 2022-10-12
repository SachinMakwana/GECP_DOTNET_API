using GECP_DOT_NET_API.Database;
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
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace GECP_DOT_NET_API.Controllers
{
    [ApiController]
    public class FacultyDetailController : ControllerBase
    {
        private IFacultyRepo ifacultyRepo;
        private IWebHostEnvironment _hostingEnvironment;

        public FacultyDetailController(IWebHostEnvironment environment)
        {
            ifacultyRepo = new FacultyRepo();
            _hostingEnvironment = environment;
        }

        [HttpGet, Route("api/GetAllFacultyDetails")]
        public IActionResult GetFacultyDetails()
        {
            var response = ifacultyRepo.GetAllFacultyDetails();
            return Ok(response);
        }

        [HttpPost, Route("api/AddFacultyDetail")]
        public IActionResult AddFacultyDetail(IFormCollection collection)
        {
            var file = collection.Files.FirstOrDefault();
            var facultyVM = new FacultyDetailsVM();
            TryUpdateModelAsync<FacultyDetailsVM>(facultyVM);
            string filepath = string.Empty;
            var split = file.FileName.Split('.');
            string fileName = Guid.NewGuid().ToString() + "." + split[split.Length - 1];
            string dir;
            if (_hostingEnvironment.WebRootPath != null)
            {
                dir = Path.Combine(_hostingEnvironment.WebRootPath, "uploads/faculty/img");
            }
            else
            {
                dir = "uploads/faculty/img";

            }
            filepath = dir + "/" + fileName;
            var fileUploadTask = FileUpload.SaveFile(file, filepath, dir);
            fileUploadTask.Wait();
            bool status = fileUploadTask.Result;
            if (status)
            {
                facultyVM.Image = filepath;
                return Ok(ifacultyRepo.AddFacultyDetail(facultyVM));
            }
            return Ok();
        }

        [HttpPost, Route("api/UpdateFacultyDetail")]
        public IActionResult UpdateFacultyDetail([FromForm] FacultyDetailsVM facultyVM, [Optional] IFormCollection collection)
        {
            var file = collection.Files.FirstOrDefault();
            string filepath = string.Empty;
            string dir;
            if (_hostingEnvironment.WebRootPath != null)
            {
                dir = Path.Combine(_hostingEnvironment.WebRootPath, "uploads/faculty/img");
            }
            else
            {
                dir = "uploads/faculty/img";

            }
            if (file != null && file.Length > 0)
            {
                var split = file.FileName.Split('.');
                string fileName = Guid.NewGuid().ToString() + "." + split[split.Length - 1];
                filepath = dir + "/" + fileName;
                var fileUploadTask = FileUpload.SaveFile(file, filepath, dir);
                fileUploadTask.Wait();
                bool status = fileUploadTask.Result;
                if (status)
                {
                    facultyVM.Image = filepath;
                    return Ok(ifacultyRepo.UpdateFacultyDetail(facultyVM));
                }
            }
            else
            {
                facultyVM.Image = !string.IsNullOrWhiteSpace(facultyVM.Image) ? facultyVM.Image : string.Empty;
                return Ok(ifacultyRepo.UpdateFacultyDetail(facultyVM));
            }
            return Ok();
        }

        [HttpPost, Route("api/DeleteFacultyDetail")]
        public IActionResult DeleteFacultyDetail(FacultyDetailsVM facultyVM)
        {
            return Ok(ifacultyRepo.DeleteFacultyDetail(facultyVM));
        }
    }
}
