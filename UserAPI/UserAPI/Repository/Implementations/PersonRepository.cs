using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using UserAPI.Data;
using UserAPI.Repository.Interfaces;

namespace UserAPI.Repository.Implementations;

// repositório apenas para as operações CRUD
public class PersonRepository : IPersonRepository
{
    private readonly AppDbContext _context;

    public PersonRepository(AppDbContext context)
    {
        _context = context;
    }

    public Person GetById(int id)
    {
        var person = _context.Persons.SingleOrDefault(p => p.Id == id);
        return person;
    }

    public IEnumerable<Person> GetAll()
    {
        return _context.Persons;
    }

    public Person Create(Person person)
    {
        var newPerson = _context.Persons.Add(person);
        _context.SaveChanges();
        return newPerson.Entity;
    }

    public Person Update(Person person)
    {
        return _context.Update(person).Entity;
    }

    public void Delete(int id)
    {
        _context.Persons.Remove(GetById(id));
    }
}