using System;
using System.Collections.Generic;

#nullable disable

namespace GECP_DOT_NET_API.Database
{
    public partial class FacultyDetail
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int DeptId { get; set; }
        public int DesignationId { get; set; }
        public int? IsDeleted { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedDateInt { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int? UpdatedDateInt { get; set; }
    }
}
