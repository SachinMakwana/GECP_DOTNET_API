﻿using GECP_DOT_NET_API.Database;
using GECP_DOT_NET_API.Helper;
using GECP_DOT_NET_API.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace GECP_DOT_NET_API.Repository
{
    public class DepartmentAmentyRepo : IDepartmentAmentyRepo
    {
        GECP_ADMINContext DBEntities = new GECP_ADMINContext();
        public ServiceResponse<List<DepartmentAmentyVM>> GetDepartmentAmentyDetails()
        {
            ServiceResponse<List<DepartmentAmentyVM>> serviceReponse = new ServiceResponse<List<DepartmentAmentyVM>>();
            try
            {
                using (DBEntities = new GECP_ADMINContext())
                {
                    var departmentAmentyList = DBEntities.DepartmentAmenties.Where(m => m.IsDeleted != true).Select(m => m.ToModel()).ToList();
                    serviceReponse.data = departmentAmentyList;
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

        public ServiceResponse<bool> AddDepartmentAmentyDetail(DepartmentAmentyVM departmentAmentyVM)
        {
            ServiceResponse<bool> serviceReponse = new ServiceResponse<bool>();
            try
            {
                using (DBEntities = new GECP_ADMINContext())
                {
                    DepartmentAmenty dbObject = departmentAmentyVM.ToContext();
                    // to avoid conflict of autogenerated id
                    dbObject.Id = new int();
                    DBEntities.DepartmentAmenties.Add(dbObject);
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

        public ServiceResponse<bool> DeleteDepartmentAmentyDetail(DepartmentAmentyVM departmentAmentyVM)
        {
            ServiceResponse<bool> serviceReponse = new ServiceResponse<bool>();
            try
            {
                DepartmentAmenty dbObject = DBEntities.DepartmentAmenties.Where(m => m.Id == departmentAmentyVM.Id && m.IsDeleted != true).FirstOrDefault();
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


        public ServiceResponse<bool> UpdateDepartmentAmentyDetail(DepartmentAmentyVM departmentAmentyVM)
        {
            ServiceResponse<bool> serviceReponse = new ServiceResponse<bool>();
            try
            {

                DepartmentAmenty dbObject = DBEntities.DepartmentAmenties.Where(m => m.Id == departmentAmentyVM.Id).FirstOrDefault();
                if (dbObject == null)
                {
                    serviceReponse.data = false;
                    serviceReponse.status_code = "200";
                    serviceReponse.message = "Data does not exist";
                }
                else
                {
                    dbObject.DeptId = departmentAmentyVM.DeptId;
                    dbObject.Subjects = departmentAmentyVM.Subjects;
                    dbObject.Labs = departmentAmentyVM.Labs;
                    dbObject.Seminar = departmentAmentyVM.Seminar;
                    dbObject.Intake = departmentAmentyVM.Intake;
                    dbObject.Workshop = departmentAmentyVM.Workshop;
                    dbObject.Classroom = departmentAmentyVM.Classroom;
                    dbObject.UpdatedDate = departmentAmentyVM.UpdatedDate;

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
