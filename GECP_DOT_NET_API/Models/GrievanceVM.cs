using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GECP_DOT_NET_API.Models
{
    public class GrievanceVM
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string EmailId { get; set; }
        public string Mobile { get; set; }
        public string Subject { get; set; }
        public string Description { get; set; }
        public string Attachments { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedDateInt { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedDateInt { get; set; }
    }

    public class GrievanceStatusVM
    {
        public long Id { get; set; }
        public long GrievanceId { get; set; }
        public int Status { get; set; }
        public string Description { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedDateInt { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedDateInt { get; set; }
    }

    public class GrievanceMasterVM
    {
        public GrievanceMasterVM()
        {
            grievanceStatusVMs = new List<GrievanceStatusVM>();
        }
        public GrievanceVM grievanceVM { get; set; }
        public IList<GrievanceStatusVM> grievanceStatusVMs { get; set; }
    }

    public class GrievanceWithStatusVM
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string EmailId { get; set; }
        public string Mobile { get; set; }
        public string Subject { get; set; }
        public int Status { get; set; }
        public string Description { get; set; }
        public string Attachments { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedDateInt { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedDateInt { get; set; }
    }
}
