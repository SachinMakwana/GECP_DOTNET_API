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

        public ServiceResponse<List<FacultyDetailVM>> GetAllFaculty()
        {
            ServiceResponse<List<FacultyDetailVM>> serviceResponse = new ServiceResponse<List<FacultyDetailVM>>();
            try
            {
                using (_adminContext = new GECP_ADMINContext())
                {
                    serviceResponse.Data = _adminContext.FacultyDetails.Select(c => _mapper.Map<FacultyDetailVM>(c)).ToList();
                    return serviceResponse;
                };
            }
            catch (Exception ex)
            {
                 return serviceResponse;
            } 
        }

        public ServiceResponse<List<FacultyDetailVM>> AddFaculty(FacultyDetailVM newFaculty)
        {
            ServiceResponse<List<FacultyDetailVM>> serviceResponse = new ServiceResponse<List<FacultyDetailVM>>();
            try
            {
                using (_adminContext = new GECP_ADMINContext())
                {

                    _adminContext.Add(_mapper.Map<FacultyDetail>(newFaculty));
                    serviceResponse.Data = _adminContext.FacultyDetails.Select(c => _mapper.Map<FacultyDetailVM>(c)).ToList();
                    return serviceResponse;
                };
            }
            catch (Exception ex)
            {
                return serviceResponse;
            }
        }

        public ServiceResponse<List<FacultyDetailVM>> DeleteFaculty(int id)
        {
            var serviceResponse = new ServiceResponse<List<FacultyDetailVM>>();
            try
            {
                using (_adminContext = new GECP_ADMINContext())
                {
                    //Faculty faculty = FacultyDetail.First(c => c.Id == id);
                    //faculty.IsDeleted = true;
                    serviceResponse.Data = _adminContext.FacultyDetails.Select(c => _mapper.Map<FacultyDetailVM>(c)).ToList();
                }
            }
            catch (Exception ex)
            {
                serviceResponse.Success = false;
                serviceResponse.Message = ex.Message;
            }
            return serviceResponse;
        }
        public ServiceResponse<FacultyDetailVM> UpdateFaculty(FacultyDetailVM updatedFaculty)
        {
            var serviceResponse = new ServiceResponse<FacultyDetailVM>();
            try
            {
                using (_adminContext = new GECP_ADMINContext())
                {
                    var faculty = _adminContext.FacultyDetails.FirstOrDefault(c => c.Id == updatedFaculty.Id);

                    faculty.Name = updatedFaculty.Name;
                    faculty.DeptId = updatedFaculty.DeptId;
                    faculty.DesignationId = updatedFaculty.DesignationId;
                    faculty.IsDeleted = updatedFaculty.IsDeleted;
                    faculty.UpdatedDate = updatedFaculty.UpdatedDate;

                    serviceResponse.Data = _mapper.Map<FacultyDetailVM>(faculty);
                }
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
