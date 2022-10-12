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
    public class CompanyDetailsController : ControllerBase
    {
        private ICompanyRepo icompanyRepo;
        private IWebHostEnvironment _hostingEnvironment;

        public CompanyDetailsController(IWebHostEnvironment environment)
        {
            icompanyRepo = new CompanyRepo();
            _hostingEnvironment = environment;
        }

        [HttpGet, Route("api/GetAllCompanyDetails")]
        public IActionResult GetCompanyDetails()
        {
            var response = icompanyRepo.GetAllCompanyDetails();
            return Ok(response);
        }

        [HttpPost, Route("api/AddCompanyDetail")]
        public IActionResult AddCompanyDetail(IFormCollection collection)
        {
            var file = collection.Files.FirstOrDefault();
            var companyVM = new CompanyVM();
            TryUpdateModelAsync<CompanyVM>(companyVM);
            string filepath = string.Empty;
            var split = file.FileName.Split('.');
            string fileName = Guid.NewGuid().ToString() + "." + split[split.Length - 1];
            string dir;
            if (_hostingEnvironment.WebRootPath != null)
            {
                dir = Path.Combine(_hostingEnvironment.WebRootPath, "uploads/company/img");
            }
            else
            {
                dir = "uploads/company/img";

            }
            filepath = dir + "/" + fileName;
            var fileUploadTask = FileUpload.SaveFile(file, filepath, dir);
            fileUploadTask.Wait();
            bool status = fileUploadTask.Result;
            if (status)
            {
                companyVM.Image = filepath;
                companyVM.Logo = filepath;
                return Ok(icompanyRepo.AddCompanyDetail(companyVM));
            }
            return Ok();
        }

        [HttpPost, Route("api/UpdateCompanyDetail")]
        public IActionResult UpdateCompanyDetail(IFormCollection collection)
        {
            var file = collection.Files.FirstOrDefault();
            var companyVM = new CompanyVM();
            TryUpdateModelAsync<CompanyVM>(companyVM);
            string filepath = string.Empty;
            string dir;
            if (_hostingEnvironment.WebRootPath != null)
            {
                dir = Path.Combine(_hostingEnvironment.WebRootPath, "uploads/company/img");
            }
            else
            {
                dir = "uploads/company/img";

            }
            if (file != null && file.Length > 0)
            {
                var split = file.FileName.Split('.');
                string fileName = Guid.NewGuid().ToString() + "." + split[split.Length - 1];
                filepath = dir + "/" + fileName;
                var fileUploadTask = FileUpload.SaveFile(file, filepath, dir);
                fileUploadTask.Wait();
                bool status = fileUploadTask.Result;
                if (status)
                {
                    companyVM.Image = filepath;
                    return Ok(icompanyRepo.UpdateCompanyDetail(companyVM));
                }
            }
            else
            {
                companyVM.Image = string.Empty;
                return Ok(icompanyRepo.UpdateCompanyDetail(companyVM));
            }
            return Ok();
        }

        [HttpPost, Route("api/DeleteCompanyDetail")]
        public IActionResult DeleteCompanyDetail(CompanyVM companyVM)
        {
            return Ok(icompanyRepo.DeleteCompanyDetail(companyVM));
        }

    }
}
