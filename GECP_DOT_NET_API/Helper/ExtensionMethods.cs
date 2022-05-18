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

        #region --> EducationDetailVM

        public static EducationalDetailsVM ToModel(this EducationalDetail obj)
        {
            return new EducationalDetailsVM()
            {
                Id = obj.Id,
                FacultyId = obj.FacultyId,
                Title = obj.Title,
                BoardCollege = obj.BoardCollege,
                Passout = obj.Passout,
                IsDeleted = obj.IsDeleted,
                CreatedDate = obj.CreatedDate,
                CreatedDateInt = obj.CreatedDateInt,
                UpdatedDate = obj.UpdatedDate,
                UpdatedDateInt = obj.UpdatedDateInt
            };
        }

        public static EducationalDetail ToContext(this EducationalDetailsVM obj)
        {
            return new EducationalDetail()
            {
                Id=obj.Id,
                FacultyId = obj.FacultyId,
                Title = obj.Title,
                BoardCollege = obj.BoardCollege,
                Passout = obj.Passout,
                IsDeleted=obj.IsDeleted,
                CreatedDate=obj.CreatedDate,
                CreatedDateInt=obj.CreatedDateInt,
                UpdatedDate=obj.UpdatedDate,
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

        #region --> GalleryTagVM
        public static GalleryTagVM ToModel(this GalleryTag obj)
        {
            return new GalleryTagVM()
            {
                Id = obj.Id,
                Title = obj.Title,
                Description = obj.Description,
                IsDeleted = obj.IsDeleted,
                CreatedDate = obj.CreatedDate,
                CreatedDateInt = obj.CreatedDateInt,
                UpdatedDate = obj.UpdatedDate,
                UpdatedDateInt = obj.UpdatedDateInt
            };
        }

        public static GalleryTag ToContext(this GalleryTagVM obj)
        {
            return new GalleryTag()
            {
                Id = obj.Id,
                Title = obj.Title,
                Description = obj.Description,
                IsDeleted = obj.IsDeleted,
                CreatedDate = obj.CreatedDate,
                CreatedDateInt = obj.CreatedDateInt,
                UpdatedDate = obj.UpdatedDate,
                UpdatedDateInt = obj.UpdatedDateInt
            };
        }
        #endregion

        #region --> VisionVM
        public static VisionVM ToModel(this Vision obj)
        {
            return new VisionVM()
            {
                Id = obj.Id,
                DeptId = obj.DeptId,
                Description = obj.Description,
                IsDeleted = obj.IsDeleted,
                CreatedDate = (DateTime)obj.CreatedDate,
                CreatedDateInt = obj.CreatedDateInt,
                UpdatedDate = obj.UpdatedDate,
                UpdatedDateInt = obj.UpdatedDateInt
            };
        }
        public static Vision ToContext(this VisionVM obj)
        {
            return new Vision()
            {
                Id = obj.Id,
                DeptId = obj.DeptId,
                Description = obj.Description,
                IsDeleted = obj.IsDeleted,
                CreatedDate = obj.CreatedDate,
                CreatedDateInt = obj.CreatedDateInt,
                UpdatedDate = obj.UpdatedDate,
                UpdatedDateInt = obj.UpdatedDateInt
            };
        }
        #endregion

        #region --> NewsVM

        public static NewsVM ToModel(this News obj)
        {
            return new NewsVM()
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

        public static News ToContext(this NewsVM obj)
        {
            return new News()
            {
                Id=obj.Id,
                Title=obj.Title,
                Description=obj.Description,
                Date=obj.Date,
                IsDeleted=obj.IsDeleted,
                CreatedDate=obj.CreatedDate,
                CreatedDateInt=obj.CreatedDateInt,
                UpdatedDate=obj.UpdatedDate,
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
          
        #region --> PosrtfolioVM
        public static PortfolioVM ToModel(this Portfolio obj)
        {
            return new PortfolioVM()
            {
                Id = obj.Id,
                FacultyId = obj.FacultyId,
                Title = obj.Title,
                Description = obj.Description,
                Link = obj.Link,
                Organization = obj.Organization,
                FromDate = obj.FromDate,
                FromDateInt = obj.FromDateInt,
                ToDate = obj.ToDate,
                ToDateInt = obj.ToDateInt,
                Designation = obj.Designation,
                Expertise = obj.Expertise,
                Description = obj.Description,
                Level = obj.Level,
                IsDeleted = obj.IsDeleted,
                CreatedDate = obj.CreatedDate,
                CreatedDateInt = obj.CreatedDateInt,
                UpdatedDate = obj.UpdatedDate,
                UpdatedDateInt = obj.UpdatedDateInt
            };
        }

        public static Portfolio ToContext(this PortfolioVM obj)
        {
            return new Portfolio()
            {
                Id = obj.Id,
                FacultyId = obj.FacultyId,
                Title = obj.Title,
                Description = obj.Description,
                Link = obj.Link,
                Level = obj.Level,
                IsDeleted = obj.IsDeleted,
                CreatedDate = DateTime.Now,
                CreatedDateInt = obj.CreatedDateInt,
                UpdatedDate = DateTime.Now,
                UpdatedDateInt = obj.UpdatedDateInt
            };
        }
        #endregion
        
        #region --> WorkExperienceVM
        public static WorkExperienceVM ToModel(this WorkExperience obj)
        {
            return new WorkExperienceVM()
            {
                Id = obj.Id,
                FacultyId = obj.FacultyId,
                Title = obj.Title,
                Organization = obj.Organization,
                FromDate = obj.FromDate,
                FromDateInt = obj.FromDateInt,
                ToDate = obj.ToDate,
                ToDateInt = obj.ToDateInt,
                Designation = obj.Designation,
                Expertise = obj.Expertise,
                IsDeleted = obj.IsDeleted,
                CreatedDate = (DateTime)obj.CreatedDate,
                CreatedDateInt = obj.CreatedDateInt,
                UpdatedDate = obj.UpdatedDate,
                UpdatedDateInt = obj.UpdatedDateInt
            };
        }
        public static WorkExperience ToContext(this WorkExperienceVM obj)
        {
            return new WorkExperience()
            {
                Id = obj.Id,
                FacultyId = obj.FacultyId,
                Title = obj.Title,
                Organization = obj.Organization,
                FromDate = obj.FromDate,
                FromDateInt = obj.FromDateInt,
                ToDate = obj.ToDate,
                ToDateInt = obj.ToDateInt,
                Designation = obj.Designation,
                Expertise = obj.Expertise,
                IsDeleted = obj.IsDeleted,
                CreatedDate = obj.CreatedDate,
                CreatedDateInt = obj.CreatedDateInt,
                UpdatedDate = obj.UpdatedDate,
                UpdatedDateInt = obj.UpdatedDateInt
            };
        }
        #endregion
        
        #region --> GalleryVM
        public static GalleryVM ToModel(this Gallery obj)
        {
            return new GalleryVM()
            {
                Id = obj.Id,
                GalleryTagId = obj.GalleryTagId,
                Name = obj.Name,
                Extension = obj.Extension,
                Image = obj.Image,
                IsDeleted = obj.IsDeleted,
                CreatedDate = obj.CreatedDate,
                CreatedDateInt = obj.CreatedDateInt,
                UpdatedDate = obj.UpdatedDate,
                UpdatedDateInt = obj.UpdatedDateInt
            };
        }
        public static Gallery ToContext(this GalleryVM obj)
        {
            return new Gallery()
            {
                Id = obj.Id,
                GalleryTagId = obj.GalleryTagId,
                Name = obj.Name,
                Extension = obj.Extension,
                Image = obj.Image,
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
        #endregion

    }
  
}
