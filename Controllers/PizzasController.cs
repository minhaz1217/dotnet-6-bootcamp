
using Microsoft.AspNetCore.Mvc;
using WebApi_2022.Models;
using WebApi_2022.Repository;
using WebApi_2022.Services;

namespace WebApi_2022.Controllers
{
    [Route("[controller]")]
    public class PizzasController : ControllerBase
    {

        private readonly PizzaService _pizzasService;
        private readonly IConfiguration _config;
        public PizzasController(IConfiguration config)
        {
            var pizzaRepository = new PizzaMySqlRepository();
            _pizzasService = new PizzaService(pizzaRepository);
            _config = config;
        }

        // named route
        // exception handling in api
        [HttpGet("read")]
        public IActionResult ReadKey()
        {
            return Ok(_config.GetValue<string>("MySQLConnectionString"));
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
            _pizzasService.Create(pizza);
            return Ok(_pizzasService.GetAll());
        }

        [HttpPut]
        public IActionResult Update(int id, [FromBody] Pizza pizza)
        {
            try
            {
                _pizzasService.Update(id, pizza);
                return Ok(_pizzasService.GetAll());
            }catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        [HttpDelete]
        public IActionResult Delete(int id)
        {
            _pizzasService.Delete(id);
            return Ok(_pizzasService.GetAll());
        }

    }
}
