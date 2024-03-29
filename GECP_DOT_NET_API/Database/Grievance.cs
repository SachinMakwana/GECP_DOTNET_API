﻿using System;
using System.Collections.Generic;

#nullable disable

namespace GECP_DOT_NET_API.Database
{
    public partial class Grievance
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
}
