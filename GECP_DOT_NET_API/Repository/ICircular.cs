using GECP_DOT_NET_API.Helper;
using GECP_DOT_NET_API.Models;
using System.Collections.Generic;

namespace GECP_DOT_NET_API.Repository
{
    public interface ICircular
    {
        public ServiceResponse<List<CircularVM>> GetAllCircularDetails();
        public ServiceResponse<bool> AddCircularDetail(CircularVM circularVM);
        public ServiceResponse<bool> UpdateCircularDetail(CircularVM circularVM);
        public ServiceResponse<bool> DeleteCircularDetail(CircularVM circularVM);
    }
}
