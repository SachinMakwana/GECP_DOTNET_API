using System.Collections.Generic;
using System.Threading.Tasks;
using GECP_DOT_NET_API.Database;
using GECP_DOT_NET_API.Models;

namespace GECP_DOT_NET_API.Repository.FacultyRepository
{
    public interface IFaculty
    {
        ServiceResponse<List<FacultyDetailVM>> GetAllFaculty();
        ServiceResponse<List<FacultyDetailVM>> AddFaculty(FacultyDetailVM newFaculty);
        ServiceResponse<FacultyDetailVM> UpdateFaculty(FacultyDetailVM updatedFaculty);
        ServiceResponse<List<FacultyDetailVM>> DeleteFaculty(int id);
    }
}
