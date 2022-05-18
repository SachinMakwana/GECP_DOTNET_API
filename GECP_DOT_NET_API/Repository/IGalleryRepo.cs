using GECP_DOT_NET_API.Helper;
using GECP_DOT_NET_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GECP_DOT_NET_API.Repository
{
    public interface IGalleryRepo
    {
        public ServiceResponse<List<GalleryVM>> GetAllGalleryDetails();
        public ServiceResponse<bool> AddGalleryDetail(GalleryVM galleryVM);
        public ServiceResponse<bool> UpdateGalleryDetail(GalleryVM galleryVM);
        public ServiceResponse<bool> DeleteGalleryDetail(GalleryVM galleryVM);
    }
}
