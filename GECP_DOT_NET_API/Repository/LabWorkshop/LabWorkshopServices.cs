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

        private static List<LabWorkshopDetail> LabWorkshopDetail = new List<LabWorkshopDetail>
        {
            new LabWorkshopDetail(),
            new LabWorkshopDetail{ Id= 4, Name = "Ojas" }
        };

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
                    LabWorkshopDetail.Add(_mapper.Map<LabWorkshopDetail>(labWorkshop));
                    serviceResponse.Data = _adminContext.LabWorkshopDetails.Select(c => _mapper.Map<LabWorkshopDetail>(c)).ToList();
                    return serviceResponse;
                };
            }
            catch (Exception ex)
            {
                return serviceResponse;
            }
        }

    }
}