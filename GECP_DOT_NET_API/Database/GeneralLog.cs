using System;
using System.Collections.Generic;

#nullable disable

namespace GECP_DOT_NET_API.Database
{
    public partial class GeneralLog
    {
        public int Id { get; set; }
        public string Event { get; set; }
        public int CreatedBy { get; set; }
        public string Ipaddress { get; set; }
        public string Device { get; set; }
        public string Region { get; set; }
        public bool? IsDeleted { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedDateInt { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedDateInt { get; set; }
    }
}
