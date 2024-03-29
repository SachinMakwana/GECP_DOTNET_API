﻿using GECP_DOT_NET_API.Helper;
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
        private IPlacementDetailRepo iplacementDetailRepo;
        private IWebHostEnvironment _hostingEnvironment;

        public PlacementDetailsController(IWebHostEnvironment environment)
        {
            iplacementRepo = new PlacementRepo();
            iplacementDetailRepo = new PlacementDetailRepo();
            _hostingEnvironment = environment;
        }

        [HttpGet, Route("api/GetPlacementDetailsForGraph")]
        public IActionResult GetPlacementDetailsGraph()
        {
            var response = iplacementDetailRepo.GetPlacementDetailsGraph();
            return Ok(response);
        }
        [HttpPost, Route("api/AddPlacementDetailForGraph")]
        public IActionResult AddPlacementDetail(PlacementDetailsVM detailsVM)
        {
            var response = iplacementDetailRepo.AddPlacementDetail(detailsVM);
            return Ok(response);
        }
        [HttpPost, Route("api/UpdatePlacementDetailForGraph")]
        public IActionResult UpdatePlacementDetail(PlacementDetailsVM detailsVM)
        {

            return Ok(iplacementDetailRepo.UpdatePlacementDetail(detailsVM));
        }
        [HttpPost, Route("api/DeletePlacementDetailForGraph")]
        public IActionResult DeletePlacementDetailForGraph(PlacementDetailsVM detailsVM)
        {
            return Ok(iplacementDetailRepo.DeletePlacementDetailForGraph(detailsVM));
        }
        [HttpGet, Route("api/GetPlacementDetails")]
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
            var split = file.FileName.Split('.');
            string fileName = Guid.NewGuid().ToString() + "." + split[split.Length - 1];
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

        [HttpPost, Route("api/UpdatePlacementDetail")]
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
                var split = file.FileName.Split('.');
                string fileName = Guid.NewGuid().ToString() + "." + split[split.Length - 1];
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

        [HttpPost, Route("api/DeletePlacementDetail")]
        public IActionResult DeletePlacementDetail(PlacementVM placementVM)
        {
            return Ok(iplacementRepo.DeletePlacementDetail(placementVM));
        }
    }
}
