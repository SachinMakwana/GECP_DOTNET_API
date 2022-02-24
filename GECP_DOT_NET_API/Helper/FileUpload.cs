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

                if (file.Length > 0)
                {
                    
                    using (Stream fileStream = new FileStream(webRootPath, FileMode.Create))
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
