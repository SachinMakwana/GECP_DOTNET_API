using System.Collections.Generic;
using System.Threading.Tasks;
using GECP_DOT_NET_API.Dtos.Faculty;
using GECP_DOT_NET_API.Models;


namespace GECP_DOT_NET_API.Repository.CollegeRepository
{
 public  interface ICollege
    {
        Task<ServiceResponse<List<CollegeVM>>> GetAllCollege();
        Task<ServiceResponse<CollegeVM>> UpdateCollege(CollegeVM updatedCollegeVM);
    }
}
