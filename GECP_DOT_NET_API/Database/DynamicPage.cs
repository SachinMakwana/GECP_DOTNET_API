﻿using System;
using System.Collections.Generic;

#nullable disable

namespace GECP_DOT_NET_API.Database
{
    public partial class DynamicPage
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool? IsDeleted { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedDateInt { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedDateInt { get; set; }
    }
}
