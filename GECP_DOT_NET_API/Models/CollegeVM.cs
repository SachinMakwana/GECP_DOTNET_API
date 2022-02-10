using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GECP_DOT_NET_API.Models
{
    public class CollegeVM
    {
        public int Id { get; set; } = 1;
        public string Name { get; set; } = "zeel";
        public int Principal { get; set; } = 12;
        public string PrincipalMessage { get; set; } = "hii";
        public string Description { get; set; } = "hello";
        public string Address { get; set; } = "gecp";
        public string Phone { get; set; } = "xx12";
        public string Image { get; set; } = "vsvshd";
        public string Email { get; set; } = "vbsvgsdv.com";
        public bool? IsDeleted { get; set; } = false;
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public string CreatedDateInt { get; set; }
        public DateTime? UpdatedDate { get; set; } = DateTime.Now;
        public string UpdatedDateInt { get; set; }
    }
}
