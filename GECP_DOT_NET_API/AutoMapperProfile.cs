using AutoMapper;
using GECP_DOT_NET_API.Dtos.Faculty;
using GECP_DOT_NET_API.Models;

namespace GECP_DOT_NET_API
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<FacultyDetailVM, GetFacultyDto>();
            CreateMap<AddFacultyDto, FacultyDetailVM>();
        }
    }
}
