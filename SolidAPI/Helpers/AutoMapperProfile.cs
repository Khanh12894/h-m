using AutoMapper;
using SolidAPI.Entities;
using SolidAPI.Models;

namespace SolidAPI.Helpers
{
    public class AutoMapperProfile:Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Buyer,BuyerModel>().ReverseMap();
        }
    }
}
