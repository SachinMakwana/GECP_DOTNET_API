using GECP_DOT_NET_API.Helper;
using GECP_DOT_NET_API.Models;
using System;
using System.Collections.Generic;

namespace GECP_DOT_NET_API.Repository
{
    public interface IMediaLinkRepo
    {
        public ServiceResponse<List<MediaLinkVM>> GetAllMediaLinkDetails();
        public ServiceResponse<bool> AddMediaLinkDetail(MediaLinkVM mediaLinkVM);
        public ServiceResponse<bool> DeleteMediaLinkDetail(MediaLinkVM mediaLinkVM);
    }
}
