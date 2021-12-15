using WebApi_2022.Models;

namespace WebApi_2022.Repository
{
    public class PizzaMySqlRepository : IPizzaRepository
    {
        public void Create(Pizza pizza)
        {
            return;
        }

        public void Delete(int id)
        {
            return;
        }

        public Pizza? Get(int id)
        {
            return null;
        }

        public IList<Pizza> GetAll()
        {
            return new List<Pizza>();
        }

        public void Update(Pizza pizza)
        {
            return;
        }
    }
}
