﻿using GECP_DOT_NET_API.Database;
using GECP_DOT_NET_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GECP_DOT_NET_API.Helper
{
    public static class ExtensionMethods
    {
        #region --> FacultyDetailsVM
        public static FacultyDetailsVM ToModel(this FacultyDetail obj)
        {
            return new FacultyDetailsVM()
            {
                Id = obj.Id,
                Name = obj.Name,
                DeptId = obj.DeptId,
                DesignationId = obj.DesignationId,
                IsDeleted = obj.IsDeleted,
                CreatedDate = (DateTime)obj.CreatedDate,
                CreatedDateInt = obj.CreatedDateInt,
                UpdatedDate = obj.UpdatedDate,
                UpdatedDateInt = obj.UpdatedDateInt
            };
        }

        public static FacultyDetail ToContext(this FacultyDetailsVM obj)
        {
            return new FacultyDetail()
            {
                //Id = obj.Id,
                Name = obj.Name,
                DeptId = obj.DeptId,
                DesignationId = obj.DesignationId,
                IsDeleted = obj.IsDeleted,
                CreatedDate = obj.CreatedDate,
                CreatedDateInt = obj.CreatedDateInt,
                UpdatedDate = obj.UpdatedDate,
                UpdatedDateInt = obj.UpdatedDateInt
            };
        }
        #endregion

        #region --> PlacementVM
        public static PlacementVM ToModel(this Placement obj)
        {
            return new PlacementVM()
            {
                Id = obj.Id,
                StudentName = obj.StudentName,
                StudentPic = obj.StudentPic,
                DeptId = obj.DeptId,
                AnnualPackage = obj.AnnualPackage,
                MonthlyPackage = obj.MonthlyPackage,
                CompanyId = obj.CompanyId,
                PlacementDate = obj.PlacementDate,
                IsDeleted = obj.IsDeleted,
                CreatedDate = (DateTime)obj.CreatedDate,
                CreatedDateInt = obj.CreatedDateInt,
                UpdatedDate = obj.UpdatedDate,
                UpdatedDateInt = obj.UpdatedDateInt
            };
        }

        public static Placement ToContext(this PlacementVM obj)
        {
            return new Placement()
            {
                Id = obj.Id,
                StudentName = obj.StudentName,
                StudentPic = obj.StudentPic,
                DeptId = obj.DeptId,
                AnnualPackage = obj.AnnualPackage,
                MonthlyPackage = obj.MonthlyPackage,
                CompanyId = obj.CompanyId,
                PlacementDate = obj.PlacementDate,
                IsDeleted = obj.IsDeleted,
                CreatedDate = obj.CreatedDate,
                CreatedDateInt = obj.CreatedDateInt,
                UpdatedDate = obj.UpdatedDate,
                UpdatedDateInt = obj.UpdatedDateInt
            };
        }
        #endregion


        #region --> DesignationVM

        public static DesignationVM ToModel(this Designation obj)
        {
            return new DesignationVM()
            {
                Id = obj.Id,
                Title = obj.Title,
                Class = obj.Class,
                Payband = obj.Payband,
                IsDeleted = obj.IsDeleted,
                CreatedDate = obj.CreatedDate,
                CreatedDateInt = obj.CreatedDateInt,
                UpdatedDate = obj.UpdatedDate,
                UpdatedDateInt = obj.UpdatedDateInt
            };
        }
        public static Designation ToContext(this DesignationVM obj)
        {
            return new Designation()
            {
                Id=obj.Id,
                Title = obj.Title,
                Class = obj.Class,
                Payband = obj.Payband,
                IsDeleted=obj.IsDeleted,
                CreatedDate=DateTime.Now,
                CreatedDateInt=obj.CreatedDateInt,
                UpdatedDate= DateTime.Now,    
                UpdatedDateInt=obj.UpdatedDateInt
            };
        }
        #endregion

              
              
        #region --> CommitteeMembersVM
        public static CommitteeMembersVM ToModel(this CommitteeMember obj)
        {
            return new CommitteeMembersVM()
            {
                Id = obj.Id,
                FacultyId = obj.FacultyId,
                Role = obj.Role,
                IsDeleted = obj.IsDeleted,
                CreatedDate = (DateTime)obj.CreatedDate,
                CreatedDateInt = obj.CreatedDateInt,
                UpdatedDate = obj.UpdatedDate,
                UpdatedDateInt = obj.UpdatedDateInt
            };
        }

        public static CommitteeMember ToContext(this CommitteeMembersVM obj)
        {
            return new CommitteeMember()
            {
                //Id = obj.Id,
                FacultyId = obj.FacultyId,
                Role = obj.Role,
                IsDeleted = obj.IsDeleted,
                CreatedDate = DateTime.Now,
                CreatedDateInt = obj.CreatedDateInt,
                UpdatedDate = DateTime.Now,
                UpdatedDateInt = obj.UpdatedDateInt
            };
        }

        #endregion 
          
        #region --> CollegeVM
        public static CollegeVM ToModel(this College obj)
        {
            return new CollegeVM()
            {
                Id = obj.Id,
                Name = obj.Name,
                Principal = obj.Principal,
                PrincipalMessage = obj.PrincipalMessage,
                Description = obj.Description,
                Address = obj.Address,
                Phone = obj.Phone,
                Image = obj.Image,
                Email = obj.Email,
                IsDeleted = obj.IsDeleted,
                CreatedDate = obj.CreatedDate,
                CreatedDateInt = obj.CreatedDateInt,
                UpdatedDate = obj.UpdatedDate,
                UpdatedDateInt = obj.UpdatedDateInt
            };
        }
        public static College ToContext(this CollegeVM obj)
        {
            return new College()
            {
                Id = obj.Id,
                Name = obj.Name,
                Principal = obj.Principal,
                PrincipalMessage = obj.PrincipalMessage,
                Description = obj.Description,
                Address = obj.Address,
                Phone = obj.Phone,
                Image = obj.Image,
                Email = obj.Email,
                IsDeleted = obj.IsDeleted,
                CreatedDate = obj.CreatedDate,
                CreatedDateInt = obj.CreatedDateInt,
                UpdatedDate = obj.UpdatedDate,
                UpdatedDateInt = obj.UpdatedDateInt
            };
        }
        #endregion
          
        #region -> TenderVM
        public static Tender ToContext(this TenderVM obj)
        {
            return new Tender()
            {
                Id = obj.Id,
                Title = obj.Title,
                Description = obj.Description,
                Date = obj.Date,
                IsDeleted = obj.IsDeleted,
                CreatedDate = obj.CreatedDate,
                CreatedDateInt = obj.CreatedDateInt,
                UpdatedDate = obj.UpdatedDate,
                UpdatedDateInt = obj.UpdatedDateInt
            };
        }                  

        public static TenderVM ToModel(this Tender obj)
        {
            return new TenderVM()
            {
                Id = obj.Id,
                Title = obj.Title,
                Description = obj.Description,
                Date = obj.Date,
                IsDeleted = obj.IsDeleted,
                CreatedDate = obj.CreatedDate,
                CreatedDateInt = obj.CreatedDateInt,
                UpdatedDate = obj.UpdatedDate,
                UpdatedDateInt = obj.UpdatedDateInt
            };

        }
        #endregion

        #region -> GalleryVM
        public static Gallery ToContext(this GalleryVM obj)
        {

            return new Gallery()
            {
                Id = obj.Id,
                Name = obj.Name,
                CreatedDate = obj.CreatedDate,
                CreatedDateInt = obj.CreatedDateInt,
                Extension = obj.Extension,
                GalleryTagId = obj.GalleryTagId,
                Image = obj.Image,
                IsDeleted = obj.IsDeleted,
                UpdatedDate = obj.UpdatedDate,
                UpdatedDateInt = obj.UpdatedDateInt

            };
        }

        public static GalleryVM ToModel(this Gallery obj)
        {
            return new GalleryVM()
            {
                Id = obj.Id,
                Name = obj.Name,
                CreatedDate = obj.CreatedDate,
                CreatedDateInt = obj.CreatedDateInt,
                Extension = obj.Extension,
                GalleryTagId = obj.GalleryTagId,
                Image = obj.Image,
                IsDeleted = obj.IsDeleted,
                UpdatedDate = obj.UpdatedDate,
                UpdatedDateInt = obj.UpdatedDateInt

            };
        }
        #endregion
    }
}
