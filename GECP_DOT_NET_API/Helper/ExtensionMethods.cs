using GECP_DOT_NET_API.Database;
using GECP_DOT_NET_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GECP_DOT_NET_API.Helper
{
    public static class ExtensionMethods
    {
      
        #region --> DynamicPageVM
        public static DynamicPage ToContext(this DynamicPageVM obj)
        {
            return new DynamicPage()
            {
                Id = obj.Id,
                Title = obj.Title,
                Name = obj.Name,
                Description = obj.Description,
                IsDeleted = obj.IsDeleted,
                CreatedDate = obj.CreatedDate,
                CreatedDateInt = obj.CreatedDateInt,
                UpdatedDate = obj.UpdatedDate,
                UpdatedDateInt = obj.UpdatedDateInt
             };
        }
              
        public static DynamicPageVM ToModel(this DynamicPage obj)
        {
            return new DynamicPageVM()
            {
                Id = obj.Id,
                Title = obj.Title,
                Name = obj.Name,
                Description = obj.Description,
                IsDeleted = obj.IsDeleted,
                CreatedDate = obj.CreatedDate,
                CreatedDateInt = obj.CreatedDateInt,
                UpdatedDate = obj.UpdatedDate,
                UpdatedDateInt = obj.UpdatedDateInt
              };
          }
                  
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
                CreatedDate = obj.CreatedDate,
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

        #region --> AchivementVM

        public static AchievementVM ToModel(this Achievement obj)
        {
            return new AchievementVM()
            {
                Id = obj.Id,
                Title = obj.Title,
                Description = obj.Description,
                Image = obj.Image,
                Tag = obj.Tag,
                Date = obj.Date,
                IsVisible = obj.IsVisible,
                IsDeleted = obj.IsDeleted,
                CreatedDate = obj.CreatedDate,
                CreatedDateInt = obj.CreatedDateInt,
                UpdatedDate = obj.UpdatedDate,
                UpdatedDateInt = obj.UpdatedDateInt
            };
        }

        public static Achievement ToContext(this AchievementVM obj)
        {
            return new Achievement()
            {
                Id=obj.Id,
                Title = obj.Title,
                Description = obj.Description,
                Image = obj.Image,
                Tag = obj.Tag,
                Date = obj.Date,
                IsVisible = obj.IsVisible,
                IsDeleted=obj.IsDeleted,
                CreatedDate=obj.CreatedDate,
                CreatedDateInt=obj.CreatedDateInt,
                UpdatedDate=obj.UpdatedDate,
                UpdatedDateInt=obj.UpdatedDateInt
            };
        }
        #endregion

       
    }
}
