using AutoMapper;
using StoreTask.Core.Models;
using StoreTask.Razor.ViewModels;

namespace Demo.PL.helpers
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<ClientViewModel, Client>().ReverseMap();
            CreateMap<ProductViewModel, Product>().ReverseMap();
            CreateMap<ClientProductsViewModel, ClientProducts>().ReverseMap();
        }
    }
}
