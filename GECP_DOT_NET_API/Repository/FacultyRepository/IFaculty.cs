using System.Collections.Generic;
using System.Threading.Tasks;
using GECP_DOT_NET_API.Database;
using GECP_DOT_NET_API.Models;

namespace GECP_DOT_NET_API.Repository.FacultyRepository
{
    public interface IFaculty
    {
        Task<ServiceResponse<List<FacultyDetail>>> GetAllFaculty();
        Task<ServiceResponse<List<FacultyDetail>>> AddFaculty(FacultyDetail newFaculty);
        Task<ServiceResponse<FacultyDetail>> UpdateFaculty(FacultyDetail updatedFaculty);
        Task<ServiceResponse<List<FacultyDetail>>> DeleteFaculty(int id);
    }
}
