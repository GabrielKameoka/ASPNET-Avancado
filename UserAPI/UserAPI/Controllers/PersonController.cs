using Microsoft.AspNetCore.Mvc;
using UserAPI.Repository.Implementations;
using UserAPI.Repository.Interfaces;
using UserAPI.Services.Interfaces;

namespace UserAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PersonController : ControllerBase
{
    private IPersonService _personService;

    public PersonController(IPersonService personService)
    {
        _personService = personService;
    }

    [HttpGet("{id}")]
    public Person GetById(int id)
    {
        var person = _personService.GetById(id);
        return person;
    }

    [HttpGet]
    public IEnumerable<Person> Get()
    {
        return _personService.GetAll();
    }

    [HttpPost]
    public Person Create([FromBody]Person person)
    {
        return _personService.Create(person);
    }
    
    [HttpPut("{id}")]
    public Person Update(Person person)
    {
        return _personService.Update(person);
    }

    [HttpDelete("{id}")]
    public void Delete(int id)
    {
        _personService.Delete(id);
    }
} 