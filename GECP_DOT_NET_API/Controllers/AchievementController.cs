using GECP_DOT_NET_API.Helper;
using GECP_DOT_NET_API.Models;
using GECP_DOT_NET_API.Repository;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using System.Linq;

namespace GECP_DOT_NET_API.Controllers
{
    [ApiController]
    public class AchievementController : ControllerBase
    {
        private IAchievementRepo iachievementRepo;
        private IWebHostEnvironment _hostingEnvironment;

        public AchievementController(IWebHostEnvironment environment)
        {
            iachievementRepo = new AchievementRepo();
            _hostingEnvironment = environment;
        }

        [HttpGet, Route("api/GetAllAchievementDetails")]
        public IActionResult GetAchievementDetails()
        {
            var response = iachievementRepo.GetAllAchievementDetails();
            return Ok(response);
        }

        [HttpPost, Route("api/AddAchievementDetail")]
        public IActionResult AddAchievementDetail(IFormCollection collection)
        {
            var file = collection.Files.FirstOrDefault();
            var achievementVM = new AchievementVM();
            TryUpdateModelAsync<AchievementVM>(achievementVM);

            string filepath = string.Empty;
            var split = file.FileName.Split('.');
            string fileName = Guid.NewGuid().ToString() + "." + split[split.Length - 1];
            string dir;
            if (_hostingEnvironment.WebRootPath != null)
            {
                dir = Path.Combine(_hostingEnvironment.WebRootPath, "uploads/achivements/img");
            }
            else
            {
                dir = "uploads/achivements/img";

            }
            filepath = dir + "/" + fileName;
            var fileUploadTask = FileUpload.SaveFile(file, filepath, dir);
            fileUploadTask.Wait();
            bool status = fileUploadTask.Result;
            if (status)
            {
                achievementVM.Image = filepath;
                return Ok(iachievementRepo.AddAchievementDetail(achievementVM));
            }
            return Ok();
        }

        [HttpPost, Route("api/UpdateAchievementDetail")]
        public IActionResult UpdateAchievementDetail(IFormCollection collection)
        {
            var file = collection.Files.FirstOrDefault();
            var achievementVM = new AchievementVM();
            TryUpdateModelAsync<AchievementVM>(achievementVM);
            string filepath = string.Empty;
            string dir;
            if (_hostingEnvironment.WebRootPath != null)
            {
                dir = Path.Combine(_hostingEnvironment.WebRootPath, "uploads/achivements/img");
            }
            else
            {
                dir = "uploads/achivements/img";

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
                    achievementVM.Image = filepath;
                    return Ok(iachievementRepo.UpdateAchievementDetail(achievementVM));
                }
            }
            else
            {
                achievementVM.Image = string.Empty;
                return Ok(iachievementRepo.UpdateAchievementDetail(achievementVM));
            }
            return Ok();
        }

        [HttpPost, Route("api/DeleteAchievementDetail")]
        public IActionResult DeleteAchievementDetail(AchievementVM achievementVM)
        {
            return Ok(iachievementRepo.DeleteAchievementDetail(achievementVM));
        }

    }
}