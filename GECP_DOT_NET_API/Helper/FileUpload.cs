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

        public static async Task<bool> SaveFile(IFormFile file, string webRootPath)
        {
            try
            {
                string uploads = Path.Combine(webRootPath, "uploads");

                if (file.Length > 0)
                {
                    string filePath = Path.Combine(uploads, file.FileName);
                    using (Stream fileStream = new FileStream(filePath, FileMode.Create))
                    {
                        await file.CopyToAsync(fileStream);
                    }
                }

                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }
    }
}
