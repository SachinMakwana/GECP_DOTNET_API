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
    public class LabWorkshopController : ControllerBase
    {
        private ILabWorkshopRepo ilabworkshopRepo;
        private IWebHostEnvironment _hostingEnvironment;

        public LabWorkshopController(IWebHostEnvironment environment)
        {
            ilabworkshopRepo = new LabWorkshopRepo();
            _hostingEnvironment = environment;
        }

        [HttpGet, Route("api/GetAllLabWorkshopDetails")]
        public IActionResult GetLabWorkshopDetails()
        {
            var response = ilabworkshopRepo.GetAllLabWorkshopDetails();
            return Ok(response);
        }

        [HttpPost, Route("api/AddLabWorkshopDetail")]
        public IActionResult AddLabWorkshopDetail(IFormCollection collection)
        {
            var file = collection.Files.FirstOrDefault();
            var labworkshopVM = new LabWorkshopVM();
            TryUpdateModelAsync<LabWorkshopVM>(labworkshopVM);
            string filepath = string.Empty;
            var split = file.FileName.Split('.');
            string fileName = Guid.NewGuid().ToString() + "." + split[split.Length-1];
            string dir;
            if (_hostingEnvironment.WebRootPath != null)
            {
                dir = Path.Combine(_hostingEnvironment.WebRootPath, "uploads/labworkshop/lab");
            }
            else
            {
                dir = "uploads/labworkshop/lab";

            }
            filepath = dir + "/" + fileName;
            var fileUploadTask = FileUpload.SaveFile(file, filepath, dir);
            fileUploadTask.Wait();
            bool status = fileUploadTask.Result;
            if (status)
            {
                labworkshopVM.Image = filepath;
                return Ok(ilabworkshopRepo.AddLabWorkshopDetail(labworkshopVM));
            }
            return Ok();
        }

        [HttpPost, Route("api/UpdateLabWorkshopDetail")]
        public IActionResult UpdateLabWorkshopDetail(IFormCollection collection)
        {
            var file = collection.Files.FirstOrDefault();
            var labworkshopVM = new LabWorkshopVM();
            TryUpdateModelAsync<LabWorkshopVM>(labworkshopVM);
            string filepath = string.Empty;
            string dir;
            if (_hostingEnvironment.WebRootPath != null)
            {
                dir = Path.Combine(_hostingEnvironment.WebRootPath, "uploads/labworkshop/lab");
            }
            else
            {
                dir = "uploads/labworkshop/lab";

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
                    labworkshopVM.Image = filepath;
                    return Ok(ilabworkshopRepo.UpdateLabWorkshopDetail(labworkshopVM));
                }
            }
            else
            {
                labworkshopVM.Image = string.Empty;
                return Ok(ilabworkshopRepo.UpdateLabWorkshopDetail(labworkshopVM));
            }
            return Ok();
        }

        [HttpPost, Route("api/DeletePlacementDetail")]
        public IActionResult DeleteLabWorkshopDetail(LabWorkshopVM labworkshopVM)
        {
            return Ok(ilabworkshopRepo.DeleteLabWorkshopDetail(labworkshopVM));
        }
    }
}
