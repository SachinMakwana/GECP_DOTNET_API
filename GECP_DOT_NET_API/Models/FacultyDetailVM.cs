using System;

namespace GECP_DOT_NET_API.Models
{
    public class FacultyDetailVM
    {
        public int Id { get; set; } = 1;
        public string Name { get; set; } = "Aditya";
        public int DeptId { get; set; } = 300;
        public int DesignationId { get; set; } = 10;
        public bool? IsDeleted { get; set; } = false;
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public string CreatedDateInt { get; set; }
        public DateTime? UpdatedDate { get; set; } = DateTime.Now;
        public string UpdatedDateInt { get; set; }
    }
}
