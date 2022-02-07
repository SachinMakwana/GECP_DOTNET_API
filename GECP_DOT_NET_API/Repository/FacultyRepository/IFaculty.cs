using System.Collections.Generic;
using System.Threading.Tasks;
using GECP_DOT_NET_API.Dtos.Faculty;
using GECP_DOT_NET_API.Models;

namespace GECP_DOT_NET_API.Repository.FacultyRepository
{
    public interface IFaculty
    {
        Task<ServiceResponse<List<GetFacultyDto>>> GetAllFaculty();
        Task<ServiceResponse<List<GetFacultyDto>>> AddFaculty(AddFacultyDto newFaculty);
        Task<ServiceResponse<GetFacultyDto>> UpdateFaculty(UpdateFacultyDto updatedFaculty);
        Task<ServiceResponse<List<GetFacultyDto>>> DeleteFaculty(int id);
    }
}
