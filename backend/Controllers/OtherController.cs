using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using YourProject.Models;
using YourProject.Services;

namespace backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OtherController : ControllerBase
    {
        private readonly OtherService _otherService;

        public OtherController(OtherService otherService)
        {
            _otherService = otherService;
        }

        // GET: api/other
        [HttpGet]
        public ActionResult<IEnumerable<OtherModel>> GetItems()
        {
            var items = _otherService.GetAllItems();
            return Ok(items);
        }

        // GET: api/other/{id}
        [HttpGet("{id}")]
        public ActionResult<OtherModel> GetItem(int id)
        {
            var item = _otherService.GetItemById(id);
            if (item == null)
            {
                return NotFound();
            }
            return item;
        }

        // POST: api/other
        [HttpPost]
        public ActionResult<OtherModel> CreateItem(OtherModel item)
        {
            _otherService.AddItem(item);
            return CreatedAtAction(nameof(GetItem), new { id = item.Id }, item);
        }

        // PUT: api/other/{id}
        [HttpPut("{id}")]
        public IActionResult UpdateItem(int id, OtherModel item)
        {
            if (id != item.Id)
            {
                return BadRequest();
            }
            _otherService.UpdateItem(item);
            return NoContent();
        }

        // DELETE: api/other/{id}
        [HttpDelete("{id}")]
        public IActionResult DeleteItem(int id)
        {
            var item = _otherService.GetItemById(id);
            if (item == null)
            {
                return NotFound();
            }

            _otherService.DeleteItem(item);
            return NoContent();
        }
    }
}
