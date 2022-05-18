using GECP_DOT_NET_API.Helper;
using GECP_DOT_NET_API.Models;
using System;
using System.Collections.Generic;

namespace GECP_DOT_NET_API.Repository
{
    public interface IPublicationRepo
    {
        public ServiceResponse<List<PublicationVM>> GetAllPublicationDetails();
        public ServiceResponse<bool> AddPublicationDetail(PublicationVM publicationVM);
        public ServiceResponse<bool> UpdatePublicationDetail(PublicationVM publicationVM);
        public ServiceResponse<bool> DeletePublicationDetail(PublicationVM publicationVM);
    }
}
