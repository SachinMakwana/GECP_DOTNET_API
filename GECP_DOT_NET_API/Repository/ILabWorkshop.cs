using GECP_DOT_NET_API.Database;
using GECP_DOT_NET_API.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GECP_DOT_NET_API.Repository.LabWorkshop
{
    public interface ILabWorkshop
    {
        Task<ServiceResponse<List<LabWorkshopDetail>>> GetAllLabWorkshop();
        Task<ServiceResponse<List<LabWorkshopDetail>>> AddLabWorkshop(LabWorkshopDetail labWorkshopDetail);
        Task<ServiceResponse<List<LabWorkshopDetail>>> EditLabWorkshop(LabWorkshopDetail labWorkshopDetail);
        Task<ServiceResponse<List<LabWorkshopDetail>>> DeleteLabWorkshop(int id);
    }
}