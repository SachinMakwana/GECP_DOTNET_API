using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace GECP_DOT_NET_API.Helper
{
    public static class FileUpload
    {
        public static bool SaveFile(IFormFile file)
        {
            return true;
        }

        //single file upload
        public static async Task<bool> SaveFile(IFormFile file, string webRootPath, string dir)
        {
            try
            {

                if (file.Length > 0)
                {
                    if (!Directory.Exists(dir))
                    {
                        Directory.CreateDirectory(dir);
                    }
                    using (Stream fileStream = new FileStream(webRootPath, FileMode.Create))
                    {
                        await file.CopyToAsync(fileStream);
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }


        // Multiple file uploads
        public static async Task<bool> SaveFiles(List<FileUploadVM> fileUploadVMs, string dir)
        {
            try
            {
                foreach(FileUploadVM fileUploadVM in fileUploadVMs)
                {
                    if (fileUploadVM.file.Length > 0)
                    {
                        if (!Directory.Exists(dir))
                        {
                            Directory.CreateDirectory(dir);
                        }
                        using (Stream fileStream = new FileStream(fileUploadVM.path, FileMode.Create))
                        {
                            await fileUploadVM.file.CopyToAsync(fileStream);
                        }
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }

    public class FileUploadVM
    {
        public IFormFile file { get; set; }

        public string path { get; set; }
    }
}
