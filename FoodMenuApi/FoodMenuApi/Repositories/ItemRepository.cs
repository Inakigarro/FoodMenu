using FoodMenuApi.Domain;
using Microsoft.EntityFrameworkCore;

namespace FoodMenuApi.Repositories;

public class ItemRepository : IItemRepository
{
    private ItemDbContext _dbContext;
    private ILogger<IItemRepository> _logger;

    public ItemRepository(
        ItemDbContext dbContext,
        ILogger<IItemRepository> logger)
    {
        _dbContext = dbContext;
        _logger = logger;
    }

    public async Task AddAsync(Item item)
    {
        _logger.LogInformation("[Item Repository] - Adding a new Item to database: {0}", item);
        await _dbContext.Items.AddAsync(item);
        await _dbContext.SaveChangesAsync();
    }

    public async Task UpdateAsync(Item item)
    {
        _dbContext.Items.Update(item);
        await _dbContext.SaveChangesAsync();
    }

    public async Task DeleteAsync(Item item)
    {
        _dbContext.Items.Remove(item);
        await _dbContext.SaveChangesAsync();
    }

    public async Task<IEnumerable<Item>> GetAllAsync()
    {
        return await _dbContext.Items.ToListAsync();

    }

    public async Task<Item?> GetAsync(Guid correlationId)
    {
        var item = await _dbContext.Items.FindAsync(correlationId);
        return item;
    }
}
