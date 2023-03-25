using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace GECP_DOT_NET_API.Database
{
    public partial class GECPATAN_PRODContext : DbContext
    {
        public GECPATAN_PRODContext()
        {
        }

        public GECPATAN_PRODContext(DbContextOptions<GECPATAN_PRODContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Achievement> Achievements { get; set; }
        public virtual DbSet<Affiliation> Affiliations { get; set; }
        public virtual DbSet<Attachment> Attachments { get; set; }
        public virtual DbSet<BackendMenu> BackendMenus { get; set; }
        public virtual DbSet<Campus> Campuses { get; set; }
        public virtual DbSet<Circular> Circulars { get; set; }
        public virtual DbSet<College> Colleges { get; set; }
        public virtual DbSet<Committee> Committees { get; set; }
        public virtual DbSet<CommitteeMember> CommitteeMembers { get; set; }
        public virtual DbSet<Company> Companies { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<DepartmentAmenty> DepartmentAmenties { get; set; }
        public virtual DbSet<Designation> Designations { get; set; }
        public virtual DbSet<DynamicPage> DynamicPages { get; set; }
        public virtual DbSet<EducationalDetail> EducationalDetails { get; set; }
        public virtual DbSet<ExternalFacultyDetail> ExternalFacultyDetails { get; set; }
        public virtual DbSet<FacultyDetail> FacultyDetails { get; set; }
        public virtual DbSet<FrontendMenu> FrontendMenus { get; set; }
        public virtual DbSet<Gallery> Galleries { get; set; }
        public virtual DbSet<GalleryTag> GalleryTags { get; set; }
        public virtual DbSet<GeneralLog> GeneralLogs { get; set; }
        public virtual DbSet<Grievance> Grievances { get; set; }
        public virtual DbSet<GrievanceStatus> GrievanceStatuses { get; set; }
        public virtual DbSet<LabWorkshopDetail> LabWorkshopDetails { get; set; }
        public virtual DbSet<MediaLink> MediaLinks { get; set; }
        public virtual DbSet<MenuItem> MenuItems { get; set; }
        public virtual DbSet<MicroLog> MicroLogs { get; set; }
        public virtual DbSet<MiniLog> MiniLogs { get; set; }
        public virtual DbSet<Mission> Missions { get; set; }
        public virtual DbSet<News> News { get; set; }
        public virtual DbSet<ParentItem> ParentItems { get; set; }
        public virtual DbSet<PersonalDetail> PersonalDetails { get; set; }
        public virtual DbSet<Placement> Placements { get; set; }
        public virtual DbSet<PlacementDetail> PlacementDetails { get; set; }
        public virtual DbSet<Portfolio> Portfolios { get; set; }
        public virtual DbSet<Publication> Publications { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<SsipProject> SsipProjects { get; set; }
        public virtual DbSet<Subject> Subjects { get; set; }
        public virtual DbSet<Tag> Tags { get; set; }
        public virtual DbSet<Tender> Tenders { get; set; }
        public virtual DbSet<UsersDetail> UsersDetails { get; set; }
        public virtual DbSet<Vision> Visions { get; set; }
        public virtual DbSet<WorkExperience> WorkExperiences { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=103.86.176.224;Database=GECPATAN_PROD;User Id=root;Password='Admin@123';");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("root")
                .HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Achievement>(entity =>
            {
                entity.ToTable("Achievements", "dbo");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedDateInt)
                    .HasMaxLength(4000)
                    .HasComputedColumnSql("(format([CreatedDate],'yyyyMMddHHmmssffff'))", false);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Description).IsRequired();

                entity.Property(e => e.Tag)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.UpdatedDateInt)
                    .HasMaxLength(4000)
                    .HasComputedColumnSql("(format([CreatedDate],'yyyyMMddHHmmssffff'))", false);
            });

            modelBuilder.Entity<Affiliation>(entity =>
            {
                entity.ToTable("Affiliation", "dbo");

                entity.Property(e => e.Attachements)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedDateInt)
                    .HasMaxLength(4000)
                    .HasComputedColumnSql("(format([CreatedDate],'yyyyMMddHHmmssffff'))", false);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.UpdatedDateInt)
                    .HasMaxLength(4000)
                    .HasComputedColumnSql("(format([CreatedDate],'yyyyMMddHHmmssffff'))", false);
            });

            modelBuilder.Entity<Attachment>(entity =>
            {
                entity.ToTable("Attachments", "dbo");

                entity.Property(e => e.Attachment1)
                    .IsRequired()
                    .HasColumnName("Attachment");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedDateInt)
                    .HasMaxLength(4000)
                    .HasComputedColumnSql("(format([CreatedDate],'yyyyMMddHHmmssffff'))", false);

                entity.Property(e => e.Description).IsRequired();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.UpdatedDateInt)
                    .HasMaxLength(4000)
                    .HasComputedColumnSql("(format([CreatedDate],'yyyyMMddHHmmssffff'))", false);
            });

            modelBuilder.Entity<BackendMenu>(entity =>
            {
                entity.ToTable("BackendMenu", "dbo");

                entity.Property(e => e.ControllerName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedDateInt)
                    .HasMaxLength(4000)
                    .HasComputedColumnSql("(format([CreatedDate],'yyyyMMddHHmmssffff'))", false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.UpdatedDateInt)
                    .HasMaxLength(4000)
                    .HasComputedColumnSql("(format([CreatedDate],'yyyyMMddHHmmssffff'))", false);

                entity.Property(e => e.ViewName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Campus>(entity =>
            {
                entity.ToTable("Campus", "dbo");

                entity.Property(e => e.Category)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedDateInt)
                    .HasMaxLength(4000)
                    .HasComputedColumnSql("(format([CreatedDate],'yyyyMMddHHmmssffff'))", false);

                entity.Property(e => e.Department)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Image).IsRequired();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.UpdatedDateInt)
                    .HasMaxLength(4000)
                    .HasComputedColumnSql("(format([UpdatedDate],'yyyyMMddHHmmssffff'))", false);
            });

            modelBuilder.Entity<Circular>(entity =>
            {
                entity.ToTable("Circular", "dbo");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedDateInt)
                    .HasMaxLength(4000)
                    .HasComputedColumnSql("(format([CreatedDate],'yyyyMMddHHmmssffff'))", false);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Description).IsRequired();

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.UpdatedDateInt)
                    .HasMaxLength(4000)
                    .HasComputedColumnSql("(format([CreatedDate],'yyyyMMddHHmmssffff'))", false);
            });

            modelBuilder.Entity<College>(entity =>
            {
                entity.ToTable("College", "dbo");

                entity.Property(e => e.Address).IsRequired();

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedDateInt)
                    .HasMaxLength(4000)
                    .HasComputedColumnSql("(format([CreatedDate],'yyyyMMddHHmmssffff'))", false);

                entity.Property(e => e.Description).IsRequired();

                entity.Property(e => e.Email).IsRequired();

                entity.Property(e => e.Image).IsRequired();

                entity.Property(e => e.Name).IsRequired();

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Principal).IsRequired();

                entity.Property(e => e.PrincipalMessage).IsRequired();

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.UpdatedDateInt)
                    .HasMaxLength(4000)
                    .HasComputedColumnSql("(format([UpdatedDate],'yyyyMMddHHmmssffff'))", false);
            });

            modelBuilder.Entity<Committee>(entity =>
            {
                entity.ToTable("Committee", "dbo");

                entity.Property(e => e.CommitteeId).HasColumnName("CommitteeID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedDateInt)
                    .HasMaxLength(4000)
                    .HasComputedColumnSql("(format([CreatedDate],'yyyyMMddHHmmssffff'))", false);

                entity.Property(e => e.Description).IsRequired();

                entity.Property(e => e.Image).IsRequired();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Slogan).IsRequired();

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.UpdatedDateInt)
                    .HasMaxLength(4000)
                    .HasComputedColumnSql("(format([UpdatedDate],'yyyyMMddHHmmssffff'))", false);
            });

            modelBuilder.Entity<CommitteeMember>(entity =>
            {
                entity.ToTable("CommitteeMembers", "dbo");

                entity.Property(e => e.CommitteeId).HasColumnName("CommitteeID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedDateInt)
                    .HasMaxLength(4000)
                    .HasComputedColumnSql("(format([CreatedDate],'yyyyMMddHHmmssffff'))", false);

                entity.Property(e => e.Role)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.UpdatedDateInt)
                    .HasMaxLength(4000)
                    .HasComputedColumnSql("(format([CreatedDate],'yyyyMMddHHmmssffff'))", false);
            });

            modelBuilder.Entity<Company>(entity =>
            {
                entity.ToTable("Company", "dbo");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedDateInt)
                    .HasMaxLength(4000)
                    .HasComputedColumnSql("(format([CreatedDate],'yyyyMMddHHmmssffff'))", false);

                entity.Property(e => e.Description).IsRequired();

                entity.Property(e => e.Image).IsRequired();

                entity.Property(e => e.Logo).IsRequired();

                entity.Property(e => e.RelevantDepartments).IsRequired();

                entity.Property(e => e.Title).IsRequired();

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.UpdatedDateInt)
                    .HasMaxLength(4000)
                    .HasComputedColumnSql("(format([UpdatedDate],'yyyyMMddHHmmssffff'))", false);
            });

            modelBuilder.Entity<Department>(entity =>
            {
                entity.ToTable("Department", "dbo");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedDateInt)
                    .HasMaxLength(4000)
                    .HasComputedColumnSql("(format([CreatedDate],'yyyyMMddHHmmssffff'))", false);

                entity.Property(e => e.Description).IsRequired();

                entity.Property(e => e.Image).IsRequired();

                entity.Property(e => e.Message).IsRequired();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Slogan).IsRequired();

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.UpdatedDateInt)
                    .HasMaxLength(4000)
                    .HasComputedColumnSql("(format([CreatedDate],'yyyyMMddHHmmssffff'))", false);
            });

            modelBuilder.Entity<DepartmentAmenty>(entity =>
            {
                entity.ToTable("DepartmentAmenties", "dbo");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedDateInt)
                    .HasMaxLength(4000)
                    .HasComputedColumnSql("(format([CreatedDate],'yyyyMMddHHmmssffff'))", false);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.UpdatedDateInt)
                    .HasMaxLength(4000)
                    .HasComputedColumnSql("(format([CreatedDate],'yyyyMMddHHmmssffff'))", false);
            });

            modelBuilder.Entity<Designation>(entity =>
            {
                entity.ToTable("Designations", "dbo");

                entity.Property(e => e.Class)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedDateInt)
                    .HasMaxLength(4000)
                    .HasComputedColumnSql("(format([CreatedDate],'yyyyMMddHHmmssffff'))", false);

                entity.Property(e => e.Payband).HasMaxLength(50);

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.UpdatedDateInt)
                    .HasMaxLength(4000)
                    .HasComputedColumnSql("(format([CreatedDate],'yyyyMMddHHmmssffff'))", false);
            });

            modelBuilder.Entity<DynamicPage>(entity =>
            {
                entity.ToTable("DynamicPage", "dbo");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedDateInt)
                    .HasMaxLength(4000)
                    .HasComputedColumnSql("(format([CreatedDate],'yyyyMMddHHmmssffff'))", false);

                entity.Property(e => e.Description).IsRequired();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.UpdatedDateInt)
                    .HasMaxLength(4000)
                    .HasComputedColumnSql("(format([CreatedDate],'yyyyMMddHHmmssffff'))", false);
            });

            modelBuilder.Entity<EducationalDetail>(entity =>
            {
                entity.ToTable("EducationalDetails", "dbo");

                entity.Property(e => e.BoardCollege)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedDateInt)
                    .HasMaxLength(4000)
                    .HasComputedColumnSql("(format([CreatedDate],'yyyyMMddHHmmssffff'))", false);

                entity.Property(e => e.Passout).HasMaxLength(50);

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.UpdatedDateInt)
                    .HasMaxLength(4000)
                    .HasComputedColumnSql("(format([CreatedDate],'yyyyMMddHHmmssffff'))", false);
            });

            modelBuilder.Entity<ExternalFacultyDetail>(entity =>
            {
                entity.ToTable("ExternalFacultyDetail", "dbo");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedDateInt)
                    .HasMaxLength(4000)
                    .HasComputedColumnSql("(format([CreatedDate],'yyyyMMddHHmmssffff'))", false);

                entity.Property(e => e.Department)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Designation)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.UpdatedDateInt)
                    .HasMaxLength(4000)
                    .HasComputedColumnSql("(format([CreatedDate],'yyyyMMddHHmmssffff'))", false);
            });

            modelBuilder.Entity<FacultyDetail>(entity =>
            {
                entity.ToTable("FacultyDetail", "dbo");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedDateInt)
                    .HasMaxLength(4000)
                    .HasComputedColumnSql("(format([CreatedDate],'yyyyMMddHHmmssffff'))", false);

                entity.Property(e => e.Designation).IsRequired();

                entity.Property(e => e.Image).IsRequired();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.UpdatedDateInt)
                    .HasMaxLength(4000)
                    .HasComputedColumnSql("(format([UpdatedDate],'yyyyMMddHHmmssffff'))", false);
            });

            modelBuilder.Entity<FrontendMenu>(entity =>
            {
                entity.ToTable("FrontendMenu", "dbo");

                entity.Property(e => e.ControllerName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedDateInt)
                    .HasMaxLength(4000)
                    .HasComputedColumnSql("(format([CreatedDate],'yyyyMMddHHmmssffff'))", false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.UpdatedDateInt)
                    .HasMaxLength(4000)
                    .HasComputedColumnSql("(format([CreatedDate],'yyyyMMddHHmmssffff'))", false);

                entity.Property(e => e.ViewName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Gallery>(entity =>
            {
                entity.ToTable("Gallery", "dbo");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedDateInt)
                    .HasMaxLength(4000)
                    .HasComputedColumnSql("(format([CreatedDate],'yyyyMMddHHmmssffff'))", false);

                entity.Property(e => e.Extension)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Image).IsRequired();

                entity.Property(e => e.Name).IsRequired();

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.UpdatedDateInt)
                    .HasMaxLength(4000)
                    .HasComputedColumnSql("(format([UpdatedDate],'yyyyMMddHHmmssffff'))", false);
            });

            modelBuilder.Entity<GalleryTag>(entity =>
            {
                entity.ToTable("GalleryTag", "dbo");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedDateInt)
                    .HasMaxLength(4000)
                    .HasComputedColumnSql("(format([CreatedDate],'yyyyMMddHHmmssffff'))", false);

                entity.Property(e => e.Description).IsRequired();

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.UpdatedDateInt)
                    .HasMaxLength(4000)
                    .HasComputedColumnSql("(format([CreatedDate],'yyyyMMddHHmmssffff'))", false);
            });

            modelBuilder.Entity<GeneralLog>(entity =>
            {
                entity.ToTable("GeneralLog", "dbo");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedDateInt)
                    .HasMaxLength(4000)
                    .HasComputedColumnSql("(format([CreatedDate],'yyyyMMddHHmmssffff'))", false);

                entity.Property(e => e.Device)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Event)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Ipaddress)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("IPAddress");

                entity.Property(e => e.Region)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.UpdatedDateInt)
                    .HasMaxLength(4000)
                    .HasComputedColumnSql("(format([CreatedDate],'yyyyMMddHHmmssffff'))", false);
            });

            modelBuilder.Entity<Grievance>(entity =>
            {
                entity.ToTable("Grievance", "dbo");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedDateInt)
                    .HasMaxLength(4000)
                    .HasComputedColumnSql("(format([CreatedDate],'yyyyMMddHHmmssffff'))", false);

                entity.Property(e => e.Description).IsRequired();

                entity.Property(e => e.EmailId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("EmailID");

                entity.Property(e => e.Mobile)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Subject)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.UpdatedDateInt)
                    .HasMaxLength(4000)
                    .HasComputedColumnSql("(format([UpdatedDate],'yyyyMMddHHmmssffff'))", false);
            });

            modelBuilder.Entity<GrievanceStatus>(entity =>
            {
                entity.ToTable("GrievanceStatus", "dbo");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedDateInt)
                    .HasMaxLength(4000)
                    .HasComputedColumnSql("(format([CreatedDate],'yyyyMMddHHmmssffff'))", false);

                entity.Property(e => e.GrievanceId).HasColumnName("GrievanceID");

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.UpdatedDateInt)
                    .HasMaxLength(4000)
                    .HasComputedColumnSql("(format([UpdatedDate],'yyyyMMddHHmmssffff'))", false);
            });

            modelBuilder.Entity<LabWorkshopDetail>(entity =>
            {
                entity.ToTable("LabWorkshopDetails", "dbo");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedDateInt)
                    .HasMaxLength(4000)
                    .HasComputedColumnSql("(format([CreatedDate],'yyyyMMddHHmmssffff'))", false);

                entity.Property(e => e.Description).IsRequired();

                entity.Property(e => e.Image).IsRequired();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.UpdatedDateInt)
                    .HasMaxLength(4000)
                    .HasComputedColumnSql("(format([UpdatedDate],'yyyyMMddHHmmssffff'))", false);
            });

            modelBuilder.Entity<MediaLink>(entity =>
            {
                entity.ToTable("MediaLinks", "dbo");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedDateInt)
                    .HasMaxLength(4000)
                    .HasComputedColumnSql("(format([CreatedDate],'yyyyMMddHHmmssffff'))", false);

                entity.Property(e => e.Link)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.UpdatedDateInt)
                    .HasMaxLength(4000)
                    .HasComputedColumnSql("(format([CreatedDate],'yyyyMMddHHmmssffff'))", false);
            });

            modelBuilder.Entity<MenuItem>(entity =>
            {
                entity.ToTable("MenuItems", "dbo");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedDateInt)
                    .HasMaxLength(4000)
                    .HasComputedColumnSql("(format([CreatedDate],'yyyyMMddHHmmssffff'))", false);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.UpdatedDateInt)
                    .HasMaxLength(4000)
                    .HasComputedColumnSql("(format([CreatedDate],'yyyyMMddHHmmssffff'))", false);
            });

            modelBuilder.Entity<MicroLog>(entity =>
            {
                entity.ToTable("MicroLog", "dbo");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedDateInt)
                    .HasMaxLength(4000)
                    .HasComputedColumnSql("(format([CreatedDate],'yyyyMMddHHmmssffff'))", false);

                entity.Property(e => e.Description).IsRequired();

                entity.Property(e => e.Event)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.UpdatedDateInt)
                    .HasMaxLength(4000)
                    .HasComputedColumnSql("(format([CreatedDate],'yyyyMMddHHmmssffff'))", false);
            });

            modelBuilder.Entity<MiniLog>(entity =>
            {
                entity.ToTable("MiniLog", "dbo");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedDateInt)
                    .HasMaxLength(4000)
                    .HasComputedColumnSql("(format([CreatedDate],'yyyyMMddHHmmssffff'))", false);

                entity.Property(e => e.Description).IsRequired();

                entity.Property(e => e.Event)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.UpdatedDateInt)
                    .HasMaxLength(4000)
                    .HasComputedColumnSql("(format([CreatedDate],'yyyyMMddHHmmssffff'))", false);
            });

            modelBuilder.Entity<Mission>(entity =>
            {
                entity.ToTable("Mission", "dbo");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedDateInt)
                    .HasMaxLength(4000)
                    .HasComputedColumnSql("(format([CreatedDate],'yyyyMMddHHmmssffff'))", false);

                entity.Property(e => e.Description).IsRequired();

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.UpdatedDateInt)
                    .HasMaxLength(4000)
                    .HasComputedColumnSql("(format([CreatedDate],'yyyyMMddHHmmssffff'))", false);
            });

            modelBuilder.Entity<News>(entity =>
            {
                entity.ToTable("News", "dbo");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedDateInt)
                    .HasMaxLength(4000)
                    .HasComputedColumnSql("(format([CreatedDate],'yyyyMMddHHmmssffff'))", false);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Description).IsRequired();

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.UpdatedDateInt)
                    .HasMaxLength(4000)
                    .HasComputedColumnSql("(format([CreatedDate],'yyyyMMddHHmmssffff'))", false);
            });

            modelBuilder.Entity<ParentItem>(entity =>
            {
                entity.ToTable("ParentItems", "dbo");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedDateInt)
                    .HasMaxLength(4000)
                    .HasComputedColumnSql("(format([CreatedDate],'yyyyMMddHHmmssffff'))", false);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.UpdatedDateInt)
                    .HasMaxLength(4000)
                    .HasComputedColumnSql("(format([CreatedDate],'yyyyMMddHHmmssffff'))", false);
            });

            modelBuilder.Entity<PersonalDetail>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ContactNumber)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedDateInt)
                    .HasMaxLength(4000)
                    .HasComputedColumnSql("(format([CreatedDate],'yyyyMMddHHmmssffff'))", false);

                entity.Property(e => e.CurrentAddress).IsRequired();

                entity.Property(e => e.Dob)
                    .HasColumnType("date")
                    .HasColumnName("DOB");

                entity.Property(e => e.Email).IsRequired();

                entity.Property(e => e.EmergencyContactNumber).HasMaxLength(50);

                entity.Property(e => e.FirstName).IsRequired();

                entity.Property(e => e.HighestQualification).IsRequired();

                entity.Property(e => e.LastName).IsRequired();

                entity.Property(e => e.MaritalStatus)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.MiddleName).IsRequired();

                entity.Property(e => e.PermanentAddress).IsRequired();

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.UpdatedDateInt)
                    .HasMaxLength(4000)
                    .HasComputedColumnSql("(format([UpdatedDate],'yyyyMMddHHmmssffff'))", false);

                entity.Property(e => e.WhatsAppNumber).HasMaxLength(50);
            });

            modelBuilder.Entity<Placement>(entity =>
            {
                entity.ToTable("Placement", "dbo");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedDateInt)
                    .HasMaxLength(4000)
                    .HasComputedColumnSql("(format([CreatedDate],'yyyyMMddHHmmssffff'))", false);

                entity.Property(e => e.PlacementDate).HasColumnType("datetime");

                entity.Property(e => e.StudentName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.StudentPic).IsRequired();

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.UpdatedDateInt)
                    .HasMaxLength(4000)
                    .HasComputedColumnSql("(format([CreatedDate],'yyyyMMddHHmmssffff'))", false);
            });

            modelBuilder.Entity<PlacementDetail>(entity =>
            {
                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedDateInt)
                    .HasMaxLength(4000)
                    .HasComputedColumnSql("(format([CreatedDate],'yyyyMMddHHmmssffff'))", false);

                entity.Property(e => e.HigestPackage)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("higestPackage");

                entity.Property(e => e.LowestPackage)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("lowestPackage");

                entity.Property(e => e.NoOfCompany).HasColumnName("noOfCompany");

                entity.Property(e => e.NumberofRegisterdStudent).HasColumnName("numberofRegisterdStudent");

                entity.Property(e => e.PlacedStudent).HasColumnName("placedStudent");

                entity.Property(e => e.TotalStudent).HasColumnName("totalStudent");

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.UpdatedDateInt)
                    .HasMaxLength(4000)
                    .HasComputedColumnSql("(format([UpdatedDate],'yyyyMMddHHmmssffff'))", false);
            });

            modelBuilder.Entity<Portfolio>(entity =>
            {
                entity.ToTable("Portfolios", "dbo");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedDateInt)
                    .HasMaxLength(4000)
                    .HasComputedColumnSql("(format([CreatedDate],'yyyyMMddHHmmssffff'))", false);

                entity.Property(e => e.Description).IsRequired();

                entity.Property(e => e.Level).HasMaxLength(50);

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.UpdatedDateInt)
                    .HasMaxLength(4000)
                    .HasComputedColumnSql("(format([CreatedDate],'yyyyMMddHHmmssffff'))", false);
            });

            modelBuilder.Entity<Publication>(entity =>
            {
                entity.ToTable("Publications", "dbo");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedDateInt)
                    .HasMaxLength(4000)
                    .HasComputedColumnSql("(format([CreatedDate],'yyyyMMddHHmmssffff'))", false);

                entity.Property(e => e.Description).IsRequired();

                entity.Property(e => e.Link).HasMaxLength(50);

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.UpdatedDateInt)
                    .HasMaxLength(4000)
                    .HasComputedColumnSql("(format([CreatedDate],'yyyyMMddHHmmssffff'))", false);
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.ToTable("Role", "dbo");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedDateInt)
                    .HasMaxLength(4000)
                    .HasComputedColumnSql("(format([CreatedDate],'yyyyMMddHHmmssffff'))", false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.UpdatedDateInt)
                    .HasMaxLength(4000)
                    .HasComputedColumnSql("(format([CreatedDate],'yyyyMMddHHmmssffff'))", false);
            });

            modelBuilder.Entity<SsipProject>(entity =>
            {
                entity.ToTable("SsipProjects", "dbo");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedDateInt)
                    .HasMaxLength(4000)
                    .HasComputedColumnSql("(format([CreatedDate],'yyyyMMddHHmmssffff'))", false);

                entity.Property(e => e.Description).IsRequired();

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.UpdatedDateInt)
                    .HasMaxLength(4000)
                    .HasComputedColumnSql("(format([CreatedDate],'yyyyMMddHHmmssffff'))", false);
            });

            modelBuilder.Entity<Subject>(entity =>
            {
                entity.ToTable("Subject", "dbo");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Acronym).IsRequired();

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedDateInt)
                    .HasMaxLength(4000)
                    .HasComputedColumnSql("(format([CreatedDate],'yyyyMMddHHmmssffff'))", false);

                entity.Property(e => e.Department).IsRequired();

                entity.Property(e => e.Subject1).IsRequired();

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.UpdatedDateInt)
                    .HasMaxLength(4000)
                    .HasComputedColumnSql("(format([UpdatedDate],'yyyyMMddHHmmssffff'))", false);
            });

            modelBuilder.Entity<Tag>(entity =>
            {
                entity.ToTable("Tags", "dbo");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedDateInt)
                    .HasMaxLength(4000)
                    .HasComputedColumnSql("(format([CreatedDate],'yyyyMMddHHmmssffff'))", false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.UpdatedDateInt)
                    .HasMaxLength(4000)
                    .HasComputedColumnSql("(format([CreatedDate],'yyyyMMddHHmmssffff'))", false);
            });

            modelBuilder.Entity<Tender>(entity =>
            {
                entity.ToTable("Tenders", "dbo");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedDateInt)
                    .HasMaxLength(4000)
                    .HasComputedColumnSql("(format([CreatedDate],'yyyyMMddHHmmssffff'))", false);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Description).IsRequired();

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.UpdatedDateInt)
                    .HasMaxLength(4000)
                    .HasComputedColumnSql("(format([CreatedDate],'yyyyMMddHHmmssffff'))", false);
            });

            modelBuilder.Entity<UsersDetail>(entity =>
            {
                entity.ToTable("UsersDetail", "dbo");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedDateInt)
                    .HasMaxLength(4000)
                    .HasComputedColumnSql("(format([CreatedDate],'yyyyMMddHHmmssffff'))", false);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnName("password");

                entity.Property(e => e.Role)
                    .HasMaxLength(50)
                    .HasColumnName("role");

                entity.Property(e => e.SaltKey)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("saltKey");

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.UpdatedDateInt)
                    .HasMaxLength(4000)
                    .HasComputedColumnSql("(format([UpdatedDate],'yyyyMMddHHmmssffff'))", false);

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("username");
            });

            modelBuilder.Entity<Vision>(entity =>
            {
                entity.ToTable("Vision", "dbo");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedDateInt)
                    .HasMaxLength(4000)
                    .HasComputedColumnSql("(format([CreatedDate],'yyyyMMddHHmmssffff'))", false);

                entity.Property(e => e.Description).IsRequired();

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.UpdatedDateInt)
                    .HasMaxLength(4000)
                    .HasComputedColumnSql("(format([CreatedDate],'yyyyMMddHHmmssffff'))", false);
            });

            modelBuilder.Entity<WorkExperience>(entity =>
            {
                entity.ToTable("WorkExperience", "dbo");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedDateInt)
                    .HasMaxLength(4000)
                    .HasComputedColumnSql("(format([CreatedDate],'yyyyMMddHHmmssffff'))", false);

                entity.Property(e => e.Designation)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Expertise)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.FromDate).HasColumnType("datetime");

                entity.Property(e => e.FromDateInt)
                    .HasMaxLength(4000)
                    .HasComputedColumnSql("(format([CreatedDate],'yyyyMMddHHmmssffff'))", false);

                entity.Property(e => e.Organization)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ToDate).HasColumnType("datetime");

                entity.Property(e => e.ToDateInt)
                    .HasMaxLength(4000)
                    .HasComputedColumnSql("(format([CreatedDate],'yyyyMMddHHmmssffff'))", false);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.UpdatedDateInt)
                    .HasMaxLength(4000)
                    .HasComputedColumnSql("(format([CreatedDate],'yyyyMMddHHmmssffff'))", false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
