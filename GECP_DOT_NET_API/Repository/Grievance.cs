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
            ServiceResponse<IList<GrievanceWithStatusVM>> serviceRseponse = new ServiceResponse<IList<GrievanceWithStatusVM>>();
            try
            {
                using (DBEntities = new GECP_ADMINContext())
                {
                    serviceRseponse.data = (from g in DBEntities.Grievances
                                            join gs in DBEntities.GrievanceStatuses on new { GrievanceId = g.Id } equals new { GrievanceId = gs.GrievanceId }
                                            where
                                              gs.CreatedDateInt ==
                                                (from gt in DBEntities.GrievanceStatuses
                                                 where gt.GrievanceId == g.Id
                                                 select new
                                                 {
                                                     gt.CreatedDateInt
                                                 }).Max(p => p.CreatedDateInt)
                                            select new GrievanceWithStatusVM
                                            {
                                                Id = g.Id,
                                                Name = g.Name,
                                                EmailId = g.EmailId,
                                                Mobile = g.Mobile,
                                                Subject = g.Subject,
                                                Description = g.Description,
                                                Attachments = g.Attachments,
                                                CreatedDate = (DateTime)g.CreatedDate,
                                                CreatedDateInt = g.CreatedDateInt,
                                                UpdatedDate = g.UpdatedDate,
                                                UpdatedDateInt = g.UpdatedDateInt,
                                                Status = gs.Status,
                                                StatusUpdated = gs.CreatedDate,
                                                StatusUpdatedInt = gs.CreatedDateInt,
                                                StatusDescription = gs.Description
                                            }).ToList();
                    //serviceRseponse.data = (from grievance in DBEntities.Grievances
                    //                       join status in DBEntities.GrievanceStatuses
                    //                       on grievance.Id equals status.GrievanceId
                    //                       orderby status.UpdatedDateInt descending
                    //                       select new GrievanceWithStatusVM
                    //                       {
                    //                           Id = grievance.Id,
                    //                           Name = grievance.Name,
                    //                           EmailId = grievance.EmailId,
                    //                           Mobile = grievance.Mobile,
                    //                           Subject = grievance.Subject,
                    //                           Status = status.Status,
                    //                           Description = grievance.Description,
                    //                           Attachments = grievance.Attachments,
                    //                           CreatedDate = (DateTime)grievance.CreatedDate,
                    //                           CreatedDateInt = grievance.CreatedDateInt,
                    //                           UpdatedDate = grievance.UpdatedDate,
                    //                           UpdatedDateInt = grievance.UpdatedDateInt
                    //                       }).ToList();
                    serviceRseponse.status_code = "200";
                    serviceRseponse.message = "Data fetched successfully";
                }

            }
            catch (Exception ex)
            {
                serviceRseponse.data = null;
                serviceRseponse.status_code = "000";
                serviceRseponse.message = "Exception: " + ex.Message.ToString();
            }
            return serviceRseponse;
        }

        public ServiceResponse<bool> AddGrievance(GrievanceVM grievanceVM)
        {
            ServiceResponse<bool> serviceResponse = new ServiceResponse<bool>();
            try
            {
                using(DBEntities = new GECP_ADMINContext())
                {
                    var dbObject = grievanceVM.ToContext();
                    DBEntities.Grievances.Add(dbObject);
                    DBEntities.SaveChanges();

                    GrievanceStatus status = new GrievanceStatus();
                    status.GrievanceId = dbObject.Id;
                    status.Description = "Work in progress";
                    status.Status = 0;
                    status.CreatedDate = dbObject.CreatedDate;
                    status.UpdatedDate = dbObject.UpdatedDate;
                    DBEntities.GrievanceStatuses.Add(status);
                    DBEntities.SaveChanges();
                }
                serviceResponse.data = true;
                serviceResponse.status_code = "200";
                serviceResponse.message = "Grievance added successfully";
            }
            catch (Exception ex)
            {
                serviceResponse.data = false;
                serviceResponse.status_code = "000";
                serviceResponse.message = "Exception: " + ex.Message.ToString();
            }
            return serviceResponse;
        }

        public ServiceResponse<bool> AddGrievanceStatus(GrievanceStatusVM grievanceStatusVM)
        {
            ServiceResponse<bool> serviceResponse = new ServiceResponse<bool>();
            try
            {
                using(DBEntities = new GECP_ADMINContext())
                {
                    var dbObject = grievanceStatusVM.ToContext();
                    DBEntities.GrievanceStatuses.Add(dbObject);
                    DBEntities.SaveChanges();
                }
                serviceResponse.data = true;
                serviceResponse.status_code = "200";
                serviceResponse.message = "Status added successfully";
            }
            catch (Exception ex)
            {
                serviceResponse.data = false;
                serviceResponse.status_code = "000";
                serviceResponse.message = "Exception: " + ex.Message.ToString();
            }
            return serviceResponse;
        }
    }
}
