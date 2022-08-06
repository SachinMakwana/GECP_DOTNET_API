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
    public class NewsController : ControllerBase
    {
        private INewsRepo inewsRepo;
        private IWebHostEnvironment _hostingEnvironment;

        public NewsController(IWebHostEnvironment environment)
        {
            inewsRepo = new NewsRepo();
            _hostingEnvironment = environment;
        }

        [HttpGet, Route("api/GetAllNewsDetails")]
        public IActionResult GetNewsDetails()
        {
            var response = inewsRepo.GetAllNewsDetails();
            return Ok(response);
        }

        [HttpPost, Route("api/AddNewsDetail")]
        public IActionResult AddNewsDetail(NewsVM newsVM)
        {
            
            return Ok(inewsRepo.AddNewsDetail(newsVM));
        }
        [HttpPut, Route("api/UpdateNewsDetail")]
        public IActionResult UpdateNewsDetail(NewsVM newsVM)
        {
            
            return Ok(inewsRepo.UpdateNewsDetail(newsVM));
        }

        [HttpPut, Route("api/DeleteNewsDetail")]
        public IActionResult DeleteNewsDetail(NewsVM newsVM)
        {
            return Ok(inewsRepo.DeleteNewsDetail(newsVM));
        }
    }
}
