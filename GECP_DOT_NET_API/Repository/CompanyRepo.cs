﻿using GECP_DOT_NET_API.Database;
using GECP_DOT_NET_API.Helper;
using GECP_DOT_NET_API.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace GECP_DOT_NET_API.Repository
{
    public class CompanyRepo : ICompanyRepo
    {
        GECP_ADMINContext DBEntities = new GECP_ADMINContext();

        public ServiceResponse<List<CompanyVM>> GetAllCompanyDetails()
        {
            ServiceResponse<List<CompanyVM>> serviceReponse = new ServiceResponse<List<CompanyVM>>();
            try
            {
                using (DBEntities = new GECP_ADMINContext())
                {
                    var companyList = DBEntities.Companies.Where(m => m.IsDeleted != true).Select(m => m.ToModel()).ToList();
                    serviceReponse.data = companyList;
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
        public ServiceResponse<bool> AddCompanyDetail(CompanyVM companyVM)
        {
            ServiceResponse<bool> serviceReponse = new ServiceResponse<bool>();
            try
            {
                using (DBEntities = new GECP_ADMINContext())
                {
                    Company dbObject = companyVM.ToContext();
                    // to avoid conflict of autogenerated id
                    dbObject.Id = new int();
                    DBEntities.Companies.Add(dbObject);
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
        public ServiceResponse<bool> UpdateCompanyDetail(CompanyVM companyVM)
        {
            ServiceResponse<bool> serviceReponse = new ServiceResponse<bool>();
            try
            {

                Company dbObject = DBEntities.Companies.Where(m => m.Id == companyVM.Id).FirstOrDefault();
                if (dbObject == null)
                {
                    serviceReponse.data = false;
                    serviceReponse.status_code = "200";
                    serviceReponse.message = "Data does not exist";
                }
                else
                {
                    if (!string.IsNullOrWhiteSpace(companyVM.Image))
                    {
                        if (File.Exists(dbObject.Image))
                        {
                            File.Delete(dbObject.Image);
                        }
                        dbObject.Image = companyVM.Image;
                    }

                    dbObject.Title = companyVM.Title;
                    dbObject.Description = companyVM.Description;
                    dbObject.RelevantDepartments = companyVM.RelevantDepartments;
                    dbObject.UpdatedDate = DateTime.Now;

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

        public ServiceResponse<bool> DeleteCompanyDetail(CompanyVM companyVM)
        {
            ServiceResponse<bool> serviceReponse = new ServiceResponse<bool>();
            try
            {
                Company dbObject = DBEntities.Companies.Where(m => m.Id == companyVM.Id && m.IsDeleted != true).FirstOrDefault();
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
