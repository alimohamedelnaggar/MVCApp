using AutoMapper;
using Demo.DAL.Models;
using Demo.Presentation.ViewModels;

namespace Demo.Presentation.Helper
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<EmpViewModel,Employee>().ReverseMap();
        }
    }
}
