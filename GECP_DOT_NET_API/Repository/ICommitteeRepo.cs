using GECP_DOT_NET_API.Helper;
using GECP_DOT_NET_API.Models;
using System;
using System.Collections.Generic;

namespace GECP_DOT_NET_API.Repository
{
    public interface ICommitteeRepo
    {
        public ServiceResponse<List<CommitteeVM>> GetAllCommitteeDetails();
        public ServiceResponse<List<CommitteeVM>> GetCommitteeDetail(CommitteeVM committeeVM);
        public ServiceResponse<bool> AddCommitteeDetail(CommitteeVM committeeVM);
        public ServiceResponse<bool> UpdateCommitteeDetail(CommitteeVM committeeVM);
        public ServiceResponse<bool> DeleteCommitteeDetail(CommitteeVM committeeVM);
    }
}
