using System;
using System.Collections.Generic;

#nullable disable

namespace GECP_DOT_NET_API.Database
{
    public partial class DepartmentAmenty
    {
        public int Id { get; set; }
        public int DeptId { get; set; }
        public int Intake { get; set; }
        public int Subjects { get; set; }
        public int Labs { get; set; }
        public int Workshop { get; set; }
        public int Classroom { get; set; }
        public int Seminar { get; set; }
        public bool? IsDeleted { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedDateInt { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedDateInt { get; set; }
    }
}
