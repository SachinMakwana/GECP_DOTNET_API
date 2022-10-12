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
    public class MediaLinkController : ControllerBase
    {
        private IMediaLinkRepo imediaLinkRepo;
        private IWebHostEnvironment _hostingEnvironment;

        public MediaLinkController(IWebHostEnvironment environment)
        {
            imediaLinkRepo = new MediaLinkRepo();
            _hostingEnvironment = environment;
        }

        [HttpGet, Route("api/GetAllMediaLinkDetails")]
        public IActionResult GetAllMediaLinkDetails()
        {
            var response = imediaLinkRepo.GetAllMediaLinkDetails();
            return Ok(response);
        }

        [HttpPost, Route("api/AddMediaLinkDetail")]
        public IActionResult AddMediaLinkDetail()
        {
            var medaiLinkVM = new MediaLinkVM();
            TryUpdateModelAsync<MediaLinkVM>(medaiLinkVM);
            return Ok(imediaLinkRepo.AddMediaLinkDetail(medaiLinkVM));
        }

        [HttpPost, Route("api/DeleteMediaLinkDetail")]
        public IActionResult DeleteMediaLinkDetail(MediaLinkVM mediaLinkVM)
        {
            return Ok(imediaLinkRepo.DeleteMediaLinkDetail(mediaLinkVM));
        }

    }
}
