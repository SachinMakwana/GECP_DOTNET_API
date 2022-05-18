using GECP_DOT_NET_API.Helper;
using GECP_DOT_NET_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace GECP_DOT_NET_API.Repository
{
    public interface ITender
    {
        public ServiceResponse<List<TenderVM>> GetTenderDetails();
        public ServiceResponse<bool> AddTenderDetail(TenderVM tenderVM);
        public ServiceResponse<bool> UpdateTenderDetail(TenderVM tenderVM);
        public ServiceResponse<bool> DeleteTenderDetail(TenderVM tenderVM);

    }
}
