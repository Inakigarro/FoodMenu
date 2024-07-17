using FoodMenuApi.Domain;

namespace FoodMenuApi.Repositories;

public interface IItemRepository
{
    Task<Item?> GetAsync(Guid correlationId);

    Task<IEnumerable<Item>> GetAllAsync();

    Task AddAsync(Item item);

    Task UpdateAsync(Item item);

    Task DeleteAsync(Item item);
}
