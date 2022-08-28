﻿using System;
namespace GECP_DOT_NET_API.Models
{
    public class LabWorkshopVM
    {
        public int Id { get; set; }
        public int DeptId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public bool? IsDeleted { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedDateInt { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedDateInt { get; set; }
    }
}