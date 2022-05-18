using GECP_DOT_NET_API.Helper;
using GECP_DOT_NET_API.Models;
using System;
using System.Collections.Generic;

namespace GECP_DOT_NET_API.Repository
{
    public interface IDesignationRepo
    {
        public ServiceResponse<List<DesignationVM>> GetAllDesignationDetails();
        public ServiceResponse<bool> AddDesignationDetail(DesignationVM designationVM);
        public ServiceResponse<bool> UpdateDesignationDetail(DesignationVM designationVM);
        public ServiceResponse<bool> DeleteDesignationDetail(DesignationVM designationVM);
    }
}
