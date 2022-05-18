using GECP_DOT_NET_API.Helper;
using GECP_DOT_NET_API.Models;
using System;
using System.Collections.Generic;

namespace GECP_DOT_NET_API.Repository
{
    public interface IDynamicPageRepo
    {
        public ServiceResponse<List<DynamicPageVM>> GetAllDynamicPageDetails();
        public ServiceResponse<bool> AddDynamicPageDetail(DynamicPageVM dynamicPageVM);
        public ServiceResponse<bool> UpdateDynamicPageDetail(DynamicPageVM dynamicPageVM);
        public ServiceResponse<bool> DeleteDynamicPageDetail(DynamicPageVM dynamicPageVM);
    }
}
