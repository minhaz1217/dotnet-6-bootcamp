
using Microsoft.AspNetCore.Mvc;
using WebApi_2022.Models;
using WebApi_2022.Services;

namespace WebApi_2022.Controllers
{
    [Route("[controller]")]
    public class PizzasController : ControllerBase
    {

        private readonly PizzaService _pizzasService;
        public PizzasController() 
        {
            _pizzasService = new PizzaService();
        }

        [HttpGet]
        public IEnumerable<Pizza> GetAll()
        {
            return _pizzasService.GetAll();
        }


        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var pizza = _pizzasService.Get(id);
            if (pizza == null)
            {
                return BadRequest();
            }
            return Ok(pizza);
        }

        [HttpPost]
        public IActionResult Create(Pizza pizza)
        {
            _pizzasService.Add(pizza);
            Console.WriteLine(pizza.Id);
            return Ok(_pizzasService.GetAll());
        }

    }
}
