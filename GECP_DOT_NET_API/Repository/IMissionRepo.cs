using GECP_DOT_NET_API.Helper;
using GECP_DOT_NET_API.Models;
using System;
using System.Collections.Generic;


namespace GECP_DOT_NET_API.Repository
{
    public interface IMissionRepo
    {
        public ServiceResponse<List<MissionVM>> GetAllMissionDetails();
        public ServiceResponse<bool> AddMissionDetail(MissionVM missionVM);
        public ServiceResponse<bool> UpdateMissionDetail(MissionVM missionVM);
        public ServiceResponse<bool> DeleteMissionDetail(MissionVM missionVM);
    }
}
