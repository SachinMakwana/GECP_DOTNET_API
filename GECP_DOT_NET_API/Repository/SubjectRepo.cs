﻿using GECP_DOT_NET_API.Database;
using GECP_DOT_NET_API.Helper;
using GECP_DOT_NET_API.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace GECP_DOT_NET_API.Repository
{
    public class SubjectRepo : ISubjectRepo
    {
        
        GECP_ADMINContext DBEntities = new GECP_ADMINContext();
        public ServiceResponse<List<SubjectVM>> GetSubjectDetails()
        {
            ServiceResponse<List<SubjectVM>> serviceReponse = new ServiceResponse<List<SubjectVM>>();
            try
            {
                using (DBEntities = new GECP_ADMINContext())
                {
                    var subjectList = DBEntities.Subjects.Where(m => m.IsDeleted != true).Select(m => m.ToModel()).ToList();
                    serviceReponse.data = subjectList;
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

        public ServiceResponse<bool> AddSubjectDetails(SubjectVM subjectVM)
        {
            ServiceResponse<bool> serviceReponse = new ServiceResponse<bool>();
            try
            {
                using (DBEntities = new GECP_ADMINContext())
                {
                    Subject dbObject = subjectVM.ToContext();
                    // to avoid conflict of autogenerated id
                    dbObject.Id = new int();
                    DBEntities.Subjects.Add(dbObject);
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

        public ServiceResponse<bool> UpdateSubjectDetails(SubjectVM subjectVM)
        {
            ServiceResponse<bool> serviceReponse = new ServiceResponse<bool>();
            try
            {

                Subject dbObject = DBEntities.Subjects.Where(m => m.Id == subjectVM.Id).FirstOrDefault();
                if (dbObject == null)
                {
                    serviceReponse.data = false;
                    serviceReponse.status_code = "200";
                    serviceReponse.message = "Data does not exist";
                }
                else
                {

                  
                    
                    dbObject.Code = subjectVM.Code;
                    dbObject.Department = subjectVM.Department;
                    dbObject.Semester = subjectVM.Semester;
                    dbObject.Subject1 = subjectVM.Subject1;
                    dbObject.Acronym = subjectVM.Acronym;
                    dbObject.UpdatedDate = subjectVM.UpdatedDate;



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

        public ServiceResponse<bool> DeleteSubjectDetails(SubjectVM subjectVM)
        {
            ServiceResponse<bool> serviceReponse = new ServiceResponse<bool>();
            try
            {
                Subject dbObject = DBEntities.Subjects.Where(m => m.Id == subjectVM.Id).FirstOrDefault();
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

    }
}
