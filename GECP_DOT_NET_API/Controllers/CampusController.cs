using GECP_DOT_NET_API.Helper;
using GECP_DOT_NET_API.Models;
using GECP_DOT_NET_API.Repository;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using System.Linq;
using System;

namespace GECP_DOT_NET_API.Controllers
{
    
    [ApiController]
    public class CampusController : ControllerBase
    {
        private ICampusRepo icampusRepo;
        private IWebHostEnvironment _hostingEnvironment;

        public CampusController(IWebHostEnvironment environment)
        {
            icampusRepo = new CampusRepo();
            _hostingEnvironment = environment;
        }

        [HttpGet, Route("api/GetAllCampusDetails")]
        public IActionResult GetAllCampusDetails()
        {
            var response = icampusRepo.GetAllCampusDetails();
            return Ok(response);
        }

        [HttpPost, Route("api/AddCampusDetails")]
        public IActionResult AddCampusDetails(IFormCollection collection)
        {
            var file = collection.Files.FirstOrDefault();
            var campusVM = new CampusVM();
            TryUpdateModelAsync<CampusVM>(campusVM);
            string filepath = string.Empty;
            var split = file.FileName.Split('.');
            string fileName = Guid.NewGuid().ToString() + "." + split[split.Length - 1];
            string dir;
            if (_hostingEnvironment.WebRootPath != null)
            {
                dir = Path.Combine(_hostingEnvironment.WebRootPath, "uploads/campus");
            }
            else
            {
                dir = "uploads/campus";

            }
            filepath = dir + "/" + fileName;
            var fileUploadTask = FileUpload.SaveFile(file, filepath, dir);
            fileUploadTask.Wait();
            bool status = fileUploadTask.Result;
            if (status)
            {
                campusVM.Image = filepath;
                return Ok(icampusRepo.AddCampusDetails(campusVM));
            }
            return Ok();
        }

        [HttpPost, Route("api/UpdateCampusDetail")]
        public IActionResult UpdateCampusDetail(IFormCollection collection)
        {
            var file = collection.Files.FirstOrDefault();
            var campusVM = new CampusVM();
            TryUpdateModelAsync<CampusVM>(campusVM);
            string filepath = string.Empty;
            string dir;
            if (_hostingEnvironment.WebRootPath != null)
            {
                dir = Path.Combine(_hostingEnvironment.WebRootPath, "uploads/campus");
            }
            else
            {
                dir = "uploads/campus";

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
                    campusVM.Image = filepath;
                    return Ok(icampusRepo.UpdateCampusDetail(campusVM));
                }
            }
            else
            {
                campusVM.Image = string.Empty;
                return Ok(icampusRepo.UpdateCampusDetail(campusVM));
            }
            return Ok();
        }

        [HttpPost, Route("api/DeleteCampusDetail")]
        public IActionResult DeleteCampusDetail(CampusVM campusVM)
        {
            return Ok(icampusRepo.DeleteCampusDetail(campusVM));
        }



    }
}
