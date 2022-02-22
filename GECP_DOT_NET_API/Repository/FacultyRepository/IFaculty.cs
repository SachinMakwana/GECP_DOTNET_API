using System.Collections.Generic;
using System.Threading.Tasks;
using GECP_DOT_NET_API.Database;
using GECP_DOT_NET_API.Models;

namespace GECP_DOT_NET_API.Repository.FacultyRepository
{
    public interface IFaculty
    {
        ServiceResponse<List<FacultyDetail>> GetAllFaculty();
        ServiceResponse<List<FacultyDetail>> AddFaculty(FacultyDetail newFaculty);
        ServiceResponse<FacultyDetail> UpdateFaculty(FacultyDetail updatedFaculty);
        ServiceResponse<List<FacultyDetail>> DeleteFaculty(int id);
    }
}
