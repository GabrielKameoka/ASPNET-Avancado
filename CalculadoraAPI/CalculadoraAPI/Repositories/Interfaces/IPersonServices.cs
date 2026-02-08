using CalculadoraAPI.Models;

namespace CalculadoraAPI.Repositories.Interfaces;

public interface IPersonServices
{
    Person GetById(int id);
    IEnumerable<Person> Get();
    Person Create(Person person);
    Person Update(Person person);
    void Delete(int id);
}