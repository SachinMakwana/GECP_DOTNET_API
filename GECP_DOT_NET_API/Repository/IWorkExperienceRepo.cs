using GECP_DOT_NET_API.Helper;
using GECP_DOT_NET_API.Models;
using System;
using System.Collections.Generic;

namespace GECP_DOT_NET_API.Repository
{
    public interface IWorkExperienceRepo
    {
        public ServiceResponse<List<WorkExperienceVM>> GetWorkExperienceDetails();

        public ServiceResponse<bool> AddWorkExperienceDetail(WorkExperienceVM workExperienceVM);

        public ServiceResponse<bool> UpdateWorkExperienceDetail(WorkExperienceVM workExperienceVM);

        public ServiceResponse<bool> DeleteWorkExperienceDetail(WorkExperienceVM workExperienceVM);
    }
}
