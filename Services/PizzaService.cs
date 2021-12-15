using WebApi_2022.Models;

namespace WebApi_2022.Services
{
    public class PizzaService
    {
        private IList<Pizza> Pizzas { get; }

        public PizzaService() 
        {
            Pizzas = new List<Pizza>();
            for (int i = 0; i < 5; i++) 
            {
                Pizzas.Add(new Pizza
                {
                    Id = i + 1,
                    Name = "Pizza " + i,
                    Price = (i + 1) * 100
                });
            }
        }

        public IList<Pizza> GetAll() 
        {
            return Pizzas.ToList();
        }


        public Pizza Get(int id)
        {
            var pizza = Pizzas.FirstOrDefault(x => x.Id == id);
            if(pizza == null)
            {
                return null;
            }
            return pizza;
        }

        public void Add(Pizza pizza)
        {
            pizza.Id = Pizzas.Count + 1;
            Pizzas.Add(pizza);
        }

        public void Update(int id, Pizza pizza)
        {
            var foundPizza = Pizzas.FirstOrDefault(x => x.Id == id);
            if(foundPizza == null)
            {
                return;
            }

            foundPizza.Name = pizza.Name;
            foundPizza.Price = pizza.Price;
            return;
        }

        public void Delete(int id)
        {
            var foundPizza = Pizzas.FirstOrDefault(x => x.Id == id);
            if(foundPizza == null)
            {
                return;
            }
            Pizzas.Remove(foundPizza);
        }
        

    }
}
