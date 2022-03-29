﻿using GECP_DOT_NET_API.Database;
using GECP_DOT_NET_API.Helper;
using GECP_DOT_NET_API.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace GECP_DOT_NET_API.Repository
{
    public class AttachmentRepo : IAttachmentRepo
    {
        GECP_ADMINContext DBEntities = new GECP_ADMINContext();
        public ServiceResponse<bool> AddAttachmentDetail(AttachmentVM attachmentVM)
        {
            ServiceResponse<bool> serviceReponse = new ServiceResponse<bool>();
            try
            {
                using (DBEntities = new GECP_ADMINContext())
                {
                    Attachment dbObject = attachmentVM.ToContext();
                    // to avoid conflict of autogenerated id
                    dbObject.Id = new int();
                    DBEntities.Attachments.Add(dbObject);
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

        public ServiceResponse<bool> DeleteAttachmentDetail(AttachmentVM attachmentVM)
        {
            ServiceResponse<bool> serviceReponse = new ServiceResponse<bool>();
            try
            {
                Attachment dbObject = DBEntities.Attachments.Where(m => m.Id == attachmentVM.Id && m.IsDeleted != true).FirstOrDefault();
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

        public ServiceResponse<List<AttachmentVM>> GetAllAttachmentDetails()
        {
            ServiceResponse<List<AttachmentVM>> serviceReponse = new ServiceResponse<List<AttachmentVM>>();
            try
            {
                using (DBEntities = new GECP_ADMINContext())
                {
                    var attachmentList = DBEntities.Attachments.Where(m => m.IsDeleted != true).Select(m => m.ToModel()).ToList();
                    serviceReponse.data = attachmentList;
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

        public ServiceResponse<bool> UpdateAttachmentDetail(AttachmentVM attachmentVM)
        {
            ServiceResponse<bool> serviceReponse = new ServiceResponse<bool>();
            try
            {

                Attachment dbObject = DBEntities.Attachments.Where(m => m.Id == attachmentVM.Id).FirstOrDefault();
                if (dbObject == null)
                {
                    serviceReponse.data = false;
                    serviceReponse.status_code = "200";
                    serviceReponse.message = "Data does not exist";
                }
                else
                {
                    if (!string.IsNullOrWhiteSpace(attachmentVM.Attachment1))
                    {
                        if (File.Exists(dbObject.Attachment1))
                        {
                            File.Delete(dbObject.Attachment1);
                        }
                        dbObject.Attachment1 = attachmentVM.Attachment1;
                    }
                    dbObject.Title = attachmentVM.Title;
                    dbObject.Description = attachmentVM.Description;
                    dbObject.Type = attachmentVM.Type;
                    dbObject.Name = attachmentVM.Name;
                    dbObject.PageId = attachmentVM.PageId;
                    dbObject.IsVisible = attachmentVM.IsVisible;

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
