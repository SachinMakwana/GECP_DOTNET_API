using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using System;
using GECP_DOT_NET_API.Dtos.Faculty;
using GECP_DOT_NET_API.Models;
using GECP_DOT_NET_API.Database;

namespace GECP_DOT_NET_API.Repository.FacultyRepository
{
    public class FacultyServices : IFaculty
    {
        GECP_ADMINContext _adminContext;
        //private static List<Faculty> FacultyDetail = new List<Faculty>
        //{
          //  new Faculty(),
          //  new Faculty{ Id= 4, Name = "Ojas" }
        //};

        private readonly IMapper _mapper;
        public FacultyServices(IMapper mapper)
        {
            _mapper = mapper;
        }

        

        public async Task<ServiceResponse<List<Faculty>>> GetAllFaculty()
        {
            ServiceResponse<List<Faculty>> serviceResponse = new ServiceResponse<List<Faculty>>();
            try
            {
                using (_adminContext = new GECP_ADMINContext())
                {
                    serviceResponse.Data = _adminContext.FacultyDetails.Select(c => _mapper.Map<Faculty>(c)).ToList();
                    return serviceResponse;
                };
            }catch(Exception ex)
            {
                return serviceResponse;
            }
        }

        public async Task<ServiceResponse<List<Faculty>>> AddFaculty(Faculty newFaculty)
        {
            ServiceResponse<List<Faculty>> serviceResponse = new ServiceResponse<List<Faculty>>();
            try
            {
                using (_adminContext = new GECP_ADMINContext())
                {
                    _adminContext.Add(_mapper.Map<Faculty>(newFaculty));
                    serviceResponse.Data = _adminContext.FacultyDetails.Select(c => _mapper.Map<Faculty>(c)).ToList();
                    return serviceResponse;
                };
            }
            catch (Exception ex)
            {
                return serviceResponse;
            }
        }

        public async Task<ServiceResponse<List<Faculty>>> DeleteFaculty(int id)
        {
            var serviceResponse = new ServiceResponse<List<Faculty>>();
            try
            {
                using (_adminContext = new GECP_ADMINContext())
                {
                    //Faculty faculty = FacultyDetail.First(c => c.Id == id);
                    //faculty.IsDeleted = true;
                    serviceResponse.Data = _adminContext.FacultyDetails.Select(c => _mapper.Map<Faculty>(c)).ToList();
                }
            }
            catch (Exception ex)
            {
                serviceResponse.Success = false;
                serviceResponse.Message = ex.Message;
            }
            return serviceResponse;
        }
        public async Task<ServiceResponse<Faculty>> UpdateFaculty(Faculty updatedFaculty)
        {
            var serviceResponse = new ServiceResponse<Faculty>();
            try
            {
                //Faculty faculty = FacultyDetail.FirstOrDefault(c => c.Id == updatedFaculty.Id);

                //faculty.Name = updatedFaculty.Name;
                //faculty.DeptId = updatedFaculty.DeptId;
                //faculty.DesignationId = updatedFaculty.DesignationId;
                //faculty.IsDeleted = updatedFaculty.IsDeleted;
                //faculty.UpdatedDate = updatedFaculty.UpdatedDate;

                //serviceResponse.Data = _mapper.Map<Faculty>(faculty);
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
