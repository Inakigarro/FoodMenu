using FoodMenuApi.Dtos;

namespace FoodMenuApi.Services;

public interface IItemService
{
    Task<ItemDto> GetAsync(Guid correlationId);

    Task<IEnumerable<ItemDto>> GetAllAsync();

    Task<ItemDto> AddAsync(CreateItemDto item);

    Task<ItemDto> UpdateAsync(UpdateItemDto item);

    Task DeleteAsync(Guid correlationId);
}
