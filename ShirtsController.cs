using Microsoft.AspNetCore.Mvc;
using WebAPI.Filters;
using WebAPI.Filters.ActionFilters;
using WebAPI.Filters.ExceptionFilters;
using WebAPI.Models;
using WebAPI.Models.Repositories;

namespace WebAPI.Controllers

{
    [ApiController]
    [Route("api/[controller]")]
    public class ShirtsController : ControllerBase
    {


        [HttpGet]
        public IActionResult GetShirts()
        {
            return Ok(ShirtRepository.GetShirts());
        }
        [HttpGet("{id}")]

        [Shirt_ValidateShirtIdFilter]
        public IActionResult GetShirtById(int id)
        {
            return Ok(ShirtRepository.GetShirtById(id));
        }
        [HttpPost]
        [Shirt_ValidateCreateShirtFilter]
        public IActionResult CreateShirt([FromBody]Shirt shirt)
        {

            return CreatedAtAction(nameof(GetShirtById),
                new { id = shirt.ShirtId },
                shirt);
        }

        private IActionResult CreatedAtAction()
        {
            throw new NotImplementedException();
        }

        [HttpPut("{id}")]
        [Shirt_ValidateShirtIdFilter]
        [Shirt_ValidateUpdateShirtFilter]
        [Shirt_HandleUpdateExceptionsFilter]
        public IActionResult UpdateShirt(int id, Shirt shirt)
        {

            ShirtRepository.UpdateShirt(shirt);

            return NoContent();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteShirtById(int id)
        {
            return Ok($"Deleting shirts with ID: {id}");
        }
    }
}





//Api
//{
//    [ApiController]
//    public class ShirtsController: ControllerBase
//    {

//        [HttpGet]
//        [Route("/shirts")]
//        public string GetShirts()
//        {
//            return "Reading all the shirts";
//        }
//        [HttpGet]
//        [Route("/shirts/{id}")]
//        public string GetShirtById(int id)
//        {
//            return $"Reading Shirts with ID: {id}";
//        }
//        [HttpPost]
//        [Route("/shirts")]
//        public string CreateShirt()
//        {
//            return "Creating a new shirt";
//        }
//        [HttpPut]
//        [Route("/shirts/{id}")]
//        public string UpdateShirt(int id)
//        {
//            return $"Updating shirt with ID: {id}";
//        }
//        [HttpDelete]
//        [Route("/shirts/{id}")]
//        public string DeleteShirt(int id)
//        {
//            return $"Deleting shirts with ID: {id}";
//        }
// other way to create apis 