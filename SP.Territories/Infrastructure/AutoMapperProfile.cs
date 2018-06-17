using AutoMapper;
using SP.DAL.Models;
using SP.DL.Models;
using Microsoft.AspNetCore.Identity;

namespace SP.Territories
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<GeoNameTxt, StateVM>()
                .ForMember(dest => dest.StateCode, opt => opt.MapFrom(c => c.statecode))
                .ForMember(dest => dest.StateName, opt => opt.MapFrom(c => c.statename));

            //.ForMember(am => am., opt => opt.Ignore());
        }
    }
}
