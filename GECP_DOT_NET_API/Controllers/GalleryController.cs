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
    public class GalleryController : ControllerBase
    {
        private IGalleryRepo igalleryRepo;
        private IWebHostEnvironment _hostingEnvironment;

        public GalleryController(IWebHostEnvironment environment)
        {
            igalleryRepo = new GalleryRepo();
            _hostingEnvironment = environment;
        }

        [HttpGet, Route("api/GetAllGalleryDetails")]
        public IActionResult GetAllGalleryDetails()
        {
            var response = igalleryRepo.GetAllGalleryDetails();
            return Ok(response);
        }

        [HttpPost, Route("api/AddGalleryDetail")]
        public IActionResult AddGalleryDetail(IFormCollection collection)
        {
            var file = collection.Files.FirstOrDefault();
            var galleryVM = new GalleryVM();
            TryUpdateModelAsync<GalleryVM>(galleryVM);
            string filepath = string.Empty;
            string fileName = Guid.NewGuid().ToString() + "." + file.FileName.Split('.')[1];
            string dir;
            if (_hostingEnvironment.WebRootPath != null)
            {
                dir = Path.Combine(_hostingEnvironment.WebRootPath, "uploads/gallery/img");
            }
            else
            {
                dir = "uploads/gallery/img";

            }
            filepath = dir + "/" + fileName;
            var fileUploadTask = FileUpload.SaveFile(file, filepath, dir);
            fileUploadTask.Wait();
            bool status = fileUploadTask.Result;
            if (status)
            {
                galleryVM.Image = filepath;
                return Ok(igalleryRepo.AddGalleryDetail(galleryVM));
            }
            return Ok();
        }


        [HttpPut, Route("api/UpdateGalleryDetail")]
        public IActionResult UpdateGalleryDetail(IFormCollection collection)
        {
            var file = collection.Files.FirstOrDefault();
            var galleryVM = new GalleryVM();
            TryUpdateModelAsync<GalleryVM>(galleryVM);
            string filepath = string.Empty;
            string dir;
            if (_hostingEnvironment.WebRootPath != null)
            {
                dir = Path.Combine(_hostingEnvironment.WebRootPath, "uploads/gallery/img");
            }
            else
            {
                dir = "uploads/gallery/img";

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
                    galleryVM.Image = filepath;
                    return Ok(igalleryRepo.UpdateGalleryDetail(galleryVM));
                }
            }
            else
            {
                galleryVM.Image = string.Empty;
                return Ok(igalleryRepo.UpdateGalleryDetail(galleryVM));
            }
            return Ok();
        }

        [HttpPut, Route("api/DeleteGalleryDetail")]
        public IActionResult DeletePlacementDetail(GalleryVM galleryVM)
        {
            return Ok(igalleryRepo.DeleteGalleryDetail(galleryVM));
        }

    }
}
