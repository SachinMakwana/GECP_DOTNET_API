﻿using GECP_DOT_NET_API.Database;
using GECP_DOT_NET_API.Helper;
using GECP_DOT_NET_API.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace GECP_DOT_NET_API.Repository
{
    public class CircularRepo : ICircular
    {
        GECP_ADMINContext DBEntities = new GECP_ADMINContext();


        public ServiceResponse<bool> AddCircularDetail(CircularVM circularVM)
        {
            ServiceResponse<bool> serviceReponse = new ServiceResponse<bool>();
            try
            {
                using (DBEntities = new GECP_ADMINContext())
                {
                    Circular dbObject = circularVM.ToContext();
                    // to avoid conflict of autogenerated id
                    dbObject.Id = new int();
                    DBEntities.Circulars.Add(dbObject);
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
            throw new System.NotImplementedException();
        }

        public ServiceResponse<bool> DeleteCircularDetail(CircularVM circularVM)
        {
            ServiceResponse<bool> serviceReponse = new ServiceResponse<bool>();
            try
            {
                Circular dbObject = DBEntities.Circulars.Where(m => m.Id == circularVM.Id && m.IsDeleted != true).FirstOrDefault();
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
                    serviceReponse.message = "Data deleted successfully";

                }
            }
            catch (Exception ex)
            {
                serviceReponse.data = false;
                serviceReponse.status_code = "000";
                serviceReponse.message = "Exception: " + ex.Message.ToString();
            }
            return serviceReponse;
            throw new System.NotImplementedException();
        }

        public ServiceResponse<List<CircularVM>> GetAllCircularDetails()
        {
            ServiceResponse<List<CircularVM>> serviceReponse = new ServiceResponse<List<CircularVM>>();
            try
            {
                using (DBEntities = new GECP_ADMINContext())
                {
                    var circularList = DBEntities.Circulars.Where(m => m.IsDeleted != true).Select(m => m.ToModel()).ToList();
                    serviceReponse.data = circularList;
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
            throw new System.NotImplementedException();

        }

        public ServiceResponse<bool> UpdateCircularDetail(CircularVM circularVM)
        {
            ServiceResponse<bool> serviceReponse = new ServiceResponse<bool>();
            try
            {

                Circular dbObject = DBEntities.Circulars.Where(m => m.Id == circularVM.Id).FirstOrDefault();
                if (dbObject == null)
                {
                    serviceReponse.data = false;
                    serviceReponse.status_code = "200";
                    serviceReponse.message = "Data does not exist";
                }
                else
                {

                    dbObject.Title = circularVM.Title;
                    dbObject.Description = circularVM.Description;
                    dbObject.UpdatedDate = circularVM.UpdatedDate;
                    dbObject.Date = circularVM.Date;

                    DBEntities.SaveChanges();

                    serviceReponse.data = true;
                    serviceReponse.status_code = "200";
                    serviceReponse.message = "Data Updated successfully";

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