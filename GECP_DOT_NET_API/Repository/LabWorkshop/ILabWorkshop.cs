using GECP_DOT_NET_API.Database;
using GECP_DOT_NET_API.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GECP_DOT_NET_API.Repository.LabWorkshop
{
    public interface ILabWorkshop
    {
        Task<ServiceResponse<List<LabWorkshopDetail>>> GetAllLabWorkshop();
    }
}