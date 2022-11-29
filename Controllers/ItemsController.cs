using Catalog.DTOs;
using Catalog.Entities;
using Catalog.Models;
using Catalog.Repositories;
using Microsoft.AspNetCore.DataProtection.Repositories;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Mvc;

namespace Catalog.Controllers
{

    // GET /items

    [ApiController] // Brings in a bunch default behaviors for controller class
    [Route("items")]

    public class ItemsController : ControllerBase
    {
        private readonly IItemModel model;

        public ItemsController(IItemModel model)
        {
            this.model = model;
        }

        // Get /items
        [HttpGet]
        public IEnumerable<ItemDTO> getItems()
        {
            var items = model.getItems().Select(item => item.asDTO());
            return items;
        }

        // GET /items/id
        [HttpGet("{id}")]
        public ActionResult<ItemDTO> getItem(int id)
        { // ActionResult allows us to return different types (error message or Item)
            Item item = model.getItem(id);

            if (item is null)
            {
                return NotFound(); // Returns 404 not found
            }

            return item.asDTO();
        }


        [HttpPost]
        public ActionResult<ItemDTO> createItem(CreateItemDTO itemDTO)
        {
            Item item = new()
            {
                //id = Guid.NewGuid(),
                name = itemDTO.name,
                price = itemDTO.price,
                createdDate = DateTimeOffset.UtcNow
            };

            model.createItem(item);

            return CreatedAtAction(nameof(getItem), new { id = item.id }, item.asDTO()); // Produces 201 item created status code //  nameof: variable name and changes it to a string on compilation
            //createdAtAction(string actionName, object routeValues, object values)
        }


        [HttpPut]
        public ActionResult updateItem(int id, UpdateItemDTO updateItemDTO)
        {
            Item existingItem = model.getItem(id);

            if (existingItem is null)
            {
                return NotFound();
            }

            if (updateItemDTO.name is null)
            {
                updateItemDTO.name = existingItem.name;
            }

            if (updateItemDTO.price == 0)
            {
                updateItemDTO.price = existingItem.price;
            }

            model.updateItem(existingItem, updateItemDTO);

            return NoContent(); // status 204 no content
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteItem(int id)
        {

            Item existingItem = model.getItem(id);

            if (existingItem is null)
            {
                return NotFound();
            }

            model.deleteItem(id);

            return NoContent(); // status 204 no content
        }

    }
}
