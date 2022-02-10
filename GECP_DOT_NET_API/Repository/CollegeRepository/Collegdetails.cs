using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using System;
using GECP_DOT_NET_API.Models;

namespace GECP_DOT_NET_API.Repository.CollegeRepository
{
    public class Collegdetails : ICollege
    {
        private static List<CollegeVM> College = new List<CollegeVM>
        {
            new CollegeVM(),
            new CollegeVM{ Id= 4, Name = "Ojas" }
        };

        private readonly IMapper _mapper;
        public Collegdetails(IMapper mapper)
        {
            _mapper = mapper;
        }

        public async Task<ServiceResponse<List<CollegeVM>>> GetAllCollege()
        {
            var serviceResponse = new ServiceResponse<List<CollegeVM>>();
            serviceResponse.Data = College.Select(c => _mapper.Map<CollegeVM>(c)).ToList();
            return serviceResponse;
        }

        public async Task<ServiceResponse<CollegeVM>> UpdateCollege(CollegeVM updatedCollegeVM)
        {
            var serviceResponse = new ServiceResponse<CollegeVM>();
            try
            {
              CollegeVM college = College.FirstOrDefault(c => c.Id == updatedCollegeVM.Id);

                college.Name = updatedCollegeVM.Name;
                college.Principal = updatedCollegeVM.Principal;
                college.PrincipalMessage = updatedCollegeVM.PrincipalMessage;
                college.Description = updatedCollegeVM.Description;
                college.Address = updatedCollegeVM.Address;
                college.Phone = updatedCollegeVM.Phone;
                college.Image = updatedCollegeVM.Image;
                college.Email = updatedCollegeVM.Email;
                college.IsDeleted = updatedCollegeVM.IsDeleted;
                college.UpdatedDate = updatedCollegeVM.UpdatedDate;

                serviceResponse.Data = _mapper.Map<CollegeVM>(college);
            }
            catch (Exception ex)
            {
                serviceResponse.Success = false;
                serviceResponse.Message = ex.Message;
            }
            return serviceResponse;
        }
    }
}