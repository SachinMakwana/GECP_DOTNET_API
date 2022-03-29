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
        #region --> AttachmentVM
        public static AttachmentVM ToModel(this Attachment obj)
        {
            return new AttachmentVM()
            {
                Id = obj.Id,
                Name = obj.Name,
                Title = obj.Title,
                Type = obj.Type,
                Description = obj.Description,
                Attachment1 = obj.Attachment1,
                PageId = obj.PageId,
                IsDeleted = obj.IsDeleted,
                IsVisible = obj.IsVisible,
                CreatedDate = obj.CreatedDate,
                CreatedDateInt = obj.CreatedDateInt,
                UpdatedDate = obj.UpdatedDate,
                UpdatedDateInt = obj.UpdatedDateInt
            };
        }
        public static Attachment ToContext(this AttachmentVM obj)
        {
            return new Attachment()
            {
                //Id = obj.Id,
                Name = obj.Name,
                Title = obj.Title,
                Type = obj.Type,
                Description = obj.Description,
                Attachment1 = obj.Attachment1,
                PageId = obj.PageId,
                IsDeleted = obj.IsDeleted,
                IsVisible = obj.IsVisible,
                CreatedDate = obj.CreatedDate,
                CreatedDateInt = obj.CreatedDateInt,
                UpdatedDate = obj.UpdatedDate,
                UpdatedDateInt = obj.UpdatedDateInt
            };
        }
        #endregion

        #region --> DepartmentVM
        public static DepartmentVM ToModel(this Department obj)
        {
            return new DepartmentVM()
            {
                Id = obj.Id,
                Name = obj.Name,
                Description = obj.Description,
                Head = obj.Head,
                Message = obj.Message,
                Image = obj.Image,
                Slogan = obj.Slogan,
                IsDeleted = obj.IsDeleted,
                CreatedDate = obj.CreatedDate,
                CreatedDateInt = obj.CreatedDateInt,
                UpdatedDate = obj.UpdatedDate,
                UpdatedDateInt = obj.UpdatedDateInt
            };
        }
        public static Department ToContext(this DepartmentVM obj)
        {
            return new Department()
            {
                //Id = obj.Id,
                Name = obj.Name,
                Description = obj.Description,
                Head = obj.Head,
                Message = obj.Message,
                Image = obj.Image,
                Slogan = obj.Slogan,
                IsDeleted = obj.IsDeleted,
                CreatedDate = obj.CreatedDate,
                CreatedDateInt = obj.CreatedDateInt,
                UpdatedDate = obj.UpdatedDate,
                UpdatedDateInt = obj.UpdatedDateInt
            };
        }

        #endregion

        #region --> CommitteeVM
        public static CommitteeVM ToModel(this Committee obj)
        {
            return new CommitteeVM()
            {
                Id = obj.Id,
                Name = obj.Name,
                Image = obj.Image,
                Description = obj.Description,
                Slogan = obj.Slogan,
                IsDeleted = obj.IsDeleted,
                CreatedDate = obj.CreatedDate,
                CreatedDateInt = obj.CreatedDateInt,
                UpdatedDate = obj.UpdatedDate,
                UpdatedDateInt = obj.UpdatedDateInt
            };
        }
        public static Committee ToContext(this CommitteeVM obj)
        {
            return new Committee()
            {
                //Id = obj.Id,
                Name = obj.Name,
                Image = obj.Image,
                Description = obj.Description,
                Slogan = obj.Slogan,
                IsDeleted = obj.IsDeleted,
                CreatedDate = obj.CreatedDate,
                CreatedDateInt = obj.CreatedDateInt,
                UpdatedDate = obj.UpdatedDate,
                UpdatedDateInt = obj.UpdatedDateInt
            };
        }

        #endregion

        #region --> LabWorkshopVM
        public static LabWorkshopVM ToModel(this LabWorkshopDetail obj)
        {
            return new LabWorkshopVM()
            {
                Id = obj.Id,
                DeptId = obj.DeptId,
                Name = obj.Name,
                Description = obj.Description,
                Image = obj.Image,
                IsDeleted = obj.IsDeleted,
                CreatedDate = obj.CreatedDate,
                CreatedDateInt = obj.CreatedDateInt,
                UpdatedDate = obj.UpdatedDate,
                UpdatedDateInt = obj.UpdatedDateInt
            };
        }
        public static LabWorkshopDetail ToContext(this LabWorkshopVM obj)
        {
            return new LabWorkshopDetail()
            {
                //Id = obj.Id,
                DeptId = obj.DeptId,
                Name = obj.Name,
                Description = obj.Description,
                Image = obj.Image,
                IsDeleted = obj.IsDeleted,
                CreatedDate = obj.CreatedDate,
                CreatedDateInt = obj.CreatedDateInt,
                UpdatedDate = obj.UpdatedDate,
                UpdatedDateInt = obj.UpdatedDateInt
            };
        }
        #endregion

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
    }
}
