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
    public class NewsRepo : INewsRepo
    { 
            GECP_ADMINContext DBEntities = new GECP_ADMINContext();
        public ServiceResponse<List<NewsVM>> GetAllNewsDetails()
        {
            ServiceResponse<List<NewsVM>> serviceReponse = new ServiceResponse<List<NewsVM>>();
            try
            {
                using (DBEntities = new GECP_ADMINContext())
                {
                    var newsList = DBEntities.News.Where(m => m.IsDeleted != true).Select(m => m.ToModel()).ToList();
                    serviceReponse.data = newsList;
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
    
        public ServiceResponse<bool> AddNewsDetail(NewsVM newsVM)
        {
            ServiceResponse<bool> serviceReponse = new ServiceResponse<bool>();
            try
            {
                using (DBEntities = new GECP_ADMINContext())
                {
                    News dbObject = newsVM.ToContext();
                    // to avoid conflict of autogenerated id
                    dbObject.Id = new int();
                    DBEntities.News.Add(dbObject);
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
        public ServiceResponse<bool> UpdateNewsDetail(NewsVM newsVM)
        {
            ServiceResponse<bool> serviceReponse = new ServiceResponse<bool>();
            try
            {

                News dbObject = DBEntities.News.Where(m => m.Id == newsVM.Id).FirstOrDefault();
                if (dbObject == null)
                {
                    serviceReponse.data = false;
                    serviceReponse.status_code = "200";
                    serviceReponse.message = "Data does not exist";
                }
                else
                {
                    dbObject.Title = newsVM.Title;
                    dbObject.Description = newsVM.Description;
                    dbObject.Date = newsVM.Date;
                    dbObject.UpdatedDate = newsVM.UpdatedDate;

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

        public ServiceResponse<bool> DeleteNewsDetail(NewsVM newsVM)
        {
            ServiceResponse<bool> serviceReponse = new ServiceResponse<bool>();
            try
            {
                News dbObject = DBEntities.News.Where(m => m.Id == newsVM.Id && m.IsDeleted != true).FirstOrDefault();
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