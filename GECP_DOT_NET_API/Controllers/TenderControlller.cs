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
    public class TenderControlller : ControllerBase
    {
        private ITender itender;
        private IWebHostEnvironment _hostingEnvironment;


        public TenderControlller(IWebHostEnvironment environment)
        {
            itender = new TenderRepo();
            _hostingEnvironment = environment;
        }

        [HttpGet, Route("api/GetAllTenderDetails")]
        public IActionResult GetAllTenderDetails()
        {
            var response = itender.GetTenderDetails();
            return Ok(response);
        }
        [HttpPost, Route("api/AddTenderDetail")]
        public IActionResult AddTenderDetail()
        {
            var tenderVMM = new TenderVM();
            TryUpdateModelAsync<TenderVM>(tenderVMM);
            return Ok(itender.AddTenderDetail(tenderVMM));
        }

        [HttpPut, Route("api/UpdateTenderDetail")]
        public IActionResult UpdateTenderDetail(IFormCollection collection)
        {
            var tenderVM = new TenderVM();
            TryUpdateModelAsync<TenderVM>(tenderVM);
            return Ok(itender.UpdateTenderDetail(tenderVM));
        }

        [HttpPut, Route("api/DeleteTenderDetail")]
        public IActionResult DeleteTenderDetail(TenderVM tenderVM)
        {
            return Ok(itender.DeleteTenderDetail(tenderVM));
        }


    }
}
