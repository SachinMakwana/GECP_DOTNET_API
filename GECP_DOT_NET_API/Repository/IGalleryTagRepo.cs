using GECP_DOT_NET_API.Helper;
using GECP_DOT_NET_API.Models;
using System;
using System.Collections.Generic;

namespace GECP_DOT_NET_API.Repository
{
    public interface IGalleryTagRepo
    {
        public ServiceResponse<List<GalleryTagVM>> GetAllGalleryTag();

        public ServiceResponse<bool> AddGalleryTagDetail(GalleryTagVM galleryTagVM);

        public ServiceResponse<bool> UpdateGalleryTagDetail(GalleryTagVM galleryTagVM);

        public ServiceResponse<bool> DeleteGalleryTagDetail(GalleryTagVM galleryTagVM);
    }
}
