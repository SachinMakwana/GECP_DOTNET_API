using AutoMapper;
using GECP_DOT_NET_API.Database;

namespace GECP_DOT_NET_API.Repository.Committee
{
    public class CommitteeServices : ICommittee
    {
        GECP_ADMINContext _adminContext;

        private readonly IMapper _mapper;
        public Committee(IMapper mapper)
        {
            _mapper = mapper;
        }
    }
}
