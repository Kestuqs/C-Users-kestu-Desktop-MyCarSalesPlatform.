using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyCarSalesPlatform.Core.Interfaces;
using MyCarSalesPlatform.Core.Models;

namespace MyCarSalesPlatform.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ListingsController : ControllerBase
    {
        private readonly IListingRepository _listingRepository;
        public ListingsController(IListingRepository listingRepository)
        {
            _listingRepository = listingRepository;
        }
        [HttpGet]

        public IActionResult Get() => Ok(_listingRepository.GetAll());

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var listing = _listingRepository.GetById(id);
            if (listing == null)
            {
                return NotFound();
            }
            return Ok(listing);
        }
        [HttpPost]
        public IActionResult Create([FromBody] Listing listing)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            _listingRepository.Add(listing);
            _listingRepository.Save();
            return CreatedAtAction(nameof(Get), new { id = listing.Id }, listing);
        }
        [HttpDelete("{id}")]

        public IActionResult Delete(int id)
        {
            var listing = _listingRepository.GetById(id);
            if (listing == null)
            {
                return NotFound();
            }
            _listingRepository.Delete(id);
            _listingRepository.Save();
            return Ok("Deleted");
        }
    }
}
