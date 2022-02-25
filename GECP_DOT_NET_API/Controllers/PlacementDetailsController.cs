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
        public IActionResult AddPlacementDetail(IFormFile file, PlacementVM placementVM)
        {
            //PlacementVM placementVM = new PlacementVM();
            string filepath = string.Empty;
            if (_hostingEnvironment.WebRootPath != null)
            {
                filepath = Path.Combine(_hostingEnvironment.WebRootPath, "uploads/placements/students/" + Guid.NewGuid().ToString() + "." + file.FileName.Split('.')[1]);
            }
            else
            {
                filepath = Path.Combine("uploads/placements/students/", Guid.NewGuid().ToString() + "." + file.FileName.Split('.')[1]);

            }
            var fileUploadTask = FileUpload.SaveFile(file, filepath);
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
        public IActionResult UpdatePlacementDetail(PlacementVM placementVM)
        {
            return Ok(iplacementRepo.UpdatePlacementDetail(placementVM));
        }

        [HttpPut, Route("api/DeletePlacementDetail")]
        public IActionResult DeletePlacementDetail(PlacementVM placementVM)
        {
            return Ok(iplacementRepo.DeletePlacementDetail(placementVM));
        }
    }
}
