using AutoMapper;
using ECardManagment.ViewModel.Users;
using Newtonsoft.Json.Linq;
using Project.Framework.Helper;
using System.Collections.Generic;

namespace ECardManagment.Extensions.AutoMapper
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<JObject, ClaimVM>()
                .ForMember(dest => dest.Name, m => { m.MapFrom(jo => jo["Name"]); })
                .ForMember(dest => dest.AuthenticationType, m => { m.MapFrom(jo => jo["AuthenticationType"]); })
                .ForMember(dest => dest.IsAuthenticated, m => { m.MapFrom(jo => jo["IsAuthenticated"]); })
                .ForMember(dest => dest.NameClaimType, m => { m.MapFrom(jo => jo["NameClaimType"]); })
                .ForMember(dest => dest.RoleClaimType, m => { m.MapFrom(jo => jo["RoleClaimType"]); })
                .ForMember(dest => dest.Label, m => { m.MapFrom(jo => jo["Label"]); })
                .ForMember(dest => dest.ClaimDetail, m => { m.MapFrom(s => s.ResolveJson<List<ClaimDetail>>("Claims")); });
        }
    }
}
