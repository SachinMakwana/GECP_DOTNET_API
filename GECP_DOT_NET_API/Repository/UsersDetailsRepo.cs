﻿using GECP_DOT_NET_API.Database;
using GECP_DOT_NET_API.Helper;
using GECP_DOT_NET_API.Models;
using System.Collections.Generic;
using System;
using System.Linq;

namespace GECP_DOT_NET_API.Repository
{
    public class UsersDetailsRepo : IUsersDetailsRepo
    {
        GECPATAN_PRODContext DBEntities = new GECPATAN_PRODContext();
        public ServiceResponse<List<UserDetailVM>> GetUsersDetails()
        {
            ServiceResponse<List<UserDetailVM>> serviceReponse = new ServiceResponse<List<UserDetailVM>>();
            try
            {
                using (DBEntities = new GECPATAN_PRODContext())
                {
                    var usersList = DBEntities.UsersDetails.Where(m => m.IsDeleted != true).Select(m => m.ToModel()).ToList();
                    serviceReponse.data = usersList;
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

        public ServiceResponse<bool> AddUsersDetail(UserDetailVM UserDetailVM)
        {
            ServiceResponse<bool> serviceReponse = new ServiceResponse<bool>();
            try
            {
                using (DBEntities = new GECPATAN_PRODContext())
                {
                    UsersDetail dbObject = UserDetailVM.ToContext();
                    // to avoid conflict of autogenerated id
                    dbObject.Id = new int();
                    DBEntities.UsersDetails.Add(dbObject);
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

        public ServiceResponse<bool> UpdateUsersDetail(UserDetailVM userVM)
        {
            ServiceResponse<bool> serviceReponse = new ServiceResponse<bool>();
            serviceReponse.data = true;
            serviceReponse.status_code = "200";
            serviceReponse.message = "Data added successfully";
            return serviceReponse;
        }
        public ServiceResponse<bool> RestPasswordUsersDetail(UserDetailVM UserDetailVM)
        {
            ServiceResponse<bool> serviceReponse = new ServiceResponse<bool>();
            try
            {

                UsersDetail dbObject = DBEntities.UsersDetails.Where(m => m.Id == UserDetailVM.Id).FirstOrDefault();
                if (dbObject == null)
                {
                    serviceReponse.data = false;
                    serviceReponse.status_code = "200";
                    serviceReponse.message = "Data does not exist";
                }
                else
                {
                    dbObject.Username = UserDetailVM.Username;
                    dbObject.Password = UserDetailVM.Password;
                    dbObject.Role = UserDetailVM.Role;
                    dbObject.SaltKey = UserDetailVM.SaltKey;
                    dbObject.UpdatedDate = UserDetailVM.UpdatedDate;

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

        public ServiceResponse<bool> DeleteUsersDetail(UserDetailVM UserDetailVM)
        {
            ServiceResponse<bool> serviceReponse = new ServiceResponse<bool>();
            try
            {
                UsersDetail dbObject = DBEntities.UsersDetails.Where(m => m.Id == UserDetailVM.Id && m.IsDeleted != true).FirstOrDefault();
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
