using CalculadoraAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace CalculadoraAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UserController : ControllerBase
{
    private const string _apiKeyValida = "abc-123";

    private readonly List<User> _users = new()
    {
        new User { Id = 1, Nome = "Mitsuru" },
        new User { Id = 2, Nome = "Mitsuru" },
        new User { Id = 3, Nome = "Mitsuru" },
        new User { Id = 4, Nome = "Mitsuru" },
        new User { Id = 5, Nome = "Gabriella" },
        new User { Id = 6, Nome = "Kameoka" },
        new User { Id = 7, Nome = "Edson" },
        new User { Id = 8, Nome = "Francielle" },
        new User { Id = 9, Nome = "Mel" },
    };

    // ex: /api/user?nome={nome}
    [HttpGet]
    public IActionResult Get(
        [FromQuery] string nome,
        [FromQuery] int pagina = 1,
        [FromQuery] int tamanho = 3)
    {
        var LitaFiltrada = _users.Where(u => u.Nome.Contains(nome));
        return Ok(LitaFiltrada.Skip((pagina - 1) * tamanho).Take(tamanho));
    }

    // ex: /api/user/23
    [HttpGet("{id}")] // define a estrutura da URL (Pattern da URL)
    public IActionResult Get([FromRoute] int id) // especifica de onde vem o valor vem
    {
        var user = _users.FirstOrDefault(u => u.Id == id);
        return Ok(user);
    }

    // ex: /api/user
    [HttpPost]
    public IActionResult Post([FromBody] User user)
    {
        _users.Add(user); // obviamente você usaria um ORM para essa ação
        return Ok(user); // + regra de negócios
    }

    [HttpGet]
    public IActionResult CheckAccess([FromHeader(Name = "X-Api-Key")] string apiKey)
    {
        if (apiKey != "12345") return Unauthorized(); //simulação da validação
        return Ok("Acesso autorizado!");
    }
}