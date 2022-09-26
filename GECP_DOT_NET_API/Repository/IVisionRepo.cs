using GECP_DOT_NET_API.Helper;
using GECP_DOT_NET_API.Models;
using System;
using System.Collections.Generic;

namespace GECP_DOT_NET_API.Repository
{
    public interface IVisionRepo
    {
        public ServiceResponse<List<VisionVM>> GetAllVisionDetails();
        public ServiceResponse<List<VisionVM>> GetVissionDetail(VisionVM visionVM);
        public ServiceResponse<bool> AddVisionDetail(VisionVM visionVM);
        public ServiceResponse<bool> UpdateVisionDetail(VisionVM visionVM);
        public ServiceResponse<bool> DeleteVisionDetail(VisionVM visionVM);

    }
}
