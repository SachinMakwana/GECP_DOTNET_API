using GECP_DOT_NET_API.Helper;
using GECP_DOT_NET_API.Models;
using System.Collections.Generic;

namespace GECP_DOT_NET_API.Repository
{
    public interface ICollegeRepo
    {
        public ServiceResponse<List<CollegeVM>> GetCollegeDetail();

        public ServiceResponse<bool> AddCollegeDetail(CollegeVM collegeVM);

        public ServiceResponse<bool> UpdateCollegeDetail(CollegeVM collegeVM);
    }
}
