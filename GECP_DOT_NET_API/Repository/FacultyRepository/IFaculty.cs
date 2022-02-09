using System.Collections.Generic;
using System.Threading.Tasks;
using GECP_DOT_NET_API.Dtos.Faculty;
using GECP_DOT_NET_API.Models;

namespace GECP_DOT_NET_API.Repository.FacultyRepository
{
    public interface IFaculty
    {
        Task<ServiceResponse<List<Faculty>>> GetAllFaculty();
        Task<ServiceResponse<List<Faculty>>> AddFaculty(Faculty newFaculty);
        Task<ServiceResponse<Faculty>> UpdateFaculty(Faculty updatedFaculty);
        Task<ServiceResponse<List<Faculty>>> DeleteFaculty(int id);
    }
}
