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
    public class GalleryTagController : ControllerBase
    {
        private IGalleryTagRepo igalleryTagRepo;
        private IWebHostEnvironment _hostingEnvironment;

        public GalleryTagController(IWebHostEnvironment environment)
        {
            igalleryTagRepo = new GalleryTagRepo();
            _hostingEnvironment = environment;
        }

        [HttpGet, Route("api/GetAllGalleryTag")]
        public IActionResult GetAllGalleryTag()
        {
            var response = igalleryTagRepo.GetAllGalleryTag();
            return Ok(response);
        }

        [HttpPost, Route("api/AddGalleryTagDetail")]
        public IActionResult AddGalleryTagDetail()
        {
            var galleryTagVM = new GalleryTagVM();
            TryUpdateModelAsync<GalleryTagVM>(galleryTagVM);
            return Ok(igalleryTagRepo.AddGalleryTagDetail(galleryTagVM));
        }

        [HttpPost, Route("api/UpdateGalleryTagDetail")]
        public IActionResult UpdateGalleryTagDetail()
        {
            var galleryTagVM = new GalleryTagVM();
            TryUpdateModelAsync<GalleryTagVM>(galleryTagVM);
            return Ok(igalleryTagRepo.UpdateGalleryTagDetail(galleryTagVM));
        }

        [HttpPost, Route("api/DeleteGalleryTagDetail")]
        public IActionResult DeleteGalleryTagDetail(GalleryTagVM galleryTagVM)
        {
            return Ok(igalleryTagRepo.DeleteGalleryTagDetail(galleryTagVM));
        }
    }
}
