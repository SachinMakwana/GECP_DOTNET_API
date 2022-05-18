using GECP_DOT_NET_API.Helper;
using GECP_DOT_NET_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GECP_DOT_NET_API.Repository
{
    public interface IEducationalDetailRepo
    {
        public ServiceResponse<List<EducationalDetailsVM>> GetAllEducationalDetails();

        public ServiceResponse<bool> AddEducationDetail(EducationalDetailsVM educationalDetailsVM);

        public ServiceResponse<bool> UpdateEducationDetail(EducationalDetailsVM educationalDetailsVM);

        public ServiceResponse<bool> DeleteEducationDetail(EducationalDetailsVM educationalDetailsVM);
    }
}
