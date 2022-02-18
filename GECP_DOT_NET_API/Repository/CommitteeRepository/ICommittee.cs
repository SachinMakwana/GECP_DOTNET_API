using GECP_DOT_NET_API.Database;
using GECP_DOT_NET_API.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GECP_DOT_NET_API.Repository.CommitteeRepositoty
{
    public interface ICommittee
    {
        Task<ServiceResponse<List<Committees>>> GetAllCommittee();
        Task<ServiceResponse<List<Committees>>> AddCommittee(Committee committeeDetail);
        Task<ServiceResponse<List<Committees>>> EditCommittee(Committee committeeDetail);
        Task<ServiceResponse<List<Committees>>> DeleteCommittee(int id);
    }
}
