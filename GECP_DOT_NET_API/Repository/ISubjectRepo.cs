using GECP_DOT_NET_API.Helper;
using GECP_DOT_NET_API.Models;
using System;
using System.Collections.Generic;

namespace GECP_DOT_NET_API.Repository
{
    public interface ISubjectRepo
    {
        public ServiceResponse<List<SubjectVM>> GetSubjectDetails();

        public ServiceResponse<bool> AddSubjectDetails(SubjectVM subjectVM);

        public ServiceResponse<bool> UpdateSubjectDetails(SubjectVM subjectVM);

        public ServiceResponse<bool> DeleteSubjectDetails(SubjectVM subjectVM);
    }
}
