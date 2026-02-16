namespace UserAPI.Repository.Interfaces;

public interface IPersonRepository
{
    Person GetById(int id);
    IEnumerable<Person> GetAll();
    Person Create(Person person);
    Person Update(Person person);
    void Delete(int id);
}