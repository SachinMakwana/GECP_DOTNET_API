using System;
using System.Collections.Generic;

#nullable disable

namespace GECP_DOT_NET_API.Database
{
    public partial class UsersDetail
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedDateInt { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedDateInt { get; set; }
        public bool? IsDeleted { get; set; }
    }
}
