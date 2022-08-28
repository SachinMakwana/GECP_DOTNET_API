using GECP_DOT_NET_API.Database;
using GECP_DOT_NET_API.Helper;
using GECP_DOT_NET_API.Models;
using System;
using System.Collections.Generic;

namespace GECP_DOT_NET_API.Repository
{
    public interface IAchievementRepo
    {
        public ServiceResponse<List<AchievementVM>> GetAllAchievementDetails();

        public ServiceResponse<bool> AddAchievementDetail(AchievementVM achievementVM);

        public ServiceResponse<bool> UpdateAchievementDetail(AchievementVM achievementVM);

        public ServiceResponse<bool> DeleteAchievementDetail(AchievementVM achievementVM);
    }
}