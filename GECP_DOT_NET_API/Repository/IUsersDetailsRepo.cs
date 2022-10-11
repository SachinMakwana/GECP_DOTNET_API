using GECP_DOT_NET_API.Helper;
using GECP_DOT_NET_API.Models;
using System.Collections.Generic;

namespace GECP_DOT_NET_API.Repository
{
    public interface IUsersDetailsRepo
    {
        public ServiceResponse<List<UserDetailVM>> GetUsersDetails();
        public ServiceResponse<bool> AddUsersDetail(UserDetailVM userVM);
        public ServiceResponse<bool> UpdateUsersDetail(UserDetailVM userVM);
        public ServiceResponse<bool> DeleteUsersDetail(UserDetailVM userVM);
    }
}
