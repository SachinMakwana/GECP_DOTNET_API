using GECP_DOT_NET_API.Helper;
using GECP_DOT_NET_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GECP_DOT_NET_API.Repository
{
    interface IGrievanceRepo
    {
        public ServiceResponse<IList<GrievanceWithStatusVM>> GetAllGrievances();

        public ServiceResponse<bool> AddGrievance(GrievanceVM grievanceVM);

        public ServiceResponse<bool> AddGrievanceStatus(GrievanceStatusVM grievanceStatusVM);
    }
}
