﻿using GECP_DOT_NET_API.Database;
using GECP_DOT_NET_API.Helper;
using GECP_DOT_NET_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GECP_DOT_NET_API.Repository
{
    public class DynamicPageRepo : IDynamicPageRepo
    {
        GECP_ADMINContext DBEntities = new GECP_ADMINContext();

        public ServiceResponse<List<DynamicPageVM>> GetAllDynamicPageDetails()
        {
            ServiceResponse<List<DynamicPageVM>> serviceReponse = new ServiceResponse<List<DynamicPageVM>>();
            try
            {
                using (DBEntities = new GECP_ADMINContext())
                {
                    var dynamicPageList = DBEntities.DynamicPages.Where(m => m.IsDeleted != true).Select(m => m.ToModel()).ToList();
                    serviceReponse.data = dynamicPageList;
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
        public ServiceResponse<bool> AddDynamicPageDetail(DynamicPageVM dynamicPageVM)
        {
            ServiceResponse<bool> serviceReponse = new ServiceResponse<bool>();
            try
            {
                using (DBEntities = new GECP_ADMINContext())
                {
                    DynamicPage dbObject = dynamicPageVM.ToContext();
                    // to avoid conflict of autogenerated id
                    dbObject.Id = new int();
                    DBEntities.DynamicPages.Add(dbObject);
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
        public ServiceResponse<bool> UpdateDynamicPageDetail(DynamicPageVM dynamicPageVM)
        {
            ServiceResponse<bool> serviceReponse = new ServiceResponse<bool>();
            try
            {

                DynamicPage dbObject = DBEntities.DynamicPages.Where(m => m.Id == dynamicPageVM.Id).FirstOrDefault();
                if (dbObject == null)
                {
                    serviceReponse.data = false;
                    serviceReponse.status_code = "200";
                    serviceReponse.message = "Data does not exist";
                }
                else
                {
                    dbObject.Description = dynamicPageVM.Description;
                    dbObject.Title = dynamicPageVM.Title;
                    dbObject.Name = dynamicPageVM.Name;
                    dbObject.UpdatedDate = dynamicPageVM.UpdatedDate;

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

        public ServiceResponse<bool> DeleteDynamicPageDetail(DynamicPageVM dynamicPageVM)
        {
            ServiceResponse<bool> serviceReponse = new ServiceResponse<bool>();
            try
            {
                DynamicPage dbObject = DBEntities.DynamicPages.Where(m => m.Id == dynamicPageVM.Id && m.IsDeleted != true).FirstOrDefault();
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