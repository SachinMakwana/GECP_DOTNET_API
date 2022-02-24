﻿using GECP_DOT_NET_API.Database;
using GECP_DOT_NET_API.Helper;
using GECP_DOT_NET_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GECP_DOT_NET_API.Repository
{
    public class PlacementRepo : IPlacementRepo
    {
        GECP_ADMINContext DBEntities = new GECP_ADMINContext();
        public ServiceResponse<List<PlacementVM>> GetAllPlacementDetails()
        {
            ServiceResponse<List<PlacementVM>> serviceReponse = new ServiceResponse<List<PlacementVM>>();
            try
            {
                using (DBEntities = new GECP_ADMINContext())
                {
                    var placementList = DBEntities.Placements.Where(m => m.IsDeleted != true).Select(m => m.ToModel()).ToList();
                    serviceReponse.data = placementList;
                    serviceReponse.status_code = "200";
                    serviceReponse.message = "Data fetched successfully";
                }
            }
            catch (Exception ex)
            {
                serviceReponse.data = null;
                serviceReponse.status_code = "000";
                serviceReponse.message = "Exception: " + ex.Message.ToString();

            }
            return serviceReponse;

        }

        public ServiceResponse<bool> AddPlacementDetail(PlacementVM placementVM)
        {
            ServiceResponse<bool> serviceReponse = new ServiceResponse<bool>();
            try
            {
                using (DBEntities = new GECP_ADMINContext())
                {
                    Placement dbObject = placementVM.ToContext();
                    DBEntities.Placements.Add(dbObject);
                    DBEntities.SaveChanges();

                    serviceReponse.data = true;
                    serviceReponse.status_code = "200";
                    serviceReponse.message = "Data added successfully";
                }
            }
            catch (Exception ex)
            {
                serviceReponse.data = false;
                serviceReponse.status_code = "000";
                serviceReponse.message = "Exception: " + ex.Message.ToString();

            }
            return serviceReponse;
        }

        public ServiceResponse<bool> UpdatePlacementDetail(PlacementVM placementVM)
        {
            ServiceResponse<bool> serviceReponse = new ServiceResponse<bool>();
            try
            {

                Placement dbObject = DBEntities.Placements.Where(m => m.Id == placementVM.Id).FirstOrDefault();
                if (dbObject == null)
                {
                    serviceReponse.data = false;
                    serviceReponse.status_code = "200";
                    serviceReponse.message = "Data does not exist";
                }
                else
                {

                    dbObject.StudentName = placementVM.StudentName;
                    dbObject.StudentPic = placementVM.StudentPic;
                    dbObject.DeptId = placementVM.DeptId;
                    dbObject.AnnualPackage = placementVM.AnnualPackage;
                    dbObject.MonthlyPackage = placementVM.MonthlyPackage;
                    dbObject.CompanyId = placementVM.CompanyId;
                    dbObject.PlacementDate = placementVM.PlacementDate;
                    dbObject.UpdatedDate = placementVM.UpdatedDate;

                    DBEntities.SaveChanges();

                    serviceReponse.data = true;
                    serviceReponse.status_code = "200";
                    serviceReponse.message = "Data added successfully";

                }

            }
            catch (Exception ex)
            {
                serviceReponse.data = false;
                serviceReponse.status_code = "000";
                serviceReponse.message = "Exception: " + ex.Message.ToString();

            }
            return serviceReponse;
        }

        public ServiceResponse<bool> DeletePlacementDetail(PlacementVM placementVM)
        {
            ServiceResponse<bool> serviceReponse = new ServiceResponse<bool>();
            try
            {
                Placement dbObject = DBEntities.Placements.Where(m => m.Id == placementVM.Id && m.IsDeleted != true).FirstOrDefault();
                if (dbObject == null)
                {
                    serviceReponse.data = false;
                    serviceReponse.status_code = "200";
                    serviceReponse.message = "Data does not exist";
                }
                else
                {


                    dbObject.IsDeleted = true;

                    DBEntities.SaveChanges();

                    serviceReponse.data = true;
                    serviceReponse.status_code = "200";
                    serviceReponse.message = "Data added successfully";

                }
            }
            catch (Exception ex)
            {
                serviceReponse.data = false;
                serviceReponse.status_code = "000";
                serviceReponse.message = "Exception: " + ex.Message.ToString();

            }
            return serviceReponse;
        }
    }
}
