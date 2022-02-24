using GECP_DOT_NET_API.Helper;
using GECP_DOT_NET_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GECP_DOT_NET_API.Repository
{
    public interface IPlacementRepo
    {
        public ServiceResponse<List<PlacementVM>> GetAllPlacementDetails();

        public ServiceResponse<bool> AddPlacementDetail(PlacementVM placementVM);

        public ServiceResponse<bool> UpdatePlacementDetail(PlacementVM placementVM);

        public ServiceResponse<bool> DeletePlacementDetail(PlacementVM placementVM);
    }
}
