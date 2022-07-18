using GECP_DOT_NET_API.Helper;
using GECP_DOT_NET_API.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GECP_DOT_NET_API.Repository
{
    public interface IDepartmentRepo
    {
        public ServiceResponse<List<DepartmentVM>> GetAllDepartmentDetails();

        public ServiceResponse<bool> AddDepartmentDetail(DepartmentVM departmentVM);

        public ServiceResponse<bool> UpdateDepartmentDetail(DepartmentVM departmentVM);

        public ServiceResponse<bool> DeleteDepartmentDetail(DepartmentVM departmentVM);
    }
}
