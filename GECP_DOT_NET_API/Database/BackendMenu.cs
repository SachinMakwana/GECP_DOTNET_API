using System;
using System.Collections.Generic;

#nullable disable

namespace GECP_DOT_NET_API.Database
{
    public partial class BackendMenu
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ViewName { get; set; }
        public string ControllerName { get; set; }
        public int VerticalLevel { get; set; }
        public bool? IsDeleted { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedDateInt { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedDateInt { get; set; }
    }
}
