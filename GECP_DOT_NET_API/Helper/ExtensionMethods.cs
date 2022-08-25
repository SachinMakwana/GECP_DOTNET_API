using GECP_DOT_NET_API.Database;
using GECP_DOT_NET_API.Models;
using System;

namespace GECP_DOT_NET_API.Helper
{
    public static class ExtensionMethods
    {

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
                CreatedDate = (DateTime)obj.CreatedDate,
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

        #region --> MissionVM
        public static MissionVM ToModel(this Mission obj)
        {
            return new MissionVM()
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

        public static Mission ToContext(this MissionVM obj)
        {
            return new Mission()
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
                CreatedDate = (DateTime)obj.CreatedDate,
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

        #region -> CircularVM

        public static Circular ToContext(this CircularVM obj)
        {
            return new Circular()
            {
                Id = obj.Id,
                Title = obj.Title,
                Date = obj.Date,
                IsDeleted=obj.IsDeleted,
                CreatedDate=obj.CreatedDate,
                Description=obj.Description,
                CreatedDateInt=obj.CreatedDateInt,
                UpdatedDate=obj.UpdatedDate,
                UpdatedDateInt = obj.UpdatedDateInt
            };
        }

        public static CircularVM ToModel(this Circular obj)
        {
            return new CircularVM()
            {
                Id = obj.Id,
                Title = obj.Title,
                Date = obj.Date,
                IsDeleted = obj.IsDeleted,
                CreatedDate = obj.CreatedDate,
                Description = obj.Description,
                CreatedDateInt = obj.CreatedDateInt,
                UpdatedDate = obj.UpdatedDate,
                UpdatedDateInt = obj.UpdatedDateInt
            };

        }
        #endregion
          
        #region --> PortfolioVM
        public static PortfolioVM ToModel(this Portfolio obj)
        {
            return new PortfolioVM()
            {
                Id = obj.Id,
                FacultyId = obj.FacultyId,
                Title = obj.Title,
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
                Level = obj.Level,
                IsDeleted = obj.IsDeleted,
                CreatedDate = obj.CreatedDate,
                CreatedDateInt = obj.CreatedDateInt,
                UpdatedDate = obj.UpdatedDate,
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
        
        #region --> DepartmentAmentyVM
        public static DepartmentAmentyVM ToModel(this DepartmentAmenty obj)
        {
            return new DepartmentAmentyVM()
            {
                Id = obj.Id,
                DeptId = obj.DeptId,
                Intake = obj.Intake,
                Subjects = obj.Subjects,
                Labs = obj.Labs,
                Workshop = obj.Workshop,
                Classroom = obj.Classroom,
                Seminar = obj.Seminar,
                IsDeleted = obj.IsDeleted,
                CreatedDate = (System.DateTime)obj.CreatedDate,
                CreatedDateInt = obj.CreatedDateInt,
                UpdatedDate = obj.UpdatedDate,
            };
        }
        public static DepartmentAmenty ToContext(this DepartmentAmentyVM obj)
        {
            return new DepartmentAmenty()
            {
                Id = obj.Id,
                DeptId = obj.DeptId,
                Intake = obj.Intake,
                Subjects = obj.Subjects,
                Labs = obj.Labs,
                Workshop = obj.Workshop,
                Classroom = obj.Classroom,
                Seminar = obj.Seminar,
                IsDeleted = obj.IsDeleted,
                CreatedDate = System.DateTime.Now,
                CreatedDateInt = obj.CreatedDateInt,
                UpdatedDate = System.DateTime.Now,
                UpdatedDateInt = obj.UpdatedDateInt
            };
        }
        #endregion 
        
        #region --> MedaiLinkVM
        public static MediaLinkVM ToModel(this MediaLink obj)
        {
            return new MediaLinkVM()
            {
                Id = obj.Id,
                DeptId = obj.DeptId,
                Title = obj.Title,
                Link = obj.Link,
                IsVisible = obj.IsVisible,
                IsDeleted = obj.IsDeleted,
                CreatedDate = (DateTime)obj.CreatedDate,
                CreatedDateInt = obj.CreatedDateInt,
                UpdatedDate = obj.UpdatedDate,
                UpdatedDateInt = obj.UpdatedDateInt
            };
        }
        public static MediaLink ToContext(this MediaLinkVM obj)
        {
            return new MediaLink()
            {
                Id = obj.Id,
                DeptId=obj.DeptId,
                Title = obj.Title,
                Link = obj.Link,
                IsVisible = obj.IsVisible,
                IsDeleted=obj.IsDeleted,
                CreatedDate=obj.CreatedDate,
                CreatedDateInt=obj.CreatedDateInt,
                UpdatedDate=obj.UpdatedDate,
                UpdatedDateInt=obj.UpdatedDateInt
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
                CreatedDate = (DateTime)obj.CreatedDate,
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

        #region --> Grievance and Grivance Status

        public static GrievanceVM ToModel(this Grievance obj)
        {
            return new GrievanceVM()
            {
                Id = obj.Id,
                Name = obj.Name,
                EmailId = obj.EmailId,
                Mobile = obj.Mobile,
                Subject = obj.Subject,
                Description = obj.Description,
                Attachments = obj.Attachments,
                CreatedDate = (DateTime)obj.CreatedDate,
                CreatedDateInt = obj.CreatedDateInt,
                UpdatedDate = obj.UpdatedDate,
                UpdatedDateInt = obj.UpdatedDateInt
            };
        }

        public static Grievance ToContext(this GrievanceVM obj)
        {
            return new Grievance()
            {
                Id = obj.Id,
                Name = obj.Name,
                EmailId = obj.EmailId,
                Mobile = obj.Mobile,
                Subject = obj.Subject,
                Description = obj.Description,
                Attachments = obj.Attachments,
                CreatedDate = obj.CreatedDate,
                CreatedDateInt = obj.CreatedDateInt,
                UpdatedDate = obj.UpdatedDate,
                UpdatedDateInt = obj.UpdatedDateInt
            };
        }

        public static GrievanceStatusVM ToModel(this GrievanceStatus obj)
        {
            return new GrievanceStatusVM()
            {
                Id = obj.Id,
                GrievanceId = obj.GrievanceId,
                Status = obj.Status,
                Description = obj.Description,
                CreatedDate = obj.CreatedDate,
                CreatedDateInt = obj.CreatedDateInt,
                UpdatedDate = obj.UpdatedDate,
                UpdatedDateInt = obj.UpdatedDateInt
            };
        }

        public static GrievanceStatus ToContext(this GrievanceStatusVM obj)
        {
            return new GrievanceStatus()
            {
                Id = obj.Id,
                GrievanceId = obj.GrievanceId,
                Status = obj.Status,
                Description = obj.Description,
                CreatedDate = obj.CreatedDate,
                CreatedDateInt = obj.CreatedDateInt,
                UpdatedDate = obj.UpdatedDate,
                UpdatedDateInt = obj.UpdatedDateInt
            };
        }

        #endregion
    }
}
