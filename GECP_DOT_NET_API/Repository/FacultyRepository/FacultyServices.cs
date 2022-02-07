using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using System;
using GECP_DOT_NET_API.Dtos.Faculty;
using GECP_DOT_NET_API.Models;


namespace GECP_DOT_NET_API.Repository.FacultyRepository
{
    public class FacultyServices : IFaculty
    {
        private static List<Faculty> FacultyDetail = new List<Faculty>
        {
            new Faculty(),
            new Faculty{ Id= 4, Name = "Ojas" }
        };

        private readonly IMapper _mapper;
        public FacultyServices(IMapper mapper)
        {
            _mapper = mapper;
        }

        public async Task<ServiceResponse<List<GetFacultyDto>>> AddFaculty(AddFacultyDto newFaculty)
        {
            var serviceResponse = new ServiceResponse<List<GetFacultyDto>>();
            FacultyDetail.Add(_mapper.Map<Faculty>(newFaculty));
            serviceResponse.Data = FacultyDetail.Select(c => _mapper.Map<GetFacultyDto>(c)).ToList();
            return serviceResponse;
        }

        public async Task<ServiceResponse<List<GetFacultyDto>>> DeleteFaculty(int id)
        {
            var serviceResponse = new ServiceResponse<List<GetFacultyDto>>();
            try
            {
                Faculty faculty = FacultyDetail.First(c => c.Id == id);
                faculty.IsDeleted = true;
                serviceResponse.Data = FacultyDetail.Select(c => _mapper.Map<GetFacultyDto>(c)).ToList();
            }
            catch (Exception ex)
            {
                serviceResponse.Success = false;
                serviceResponse.Message = ex.Message;
            }
            return serviceResponse;
        }

        public async Task<ServiceResponse<List<GetFacultyDto>>> GetAllFaculty()
        {
            var serviceResponse = new ServiceResponse<List<GetFacultyDto>>();
            serviceResponse.Data = FacultyDetail.Select(c => _mapper.Map<GetFacultyDto>(c)).ToList();
            return serviceResponse;
        }

        public async Task<ServiceResponse<GetFacultyDto>> UpdateFaculty(UpdateFacultyDto updatedFaculty)
        {
            var serviceResponse = new ServiceResponse<GetFacultyDto>();
            try
            {
                Faculty faculty = FacultyDetail.FirstOrDefault(c => c.Id == updatedFaculty.Id);

                faculty.Name = updatedFaculty.Name;
                faculty.DeptId = updatedFaculty.DeptId;
                faculty.DesignationId = updatedFaculty.DesignationId;
                faculty.IsDeleted = updatedFaculty.IsDeleted;
                faculty.UpdatedDate = updatedFaculty.UpdatedDate;

                serviceResponse.Data = _mapper.Map<GetFacultyDto>(faculty);
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
