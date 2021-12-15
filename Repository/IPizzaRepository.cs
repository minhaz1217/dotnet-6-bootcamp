using WebApi_2022.Models;

namespace WebApi_2022.Repository
{
    public interface IPizzaRepository
    {
        IList<Pizza> GetAll();
        Pizza? Get(int id);
        void Create(Pizza pizza);
        void Update(Pizza pizza);
        void Delete(int id);
    }
}
