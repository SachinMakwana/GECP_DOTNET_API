using GECP_DOT_NET_API.Helper;
using GECP_DOT_NET_API.Models;
using System;
using System.Collections.Generic;

namespace GECP_DOT_NET_API.Repository
{
    public interface ICompanyRepo
    {
        public ServiceResponse<List<CompanyVM>> GetAllCompanyDetails();
        public ServiceResponse<bool> AddCompanyDetail(CompanyVM companyVM);
        public ServiceResponse<bool> DeleteCompanyDetail(CompanyVM companyVM);
        public ServiceResponse<bool> UpdateCompanyDetail(CompanyVM companyVM);
    }
}
