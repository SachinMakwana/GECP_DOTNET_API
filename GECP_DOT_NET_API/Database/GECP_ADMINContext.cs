using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace GECP_DOT_NET_API.Database
{
    public partial class GECP_ADMINContext : DbContext
    {
        public GECP_ADMINContext()
        {
        }

        public GECP_ADMINContext(DbContextOptions<GECP_ADMINContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Achievement> Achievements { get; set; }
        public virtual DbSet<Affiliation> Affiliations { get; set; }
        public virtual DbSet<Attachment> Attachments { get; set; }
        public virtual DbSet<BackendMenu> BackendMenus { get; set; }
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
        public virtual DbSet<LabWorkshopDetail> LabWorkshopDetails { get; set; }
        public virtual DbSet<MediaLink> MediaLinks { get; set; }
        public virtual DbSet<MenuItem> MenuItems { get; set; }
        public virtual DbSet<MicroLog> MicroLogs { get; set; }
        public virtual DbSet<MiniLog> MiniLogs { get; set; }
        public virtual DbSet<Mission> Missions { get; set; }
        public virtual DbSet<News> News { get; set; }
        public virtual DbSet<ParentItem> ParentItems { get; set; }
        public virtual DbSet<Placement> Placements { get; set; }
        public virtual DbSet<Portfolio> Portfolios { get; set; }
        public virtual DbSet<Publication> Publications { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<SsipProject> SsipProjects { get; set; }
        public virtual DbSet<Tag> Tags { get; set; }
        public virtual DbSet<Tender> Tenders { get; set; }
        public virtual DbSet<Vision> Visions { get; set; }
        public virtual DbSet<WorkExperience> WorkExperiences { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-73J8JS4\\SQLEXPRESS;Initial Catalog=GECP_ADMIN;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Latin1_General_CI_AI");

            modelBuilder.Entity<Achievement>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedDateInt)
                    .HasMaxLength(4000)
                    .HasComputedColumnSql("(format([CreatedDate],'yyyyMMddHHmmssffff'))", false);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Image).HasMaxLength(50);

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
                entity.ToTable("Affiliation");

                entity.Property(e => e.Id).ValueGeneratedNever();

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
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Attachment1)
                    .IsRequired()
                    .HasMaxLength(50)
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
                entity.ToTable("BackendMenu");

                entity.Property(e => e.Id).ValueGeneratedNever();

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

            modelBuilder.Entity<Circular>(entity =>
            {
                entity.ToTable("Circular");

                entity.Property(e => e.Id).ValueGeneratedNever();

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
                entity.ToTable("College");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Address).IsRequired();

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedDateInt)
                    .HasMaxLength(4000)
                    .HasComputedColumnSql("(format([CreatedDate],'yyyyMMddHHmmssffff'))", false);

                entity.Property(e => e.Description).IsRequired();

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Image)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PrincipalMessage).IsRequired();

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.UpdatedDateInt)
                    .HasMaxLength(4000)
                    .HasComputedColumnSql("(format([CreatedDate],'yyyyMMddHHmmssffff'))", false);
            });

            modelBuilder.Entity<Committee>(entity =>
            {
                entity.ToTable("Committee");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedDateInt)
                    .HasMaxLength(4000)
                    .HasComputedColumnSql("(format([CreatedDate],'yyyyMMddHHmmssffff'))", false);

                entity.Property(e => e.Description).IsRequired();

                entity.Property(e => e.Image)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Slogan)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.UpdatedDateInt)
                    .HasMaxLength(4000)
                    .HasComputedColumnSql("(format([CreatedDate],'yyyyMMddHHmmssffff'))", false);
            });

            modelBuilder.Entity<CommitteeMember>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

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
                entity.ToTable("Company");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedDateInt)
                    .HasMaxLength(4000)
                    .HasComputedColumnSql("(format([CreatedDate],'yyyyMMddHHmmssffff'))", false);

                entity.Property(e => e.Description).IsRequired();

                entity.Property(e => e.Image)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Logo)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.RelevantDepartments).IsRequired();

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.UpdatedDateInt)
                    .HasMaxLength(4000)
                    .HasComputedColumnSql("(format([CreatedDate],'yyyyMMddHHmmssffff'))", false);
            });

            modelBuilder.Entity<Department>(entity =>
            {
                entity.ToTable("Department");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedDateInt)
                    .HasMaxLength(4000)
                    .HasComputedColumnSql("(format([CreatedDate],'yyyyMMddHHmmssffff'))", false);

                entity.Property(e => e.Description).IsRequired();

                entity.Property(e => e.Image)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Message).IsRequired();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Slogan)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.UpdatedDateInt)
                    .HasMaxLength(4000)
                    .HasComputedColumnSql("(format([CreatedDate],'yyyyMMddHHmmssffff'))", false);
            });

            modelBuilder.Entity<DepartmentAmenty>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

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
                entity.Property(e => e.Id).ValueGeneratedNever();

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
                entity.ToTable("DynamicPage");

                entity.Property(e => e.Id).ValueGeneratedNever();

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
                entity.Property(e => e.Id).ValueGeneratedNever();

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
                entity.ToTable("ExternalFacultyDetail");

                entity.Property(e => e.Id).ValueGeneratedNever();

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
                entity.ToTable("FacultyDetail");

                entity.Property(e => e.Id).ValueGeneratedNever();

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

            modelBuilder.Entity<FrontendMenu>(entity =>
            {
                entity.ToTable("FrontendMenu");

                entity.Property(e => e.Id).ValueGeneratedNever();

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
                entity.ToTable("Gallery");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedDateInt)
                    .HasMaxLength(4000)
                    .HasComputedColumnSql("(format([CreatedDate],'yyyyMMddHHmmssffff'))", false);

                entity.Property(e => e.Extension)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Image)
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

            modelBuilder.Entity<GalleryTag>(entity =>
            {
                entity.ToTable("GalleryTag");

                entity.Property(e => e.Id).ValueGeneratedNever();

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
                entity.ToTable("GeneralLog");

                entity.Property(e => e.Id).ValueGeneratedNever();

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

            modelBuilder.Entity<LabWorkshopDetail>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedDateInt)
                    .HasMaxLength(4000)
                    .HasComputedColumnSql("(format([CreatedDate],'yyyyMMddHHmmssffff'))", false);

                entity.Property(e => e.Description).IsRequired();

                entity.Property(e => e.Image)
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

            modelBuilder.Entity<MediaLink>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

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
                entity.Property(e => e.Id).ValueGeneratedNever();

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
                entity.ToTable("MicroLog");

                entity.Property(e => e.Id).ValueGeneratedNever();

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
                entity.ToTable("MiniLog");

                entity.Property(e => e.Id).ValueGeneratedNever();

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
                entity.ToTable("Mission");

                entity.Property(e => e.Id).ValueGeneratedNever();

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
                entity.Property(e => e.Id).ValueGeneratedNever();

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
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedDateInt)
                    .HasMaxLength(4000)
                    .HasComputedColumnSql("(format([CreatedDate],'yyyyMMddHHmmssffff'))", false);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.UpdatedDateInt)
                    .HasMaxLength(4000)
                    .HasComputedColumnSql("(format([CreatedDate],'yyyyMMddHHmmssffff'))", false);
            });

            modelBuilder.Entity<Placement>(entity =>
            {
                entity.ToTable("Placement");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedDateInt)
                    .HasMaxLength(4000)
                    .HasComputedColumnSql("(format([CreatedDate],'yyyyMMddHHmmssffff'))", false);

                entity.Property(e => e.PlacementDate).HasColumnType("datetime");

                entity.Property(e => e.StudentName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.StudentPic)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.UpdatedDateInt)
                    .HasMaxLength(4000)
                    .HasComputedColumnSql("(format([CreatedDate],'yyyyMMddHHmmssffff'))", false);
            });

            modelBuilder.Entity<Portfolio>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

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
                entity.Property(e => e.Id).ValueGeneratedNever();

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
                entity.ToTable("Role");

                entity.Property(e => e.Id).ValueGeneratedNever();

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
                entity.Property(e => e.Id).ValueGeneratedNever();

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

            modelBuilder.Entity<Tag>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

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
                entity.Property(e => e.Id).ValueGeneratedNever();

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

            modelBuilder.Entity<Vision>(entity =>
            {
                entity.ToTable("Vision");

                entity.Property(e => e.Id).ValueGeneratedNever();

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
                entity.ToTable("WorkExperience");

                entity.Property(e => e.Id).ValueGeneratedNever();

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
