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
    public class PlacementDetailsController : ControllerBase
    {
        private IPlacementRepo iplacementRepo;
        private IWebHostEnvironment _hostingEnvironment;

        public PlacementDetailsController(IWebHostEnvironment environment)
        {
            iplacementRepo = new PlacementRepo();
            _hostingEnvironment = environment;
        }


        [HttpGet, Route("api/GetAllPlacementDetails")]
        public IActionResult GetPlacementDetails()
        {
            var response = iplacementRepo.GetAllPlacementDetails();
            return Ok(response);
        }

        [HttpPost, Route("api/AddPlacementDetail")]
        public IActionResult AddPlacementDetail(IFormCollection collection)
        {
            var file = collection.Files.FirstOrDefault();
            var placementVM = new PlacementVM();
            TryUpdateModelAsync<PlacementVM>(placementVM);
            string filepath = string.Empty;
            string fileName = Guid.NewGuid().ToString() + "." + file.FileName.Split('.')[1];
            string dir;
            if (_hostingEnvironment.WebRootPath != null)
            {
                dir = Path.Combine(_hostingEnvironment.WebRootPath, "uploads/placements/students");
            }
            else
            {
                dir = "uploads/placements/students";

            }
            filepath = dir+"/" + fileName;
            var fileUploadTask = FileUpload.SaveFile(file, filepath,dir);
            fileUploadTask.Wait();
            bool status = fileUploadTask.Result;
            if (status)
            {
                placementVM.StudentPic = filepath;
                return Ok(iplacementRepo.AddPlacementDetail(placementVM));
            }
            return Ok();
        }

        [HttpPut, Route("api/UpdatePlacementDetail")]
        public IActionResult UpdatePlacementDetail(IFormCollection collection)
        {
            var file = collection.Files.FirstOrDefault();
            var placementVM = new PlacementVM();
            TryUpdateModelAsync<PlacementVM>(placementVM);
            string filepath = string.Empty;
            string dir;
            if (_hostingEnvironment.WebRootPath != null)
            {
                dir = Path.Combine(_hostingEnvironment.WebRootPath, "uploads/placements/students");
            }
            else
            {
                dir = "uploads/placements/students";

            }
            if (file !=null && file.Length > 0)
            {
                string fileName = Guid.NewGuid().ToString() + "." + file.FileName.Split('.')[1];
                filepath = dir + "/" + fileName;
                var fileUploadTask = FileUpload.SaveFile(file, filepath, dir);
                fileUploadTask.Wait();
                bool status = fileUploadTask.Result;
                if (status)
                {
                    placementVM.StudentPic = filepath;
                    return Ok(iplacementRepo.UpdatePlacementDetail(placementVM));
                }
            }
            else
            {
                placementVM.StudentPic = string.Empty;
                return Ok(iplacementRepo.UpdatePlacementDetail(placementVM));
            }
            return Ok();
        }

        [HttpPut, Route("api/DeletePlacementDetail")]
        public IActionResult DeletePlacementDetail(PlacementVM placementVM)
        {
            return Ok(iplacementRepo.DeletePlacementDetail(placementVM));
        }
    }
}
