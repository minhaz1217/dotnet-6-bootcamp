using WebApi_2022.Models;
using WebApi_2022.Repository;

namespace WebApi_2022.Services
{
    public class PizzaService
    {
        private readonly IPizzaRepository _pizzaRepository;
        public PizzaService(IPizzaRepository pizzaRepository)
        {
            _pizzaRepository = pizzaRepository;
        }

        public IList<Pizza> GetAll() 
        {
            return _pizzaRepository.GetAll();
        }


        public Pizza? Get(int id)
        {
            return _pizzaRepository.Get(id);
        }

        public void Create(Pizza pizza)
        {
            _pizzaRepository.Create(pizza);
        }

        public void Update(int id, Pizza pizza)
        {
            if(id != pizza.Id)
            {
                throw new ArgumentException("id didn't match with pizza id");
            }
            _pizzaRepository.Update(pizza);
            return;
        }

        public void Delete(int id)
        {
            _pizzaRepository.Delete(id);
        }
    }
}
