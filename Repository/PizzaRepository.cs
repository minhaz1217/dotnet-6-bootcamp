using WebApi_2022.Models;
using WebApi_2022.Util;

namespace WebApi_2022.Repository
{
    public class PizzaRepository : IPizzaRepository
    {

        public PizzaRepository()
        {

        }

        public IList<Pizza> GetAll()
        {
            return  StaticDataStorage.Pizzas.ToList();
        }


        public Pizza? Get(int id)
        {
            var pizza = StaticDataStorage.Pizzas.FirstOrDefault(x => x.Id == id);
            if (pizza == null)
            {
                return null;
            }
            return pizza;
        }

        public void Create(Pizza pizza)
        {
            pizza.Id = StaticDataStorage.Pizzas.Count + 1;
            StaticDataStorage.Pizzas.Add(pizza);
        }

        public void Update(Pizza pizza)
        {
            var foundPizza = StaticDataStorage.Pizzas.FirstOrDefault(x => x.Id == pizza.Id);
            if (foundPizza == null)
            {
                return;
            }

            foundPizza.Name = pizza.Name;
            foundPizza.Price = pizza.Price;
            return;
        }

        public void Delete(int id)
        {
            var foundPizza = StaticDataStorage.Pizzas.FirstOrDefault(x => x.Id == id);
            if (foundPizza == null)
            {
                return;
            }
            StaticDataStorage.Pizzas.Remove(foundPizza);
        }

    }
}
