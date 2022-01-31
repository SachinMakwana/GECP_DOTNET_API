using GECP_DOT_NET_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GECP_DOT_NET_API.Repository
{
    public interface IDemo
    {
        public FacultyDetailsVM GetFacultyDetail(int id);
        //public IList<FacultyDetailsVM> GetFacultyDetails();

        public bool AddFacultyDetail(FacultyDetailsVM facultyDetailsVM);
        public bool UpdateFacultyDetail(FacultyDetailsVM facultyDetailsVM);
        public bool DeleteFacultyDetail(FacultyDetailsVM facultyDetailsVM);
    }
}
