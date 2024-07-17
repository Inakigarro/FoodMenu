using FoodMenuApi.Dtos;
using FoodMenuApi.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FoodMenuApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ItemsController : ControllerBase
{
    private readonly IItemService _itemService;
    private readonly ILogger<ItemsController> _logger;

    public ItemsController(
        IItemService itemService,
        ILogger<ItemsController> logger)
    {
        _itemService = itemService;
        _logger = logger;
    }

    [HttpPost("CreateItem")]
    public async Task<IActionResult> CreateItem(CreateItemDto itemToCreate)
    {
        try
        {
            _logger.LogInformation("[Item Controller] - Creating a new item with data: {0}", itemToCreate);
            var newItem = await _itemService.AddAsync(itemToCreate);
            return Ok(newItem);
        }
        catch (Exception ex) 
        {
            return BadRequest(ex);
        }
    }

    [HttpPut("UpdateItem")]
    public async Task<IActionResult> UpdateItem(UpdateItemDto itemToUpdate)
    {
        try
        {
            _logger.LogInformation("[Item Controller] - Updating an item with data: {0}", itemToUpdate);
            var itemUpdated = await _itemService.UpdateAsync(itemToUpdate);
            return Ok(itemUpdated);
        }
        catch (Exception ex)
        {
            return BadRequest(ex);
        }
    }

    [HttpGet("GetItemById")]
    public async Task<IActionResult> GetItemById(Guid correlationId)
    {
        try
        {
            _logger.LogInformation("[Item Controller] - Getting an item with Id: {0}", correlationId);
            var item = await _itemService.GetAsync(correlationId);
            return Ok(item);
        }
        catch (InvalidOperationException ex)
        {
            return BadRequest(ex);
        }
    }

    [HttpGet("GetAllItems")]
    public async Task<IActionResult> GetAllItems()
    {
        try
        {
            _logger.LogInformation("[Item Controller] - Getting all the items.");
            var items = await _itemService.GetAllAsync();
            return Ok(items);
        }
        catch (Exception ex)
        {
            return BadRequest(ex);
        }
        
    }

    [HttpDelete("DeleteItemById")]
    public async Task<IActionResult> DeleteItemById(Guid correlationId)
    {
        try
        {
            await _itemService.DeleteAsync(correlationId);
            return Ok();
        }
        catch (InvalidOperationException ex)
        {
            return NotFound(ex.Message);
        }
    }
}
