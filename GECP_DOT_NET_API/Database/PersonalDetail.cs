using System;
using System.Collections.Generic;

#nullable disable

namespace GECP_DOT_NET_API.Database
{
    public partial class PersonalDetail
    {
        public int Id { get; set; }
        public int FacultyId { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public DateTime Dob { get; set; }
        public string MaritalStatus { get; set; }
        public string CurrentAddress { get; set; }
        public string PermanentAddress { get; set; }
        public string ContactNumber { get; set; }
        public string WhatsAppNumber { get; set; }
        public string EmergencyContactNumber { get; set; }
        public string Email { get; set; }
        public string HighestQualification { get; set; }
        public string AreaOfSpecialization { get; set; }
        public int TeachingExperience { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedDateInt { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedDateInt { get; set; }
        public bool? IsDeleted { get; set; }
    }
}
