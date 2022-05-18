using GECP_DOT_NET_API.Helper;
using GECP_DOT_NET_API.Models;
using System;
using System.Collections.Generic;

namespace GECP_DOT_NET_API.Repository
{
    public interface INewsRepo
    {
        public ServiceResponse<List<NewsVM>> GetAllNewsDetails();   
        public ServiceResponse<bool> AddNewsDetail(NewsVM newsVM);
        public ServiceResponse<bool> UpdateNewsDetail(NewsVM newsVM);
        public ServiceResponse<bool> DeleteNewsDetail(NewsVM newsVM);
    }
}
