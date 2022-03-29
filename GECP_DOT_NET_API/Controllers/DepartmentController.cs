using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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
    public class DepartmentController : ControllerBase
    {
        private IDepartmentRepo idepartmentRepo;
        private IWebHostEnvironment _hostingEnvironment;

        public DepartmentController(IWebHostEnvironment environment)
        {
            idepartmentRepo = new DepartmentRepo();
            _hostingEnvironment = environment;
        }

        [HttpGet, Route("api/GetAllDepartmentDetails")]
        public IActionResult GetDepartmentDetails()
        {
            var response = idepartmentRepo.GetAllDepartmentDetails();
            return Ok(response);
        }

        [HttpPost, Route("api/AddDepartmentDetail")]
        public IActionResult AddDepartmentDetail(IFormCollection collection)
        {
            var file = collection.Files.FirstOrDefault();
            var departmentVM = new DepartmentVM();
            TryUpdateModelAsync<DepartmentVM>(departmentVM);
            string filepath = string.Empty;
            string fileName = Guid.NewGuid().ToString() + "." + file.FileName.Split('.')[1];
            string dir;
            if (_hostingEnvironment.WebRootPath != null)
            {
                dir = Path.Combine(_hostingEnvironment.WebRootPath, "uploads/department/img");
            }
            else
            {
                dir = "uploads/department/img";

            }
            filepath = dir + "/" + fileName;
            var fileUploadTask = FileUpload.SaveFile(file, filepath, dir);
            fileUploadTask.Wait();
            bool status = fileUploadTask.Result;
            if (status)
            {
                departmentVM.Image = filepath;
                return Ok(idepartmentRepo.AddDepartmentDetail(departmentVM));
            }
            return Ok();
        }

        [HttpPut, Route("api/UpdateDepartmentDetail")]
        public IActionResult UpdateDepartmentDetail(IFormCollection collection)
        {
            var file = collection.Files.FirstOrDefault();
            var departmentVM = new DepartmentVM();
            TryUpdateModelAsync<DepartmentVM>(departmentVM);
            string filepath = string.Empty;
            string dir;
            if (_hostingEnvironment.WebRootPath != null)
            {
                dir = Path.Combine(_hostingEnvironment.WebRootPath, "uploads/department/img");
            }
            else
            {
                dir = "uploads/department/img";

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
                    departmentVM.Image = filepath;
                    return Ok(idepartmentRepo.UpdateDepartmentDetail(departmentVM));
                }
            }
            else
            {
                departmentVM.Image = string.Empty;
                return Ok(idepartmentRepo.UpdateDepartmentDetail(departmentVM));
            }
            return Ok();
        }

        [HttpPut, Route("api/DeleteDepartmentDetail")]
        public IActionResult DeleteDepartmentDetail(DepartmentVM departmentVM)
        {
            return Ok(idepartmentRepo.DeleteDepartmentDetail(departmentVM));
        }

    }
}
