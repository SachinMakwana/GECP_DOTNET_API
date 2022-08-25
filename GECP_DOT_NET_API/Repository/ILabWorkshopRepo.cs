using GECP_DOT_NET_API.Helper;
using GECP_DOT_NET_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GECP_DOT_NET_API.Repository
{
    public interface ILabWorkshopRepo
    {
        public ServiceResponse<List<LabWorkshopVM>> GetAllLabWorkshopDetails();

        public ServiceResponse<bool> AddLabWorkshopDetail(LabWorkshopVM labworkshopVM);

        public ServiceResponse<bool> UpdateLabWorkshopDetail(LabWorkshopVM labworkshopVM);

        public ServiceResponse<bool> DeleteLabWorkshopDetail(LabWorkshopVM labworkshopVM);
    }
}
