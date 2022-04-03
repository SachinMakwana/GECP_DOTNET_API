using GECP_DOT_NET_API.Helper;
using GECP_DOT_NET_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GECP_DOT_NET_API.Repository
{
    public interface ICollegeRepo
    {
        public ServiceResponse<List<CollegeVM>> GetCollegeDetails();
        public ServiceResponse<bool> UpdateCollegeDetail(CollegeVM collegeVM);
    }
}
