using AutoMapper;
using FoodMenuApi.Domain;
using FoodMenuApi.Dtos;
using FoodMenuApi.Repositories;

namespace FoodMenuApi.Services;

public class ItemService : IItemService
{
    private readonly IItemRepository _itemRepository;
    private readonly ILogger<ItemService> _logger;
    private readonly IMapper _mapper;

    public ItemService(
        IItemRepository itemRepository,
        ILogger<ItemService> logger,
        IMapper mapper)
    {
        _itemRepository = itemRepository;
        _logger = logger;
        _mapper = mapper;
    }

    public async Task<ItemDto> AddAsync(CreateItemDto item)
    {
        _logger.LogInformation("[Item Service] - Creating a new item with data: {0}", item);
        Item newItem = new Item();
        
        newItem.SetDisplayName(item.DisplayName);
        newItem.SetDescription(item.Description);
        newItem.SetPrice(item.Price);
        newItem.SetImagePath(item.ImagePath);

        await _itemRepository.AddAsync(newItem);

        return _mapper.Map<ItemDto>(newItem);
    }

    public async Task<ItemDto> UpdateAsync(UpdateItemDto item)
    {
        _logger.LogInformation("[Item Service] - Updating an item with data: {0}", item);
        var itemToUpdate = await _itemRepository.GetAsync(item.CorrelationId);

        if (itemToUpdate is null)
        {
            throw new InvalidOperationException($"There is no Item with id: {item.CorrelationId}");
        }

        itemToUpdate.SetDisplayName(item.DisplayName);
        itemToUpdate.SetDescription(item.Description);
        itemToUpdate.SetPrice(item.Price);
        itemToUpdate.SetImagePath(item.ImagePath);

        await _itemRepository.UpdateAsync(itemToUpdate);
        return _mapper.Map<ItemDto>(itemToUpdate);
    }

    public async Task DeleteAsync(Guid correlationId)
    {
        _logger.LogInformation("[Item Service] - Deleting item with id: {0}", correlationId);
        var itemToDelete = await _itemRepository.GetAsync(correlationId);

        if (itemToDelete is null)
        {
            throw new InvalidOperationException($"There is no Item with id: {correlationId}");
        }

        await _itemRepository.DeleteAsync(itemToDelete);
    }

    public async Task<IEnumerable<ItemDto>> GetAllAsync()
    {
        _logger.LogInformation("[Item Service] - Retrieving all the items.");
        var items = await _itemRepository.GetAllAsync();
        return _mapper.Map<IEnumerable<ItemDto>>(items);
    }

    public async Task<ItemDto> GetAsync(Guid correlationId)
    {
        _logger.LogInformation("[Item Service] - Retrieving the item with id: {0}", correlationId);
        var item = await _itemRepository.GetAsync(correlationId);

        if (item is null)
        {
            throw new InvalidOperationException($"There is no item with id: {correlationId}");
        }

        return _mapper.Map<ItemDto>(item);
    }
}
