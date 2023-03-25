using GECP_DOT_NET_API.Helper;
using GECP_DOT_NET_API.Models;
using System.Collections.Generic;

namespace GECP_DOT_NET_API.Repository
{
    public interface IPlacementDetailRepo
    {
        public ServiceResponse<List<PlacementDetailsVM>> GetPlacementDetailsGraph();
        public ServiceResponse<bool> AddPlacementDetail(PlacementDetailsVM detailsVM);
        public ServiceResponse<bool> UpdatePlacementDetail(PlacementDetailsVM detailsVM);
        public ServiceResponse<bool> DeletePlacementDetailForGraph(PlacementDetailsVM detailsVM);
    }
}
