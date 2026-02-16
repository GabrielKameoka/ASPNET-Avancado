using Microsoft.AspNetCore.Mvc;
using UserAPI.Repository.Interfaces;
using UserAPI.Services.Interfaces;

namespace UserAPI.Services.Implamentations;

public class PersonService : IPersonService
{
    private readonly IPersonRepository _personRepository;
    public PersonService(IPersonRepository personRepository)
    {
        _personRepository = personRepository;
    }

    public Person GetById(int id)
    {
        try
        {
             return _personRepository.GetById(id);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
}

    public IEnumerable<Person> GetAll()
    {
        return _personRepository.GetAll();
    }

    public Person Create(Person person)
    {
        var newPerson = _personRepository.Create(person);
        return newPerson;
    }

    public Person Update(Person person)
    {
        throw new NotImplementedException();
    }

    public void Delete(int id)
    {
        throw new NotImplementedException();
    }
}