using Catalog.DTOs;
using Catalog.Entities;
using Catalog.Models;
using Microsoft.AspNetCore.DataProtection.Repositories;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Mvc;

namespace Catalog.Controllers {

  // GET /items

  [ApiController] // Brings in a bunch default behaviors for controller class
  [Route("items")]

  public class ItemsController : ControllerBase {
    private readonly IItemModel model;

  public ItemsController(IItemModel model) {
    this.model=model;
  }

// Get /items
  [HttpGet]
  public IEnumerable<ItemDTO> getItems(){
    var items = model.getItems().Select(item => item.asDTO());
    return items; 
  }

  // GET /items/id
  [HttpGet("{id}")]
  public ActionResult<ItemDTO> getItem(Guid id){ // ActionResult allows us to return different types (error message or Item)
    Item item = model.getItem(id).asDTO();

  if (item is null){
      return NotFound(); // Returns 404 not found
  }

    return item;
  }

  }
}
 