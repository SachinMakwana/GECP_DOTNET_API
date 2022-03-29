using GECP_DOT_NET_API.Database;
using GECP_DOT_NET_API.Helper;
using GECP_DOT_NET_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GECP_DOT_NET_API.Repository
{
    public class GrievanceRepo : IGrievanceRepo
    {
        private GECP_ADMINContext DBEntities;
        public ServiceResponse<IList<GrievanceWithStatusVM>> GetAllGrievances()
        {
            ServiceResponse<IList<GrievanceWithStatusVM>> serviceReponse = new ServiceResponse<IList<GrievanceWithStatusVM>>();
            try
            {
                using (DBEntities = new GECP_ADMINContext())
                {
                    serviceReponse.data = (from grievance in DBEntities.Grievances
                                           join status in DBEntities.GrievanceStatuses
                                           on grievance.Id equals status.GrievanceId
                                           orderby status.UpdatedDateInt descending
                                           select new GrievanceWithStatusVM
                                           {
                                               Id = grievance.Id,
                                               Name = grievance.Name,
                                               EmailId = grievance.EmailId,
                                               Mobile = grievance.Mobile,
                                               Subject = grievance.Subject,
                                               Status = status.Status,
                                               Description = grievance.Description,
                                               Attachments = grievance.Attachments,
                                               CreatedDate = grievance.CreatedDate,
                                               CreatedDateInt = grievance.CreatedDateInt,
                                               UpdatedDate = grievance.UpdatedDate,
                                               UpdatedDateInt = grievance.UpdatedDateInt
                                           }).ToList();
                }

            }
            catch (Exception ex)
            {
                serviceReponse.data = null;
                serviceReponse.status_code = "000";
                serviceReponse.message = "Exception: " + ex.Message.ToString();
            }
        }

        public ServiceResponse<bool> AddGrievance(GrievanceVM grievanceVM);

        public ServiceResponse<bool> AddGrievanceStatus(GrievanceStatusVM grievanceStatusVM);
    }
}
