using AutoMapper;
using Ecommece_DaNang.Entity;
using Ecommece_DaNang.Model;

namespace Ecommece_DaNang.Mapping
{
    public class Mapper :Profile
    {
        public Mapper()
        {
            CreateMap<Products, ProductModel>().ReverseMap();
            CreateMap<Products, AllProductModel>().ReverseMap();
            CreateMap<Products, CateProducts>()
            .ForMember(dest => dest.CateId, opt => opt.MapFrom(src => src.CateId));
            CreateMap<Users, LoginModel >().ReverseMap();
            CreateMap<Users, RegisterModel>().ReverseMap();
            CreateMap<Card, Updatequantity>().ReverseMap();
            CreateMap<ProductOption, ProductOptions>().ReverseMap();
            CreateMap<ImageProduct, ImageProducts>().ReverseMap();
            CreateMap<Products, AddProduct>().ReverseMap();
            CreateMap<ProductOption, UpdateProductOption>().ReverseMap();
               
            CreateMap<ImageProduct, AddImageProduct>().ReverseMap();
            CreateMap<Products, UpdateProduct>().ReverseMap();
            CreateMap<Products, HotProduct>().ReverseMap();
            CreateMap<Orders, OrderResponse>()
    .ForMember(dest => dest.Itemss, opt => opt.MapFrom(src => src.OrderDetails))
    .ReverseMap();

            CreateMap<OrderDetail, OrderDetailRespone>().ReverseMap();


        }
    }
}
