using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using GECP_DOT_NET_API.Helper;
using GECP_DOT_NET_API.Models;
using GECP_DOT_NET_API.Repository;
using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace GECP_DOT_NET_API.Controllers
{
    [ApiController]
    public class AttachmentController : ControllerBase
    {
        private IAttachmentRepo iattachmentRepo;
        private IWebHostEnvironment _hostingEnvironment;

        public AttachmentController(IWebHostEnvironment environment)
        {
            iattachmentRepo = new AttachmentRepo();
            _hostingEnvironment = environment;
        }

        [HttpGet, Route("api/GetAllAttachmentDetails")]
        public IActionResult GetAttachmentDetails()
        {
            var response = iattachmentRepo.GetAllAttachmentDetails();
            return Ok(response);
        }

        [HttpPost, Route("api/AddAttachmentDetail")]
        public IActionResult AddAttachmentDetail(IFormCollection collection)
        {
            var file = collection.Files.FirstOrDefault();
            var attachmentVM = new AttachmentVM();
            TryUpdateModelAsync<AttachmentVM>(attachmentVM);
            string filepath = string.Empty;
            string fileName = Guid.NewGuid().ToString() + "." + file.FileName.Split('.')[1];
            string dir;
            if (_hostingEnvironment.WebRootPath != null)
            {
                dir = Path.Combine(_hostingEnvironment.WebRootPath, "uploads/attachment");
            }
            else
            {
                dir = "uploads/attachment";

            }
            filepath = dir + "/" + fileName;
            var fileUploadTask = FileUpload.SaveFile(file, filepath, dir);
            fileUploadTask.Wait();
            bool status = fileUploadTask.Result;
            if (status)
            {
                attachmentVM.Attachment1 = filepath;
                return Ok(iattachmentRepo.AddAttachmentDetail(attachmentVM));
            }
            return Ok();
        }

        [HttpPost, Route("api/UpdateAttachmentDetail")]
        public IActionResult UpdateAttachmentDetail(IFormCollection collection)
        {
            var file = collection.Files.FirstOrDefault();
            var attachmentVM = new AttachmentVM();
            TryUpdateModelAsync<AttachmentVM>(attachmentVM);
            string filepath = string.Empty;
            string dir;
            if (_hostingEnvironment.WebRootPath != null)
            {
                dir = Path.Combine(_hostingEnvironment.WebRootPath, "uploads/attachment");
            }
            else
            {
                dir = "uploads/attachment";

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
                    attachmentVM.Attachment1 = filepath;
                    return Ok(iattachmentRepo.UpdateAttachmentDetail(attachmentVM));
                }
            }
            else
            {
                attachmentVM.Attachment1 = string.Empty;
                return Ok(iattachmentRepo.UpdateAttachmentDetail(attachmentVM));
            }
            return Ok();
        }

        [HttpPost, Route("api/DeleteAttachmentDetail")]
        public IActionResult DeleteAttachmentDetail(AttachmentVM attachmentVM)
        {
            return Ok(iattachmentRepo.DeleteAttachmentDetail(attachmentVM));
        }
    }
}
