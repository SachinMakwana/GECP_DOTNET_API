using GECP_DOT_NET_API.Helper;
using GECP_DOT_NET_API.Models;
using System;
using System.Collections.Generic;

namespace GECP_DOT_NET_API.Repository
{
    public interface ICampusRepo
    {
        public ServiceResponse<List<CampusVM>> GetAllCampusDetails();

        public ServiceResponse<bool> AddCampusDetails(CampusVM campusVM);

        public ServiceResponse<bool> UpdateCampusDetail(CampusVM campusVM);

        public ServiceResponse<bool> DeleteCampusDetail(CampusVM campusVM);
    }
}
