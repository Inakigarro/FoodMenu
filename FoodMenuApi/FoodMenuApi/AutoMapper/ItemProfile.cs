using AutoMapper;
using FoodMenuApi.Domain;
using FoodMenuApi.Dtos;

namespace FoodMenuApi.AutoMapper;

public class ItemProfile : Profile
{
    public ItemProfile()
    {
        this.CreateMap<Item, ItemDto>()
            .ForMember(destination => destination.CorrelationId, opts => opts.MapFrom(source => source.CorrelationId))
            .ForMember(destination => destination.DisplayName, opts => opts.MapFrom(source => source.DisplayName))
            .ForMember(destination => destination.Description, opts => opts.MapFrom(source => source.Description))
            .ForMember(destination => destination.Price, opts => opts.MapFrom(source => source.Price))
            .ForMember(destination => destination.ImagePath, opts => opts.MapFrom(source => source.ImagePath));
    }
}
