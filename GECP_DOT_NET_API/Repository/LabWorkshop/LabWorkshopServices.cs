using AutoMapper;
using GECP_DOT_NET_API.Database;
using GECP_DOT_NET_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GECP_DOT_NET_API.Repository.LabWorkshop
{
    public class LabWorkshopServices : ILabWorkshop
    {
        GECP_ADMINContext _adminContext;


        private readonly IMapper _mapper;

        public LabWorkshopServices(IMapper mapper)
        {
            _mapper = mapper;
        }
        public async Task<ServiceResponse<List<LabWorkshopDetail>>> GetAllLabWorkshop()
        {
            ServiceResponse<List<LabWorkshopDetail>> serviceResponse = new ServiceResponse<List<LabWorkshopDetail>>();
            try
            {
                using (_adminContext = new GECP_ADMINContext())
                {
                    
                    serviceResponse.Data = _adminContext.LabWorkshopDetails.Select(c => _mapper.Map<LabWorkshopDetail>(c)).ToList();
                    //serviceResponse.Data = LabWorkshopDetail.Select(c => _mapper.Map<LabWorkshopDetail>(c)).ToList();
                    return serviceResponse;
                };
            }
            catch (Exception ex)
            {
                return serviceResponse;
            }
        }

        public async Task<ServiceResponse<List<LabWorkshopDetail>>> AddLabWorkshop(LabWorkshopDetail labWorkshop)
        {
            ServiceResponse<List<LabWorkshopDetail>> serviceResponse = new ServiceResponse<List<LabWorkshopDetail>>();
            try
            {
                using (_adminContext = new GECP_ADMINContext())
                {
                    _adminContext.Add(_mapper.Map<LabWorkshopDetail>(labWorkshop));
                    serviceResponse.Data = _adminContext.LabWorkshopDetails.Select(c => _mapper.Map<LabWorkshopDetail>(c)).ToList();
                    return serviceResponse;
                };
            }
            catch (Exception ex)
            {
                return serviceResponse;
            }
        }

        public async Task<ServiceResponse<List<LabWorkshopDetail>>> EditLabWorkshop(LabWorkshopDetail labWorkshopDetail)
        {
            ServiceResponse<List<LabWorkshopDetail>> serviceResponse = new ServiceResponse<List<LabWorkshopDetail>>();
            try
            {
                using (_adminContext = new GECP_ADMINContext()) 
                {
                    LabWorkshopDetail labworkshop = _adminContext.LabWorkshopDetails.FirstOrDefault(c => c.Id == labWorkshopDetail.Id);

                    labworkshop.Name = labWorkshopDetail.Name;
                    labworkshop.DeptId = labWorkshopDetail.DeptId;
                    labworkshop.Description = labWorkshopDetail.Description;
                    labworkshop.Image = labWorkshopDetail.Image;
                    labworkshop.IsDeleted = labWorkshopDetail.IsDeleted;
                    labworkshop.UpdatedDate = labWorkshopDetail.UpdatedDate;

                    //serviceResponse.Data = _mapper.Map<LabWorkshopDetail>(labworkshop);
                    return serviceResponse;
                }
            }

            catch (Exception ex)
            {
                serviceResponse.Success = false;
                serviceResponse.Message = ex.Message;
                return serviceResponse;
            }
        }

        public Task<ServiceResponse<List<LabWorkshopDetail>>> DeleteLabWorkshop(int id)
        {
            ServiceResponse<List<LabWorkshopDetail>> serviceResponse = new ServiceResponse<List<LabWorkshopDetail>>();
            try
            {
                using (_adminContext = new GECP_ADMINContext())
                {
                    LabWorkshopDetail labWorkshop = _adminContext.LabWorkshopDetails.First(c => c.Id == id);
                    labWorkshop.IsDeleted = true;
                    serviceResponse.Data = _adminContext.LabWorkshopDetails.Select(c => _mapper.Map<LabWorkshopDetail>(c)).ToList();
                    return null;
                }
            }
            catch (Exception ex)
            {
                serviceResponse.Success = false;
                serviceResponse.Message = ex.Message;
                return null;
            }
        }
    }
}