﻿using GECP_DOT_NET_API.Database;
using GECP_DOT_NET_API.Helper;
using GECP_DOT_NET_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GECP_DOT_NET_API.Repository
{
    public class PersonalDetailRepo : IPersonalDetailRepo
    {
        GECPATAN_PRODContext DBEntities = new GECPATAN_PRODContext();

        public ServiceResponse<bool> AddPersonalDetail(PersonalDetailVM personalDetailVM)
        {
            ServiceResponse<bool> serviceReponse = new ServiceResponse<bool>();
            try
            {
                using (DBEntities = new GECPATAN_PRODContext())
                {
                    PersonalDetail dbObject = personalDetailVM.ToContext();
                    // to avoid conflict of autogenerated id
                    dbObject.Id = new int();
                    DBEntities.PersonalDetails.Add(dbObject);
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

        public ServiceResponse<bool> DeletePersonalDetail(PersonalDetailVM personalDetailVM)
        {
            ServiceResponse<bool> serviceReponse = new ServiceResponse<bool>();
            try
            {
                PersonalDetail dbObject = DBEntities.PersonalDetails.Where(m => m.Id == personalDetailVM.Id && m.IsDeleted != true).FirstOrDefault();
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
                    serviceReponse.message = "Data Deleted successfully";

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

        public ServiceResponse<List<PersonalDetailVM>> GetAllPersonalDetails()
        {
            ServiceResponse<List<PersonalDetailVM>> serviceReponse = new ServiceResponse<List<PersonalDetailVM>>();
            try
            {
                using (DBEntities = new GECPATAN_PRODContext())
                {
                    var detailList = DBEntities.PersonalDetails.Where(m => m.IsDeleted != true).Select(m => m.ToModel()).ToList();
                    serviceReponse.data = detailList;
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

        public ServiceResponse<bool> UpdatePersonalDetail(PersonalDetailVM personalDetailVM)
        {
            ServiceResponse<bool> serviceReponse = new ServiceResponse<bool>();
            try
            {

                PersonalDetail dbObject = DBEntities.PersonalDetails.Where(m => m.Id == personalDetailVM.Id).FirstOrDefault();
                if (dbObject == null)
                {
                    serviceReponse.data = false;
                    serviceReponse.status_code = "200";
                    serviceReponse.message = "Data does not exist";
                }
                else
                {
                    dbObject.FacultyId = personalDetailVM.FacultyId;
                    dbObject.FirstName = personalDetailVM.FirstName;
                    dbObject.LastName = personalDetailVM.LastName;
                    dbObject.MiddleName = personalDetailVM.MiddleName;
                    dbObject.Dob = personalDetailVM.Dob;
                    dbObject.MaritalStatus = personalDetailVM.MaritalStatus;
                    dbObject.CurrentAddress = personalDetailVM.CurrentAddress;
                    dbObject.WhatsAppNumber = personalDetailVM.WhatsAppNumber;
                    dbObject.EmergencyContactNumber = personalDetailVM.EmergencyContactNumber;
                    dbObject.Email = personalDetailVM.Email;
                    dbObject.HighestQualification = personalDetailVM.HighestQualification;
                    dbObject.AreaOfSpecialization = personalDetailVM.AreaOfSpecialization;
                    dbObject.TeachingExperience = personalDetailVM.TeachingExperience;


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