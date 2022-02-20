using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using System;
using GECP_DOT_NET_API.Database;
using GECP_DOT_NET_API.Models;

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

        

        public async Task<ServiceResponse<List<FacultyDetail>>> GetAllFaculty()
        {
            ServiceResponse<List<FacultyDetail>> serviceResponse = new ServiceResponse<List<FacultyDetail>>();
            try
            {
                using (_adminContext = new GECP_ADMINContext())
                {
                    serviceResponse.Data = _adminContext.FacultyDetails.Select(c => _mapper.Map<FacultyDetail>(c)).ToList();
                    return serviceResponse;
                };
            }catch(Exception ex)
            {
                return serviceResponse;
            }
        }

        public async Task<ServiceResponse<List<FacultyDetail>>> AddFaculty(FacultyDetail newFaculty)
        {
            ServiceResponse<List<FacultyDetail>> serviceResponse = new ServiceResponse<List<FacultyDetail>>();
            try
            {
                using (_adminContext = new GECP_ADMINContext())
                {
                    _adminContext.Add(_mapper.Map<FacultyDetail>(newFaculty));
                    serviceResponse.Data = _adminContext.FacultyDetails.Select(c => _mapper.Map<FacultyDetail>(c)).ToList();
                    return serviceResponse;
                };
            }
            catch (Exception ex)
            {
                return serviceResponse;
            }
        }

        public async Task<ServiceResponse<List<FacultyDetail>>> DeleteFaculty(int id)
        {
            var serviceResponse = new ServiceResponse<List<FacultyDetail>>();
            try
            {
                using (_adminContext = new GECP_ADMINContext())
                {
                    //Faculty faculty = FacultyDetail.First(c => c.Id == id);
                    //faculty.IsDeleted = true;
                    serviceResponse.Data = _adminContext.FacultyDetails.Select(c => _mapper.Map<FacultyDetail>(c)).ToList();
                }
            }
            catch (Exception ex)
            {
                serviceResponse.Success = false;
                serviceResponse.Message = ex.Message;
            }
            return serviceResponse;
        }
        public async Task<ServiceResponse<FacultyDetail>> UpdateFaculty(FacultyDetail updatedFaculty)
        {
            var serviceResponse = new ServiceResponse<FacultyDetail>();
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
