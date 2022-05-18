﻿using GECP_DOT_NET_API.Database;
using GECP_DOT_NET_API.Helper;
using GECP_DOT_NET_API.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace GECP_DOT_NET_API.Repository
{
    public class GalleryTagRepo : IGalleryTagRepo
    {
        GECP_ADMINContext DBEntities = new GECP_ADMINContext();
        public ServiceResponse<List<GalleryTagVM>> GetAllGalleryTag()
        {
            ServiceResponse<List<GalleryTagVM>> serviceReponse = new ServiceResponse<List<GalleryTagVM>>();
            try
            {
                using (DBEntities = new GECP_ADMINContext())
                {
                    var gallerytagList = DBEntities.GalleryTags.Where(m => m.IsDeleted != true).Select(m => m.ToModel()).ToList();
                    serviceReponse.data = gallerytagList;
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

        public ServiceResponse<bool> AddGalleryTagDetail(GalleryTagVM galleryTagVM)
        {
            ServiceResponse<bool> serviceReponse = new ServiceResponse<bool>();
            try
            {
                using (DBEntities = new GECP_ADMINContext())
                {
                    GalleryTag dbObject = galleryTagVM.ToContext();
                    // to avoid conflict of autogenerated id
                    dbObject.Id = new int();
                    DBEntities.GalleryTags.Add(dbObject);
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

        public ServiceResponse<bool> UpdateGalleryTagDetail(GalleryTagVM galleryTagVM)
        {
            ServiceResponse<bool> serviceReponse = new ServiceResponse<bool>();
            try
            {

                GalleryTag dbObject = DBEntities.GalleryTags.Where(m => m.Id == galleryTagVM.Id).FirstOrDefault();
                if (dbObject == null)
                {
                    serviceReponse.data = false;
                    serviceReponse.status_code = "200";
                    serviceReponse.message = "Data does not exist";
                }
                else
                {

                    dbObject.Title = galleryTagVM.Title;
                    dbObject.Description = galleryTagVM.Description;
                    dbObject.UpdatedDate = galleryTagVM.UpdatedDate;

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

        public ServiceResponse<bool> DeleteGalleryTagDetail(GalleryTagVM galleryTagVM)
        {
            ServiceResponse<bool> serviceReponse = new ServiceResponse<bool>();
            try
            {
                GalleryTag dbObject = DBEntities.GalleryTags.Where(m => m.Id == galleryTagVM.Id && m.IsDeleted != true).FirstOrDefault();
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
