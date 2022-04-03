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
                CreatedDate = obj.CreatedDate,
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

        #region --> PublicationVM
        public static PublicationVM ToModel(this Publication obj)
        {
            return new PublicationVM()
            {
                Id = obj.Id,
                FacultyId = obj.FacultyId,
                Title = obj.Title,
                Description = obj.Description,
                Link = obj.Link,
                IsDeleted = obj.IsDeleted,
                CreatedDate = obj.CreatedDate,
                CreatedDateInt = obj.CreatedDateInt,
                UpdatedDate = obj.UpdatedDate,
                UpdatedDateInt = obj.UpdatedDateInt
            };
        }
        public static Publication ToContext(this PublicationVM obj)
        {
            return new Publication()
            {
                Id = obj.Id,
                FacultyId = obj.FacultyId,
                Title = obj.Title,
                Description = obj.Description,
                Link = obj.Link,
                IsDeleted = obj.IsDeleted,
                CreatedDate = obj.CreatedDate,
                CreatedDateInt = obj.CreatedDateInt,
                UpdatedDate = obj.UpdatedDate,
                UpdatedDateInt = obj.UpdatedDateInt
            };
        }
        #endregion
    }
}
