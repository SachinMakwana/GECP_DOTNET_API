using System;
using System.Collections.Generic;

#nullable disable

namespace GECP_DOT_NET_API.Database
{
    public partial class PlacementDetail
    {
        public int Id { get; set; }
        public int DeptId { get; set; }
        public DateTime PlacementYear { get; set; }
        public int NumberofRegisterdStudent { get; set; }
        public int PlacedStudent { get; set; }
        public int TotalStudent { get; set; }
        public int NoOfCompany { get; set; }
        public decimal HigestPackage { get; set; }
        public decimal LowestPackage { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedDateInt { get; set; }
        public DateTime UpdatedDate { get; set; }
        public string UpdatedDateInt { get; set; }
    }
}
