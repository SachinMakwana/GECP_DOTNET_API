using GECP_DOT_NET_API.Helper;
using GECP_DOT_NET_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GECP_DOT_NET_API.Repository
{
    public interface IFacultyRepo
    {
        public ServiceResponse<List<FacultyDetailsVM>> GetAllFacultyDetails();

        public ServiceResponse<bool> AddFacultyDetail(FacultyDetailsVM facultyDetailsVM);

        public ServiceResponse<bool> UpdateFacultyDetail(FacultyDetailsVM facultyDetailsVM);

        public ServiceResponse<bool> DeleteFacultyDetail(FacultyDetailsVM facultyDetailsVM);
    }
}
