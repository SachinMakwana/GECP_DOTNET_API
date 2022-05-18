using GECP_DOT_NET_API.Helper;
using GECP_DOT_NET_API.Models;
using System;
using System.Collections.Generic;

namespace GECP_DOT_NET_API.Repository
{
    public interface ICommitteeMemberRepo
    {
        public ServiceResponse<List<CommitteeMembersVM>> GetAllCommitteeMembersDetails();
        public ServiceResponse<bool> AddCommitteeMemberDetail(CommitteeMembersVM committeeMemberVM);
        public ServiceResponse<bool> DeleteCommitteeMemberDetail(CommitteeMembersVM committerMemberVM);
        public ServiceResponse<bool> UpdateCommitteeMemberDetail(CommitteeMembersVM committeeMembersVM);
    }
}
