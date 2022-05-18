using GECP_DOT_NET_API.Helper;
using GECP_DOT_NET_API.Models;
using System;
using System.Collections.Generic;

namespace GECP_DOT_NET_API.Repository
{
    public interface IPortfolioRepo
    {
        public ServiceResponse<List<PortfolioVM>> GetAllPortfolioDetails();

        public ServiceResponse<bool> AddPortfolioDetail(PortfolioVM portfolioVM);

        public ServiceResponse<bool> UpdatePortfolioDetail(PortfolioVM portfolioVM);

        public ServiceResponse<bool> DeletePortfolioDetail(PortfolioVM portfolioVM);
    }
}
