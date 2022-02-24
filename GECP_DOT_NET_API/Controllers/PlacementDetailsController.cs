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


        [HttpGet,Route("api/GetAllPlacementDetails")]
        public IActionResult GetPlacementDetails()
        {
            var response = iplacementRepo.GetAllPlacementDetails();
            return Ok(response);
        }

        [HttpPost, Route("api/AddPlacementDetail")]
        public IActionResult AddPlacementDetail(PlacementVM placementVM, IFormFile file)
        {
            string filepath =  Path.Combine(_hostingEnvironment.WebRootPath, "uploads/placements/students/"+new Guid().ToString()+"."+file.);
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
