﻿using GECP_DOT_NET_API.Database;
using GECP_DOT_NET_API.Helper;
using GECP_DOT_NET_API.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace GECP_DOT_NET_API.Repository
{
    public class CollegeRepo : ICollegeRepo
    {
        GECP_ADMINContext DBEntities = new GECP_ADMINContext();
        public ServiceResponse<List<CollegeVM>> GetCollegeDetails()
        {
            ServiceResponse<List<CollegeVM>> serviceReponse = new ServiceResponse<List<CollegeVM>>();
            try
            {
                using (DBEntities = new GECP_ADMINContext())
                {
                    var collegeList = DBEntities.Colleges.Where(m => m.IsDeleted != true).Select(m => m.ToModel()).ToList();
                    serviceReponse.data = collegeList;
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

        public ServiceResponse<bool> UpdateCollegeDetail(CollegeVM collegeVM)
        {
            ServiceResponse<bool> serviceReponse = new ServiceResponse<bool>();
            try
            {

                College dbObject = DBEntities.Colleges.Where(m => m.Id == collegeVM.Id).FirstOrDefault();
                if (dbObject == null)
                {
                    serviceReponse.data = false;
                    serviceReponse.status_code = "200";
                    serviceReponse.message = "Data does not exist";
                }
                else
                {
                    if (!string.IsNullOrWhiteSpace(collegeVM.Image))
                    {
                        if (File.Exists(dbObject.Image))
                        {
                            File.Delete(dbObject.Image);
                        }
                        dbObject.Image = collegeVM.Image;
                    }
                    dbObject.Name = collegeVM.Name;
                    dbObject.Principal = collegeVM.Principal;
                    dbObject.PrincipalMessage = collegeVM.PrincipalMessage;
                    dbObject.Description = collegeVM.Description;
                    dbObject.Address = collegeVM.Address;
                    dbObject.Phone = collegeVM.Phone;
                    dbObject.Email = collegeVM.Email;
                    dbObject.UpdatedDate = collegeVM.UpdatedDate;


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