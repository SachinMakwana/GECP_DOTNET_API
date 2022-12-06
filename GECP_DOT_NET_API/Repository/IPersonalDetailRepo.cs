using GECP_DOT_NET_API.Helper;
using GECP_DOT_NET_API.Models;
using System.Collections.Generic;

namespace GECP_DOT_NET_API.Repository
{
    public interface IPersonalDetailRepo
    {
        public ServiceResponse<List<PersonalDetailVM>> GetAllPersonalDetails();
        public ServiceResponse<bool> AddPersonalDetail(PersonalDetailVM personalDetailVM);
        public ServiceResponse<bool> UpdatePersonalDetail(PersonalDetailVM personalDetailVM);
        public ServiceResponse<bool> DeletePersonalDetail(PersonalDetailVM personalDetailVM);
    }
}
