using GECP_DOT_NET_API.Helper;
using GECP_DOT_NET_API.Models;
using System;
using System.Collections.Generic;

namespace GECP_DOT_NET_API.Repository
{
    public interface IDepartmentAmentyRepo
    {
        public ServiceResponse<List<DepartmentAmentyVM>> GetDepartmentAmentyDetails();
        public ServiceResponse<bool> AddDepartmentAmentyDetail(DepartmentAmentyVM departmentAmentyVM);
        public ServiceResponse<bool> UpdateDepartmentAmentyDetail(DepartmentAmentyVM departmentAmentyVM);
        public ServiceResponse<bool> DeleteDepartmentAmentyDetail(DepartmentAmentyVM departmentAmentyVM);
    }
}
