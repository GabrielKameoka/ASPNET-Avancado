using Microsoft.AspNetCore.Mvc;
using CalculadoraAPI.Services;

namespace CalculadoraAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class MathController : ControllerBase
{
    private readonly Operations _operations;
    
    public MathController(Operations operations)
    {
        _operations = operations;
    }
    
    [HttpGet("sum/{FirstNumber}/{SecondNumber}")]
    public IActionResult GetSum(string FirstNumber, string SecondNumber)
    { 
        var result = _operations.Sum(FirstNumber, SecondNumber);
        return Ok(result);
    }
    
    [HttpGet("substract/{FirstNumber}/{SecondNumber}")]
    public IActionResult GetSub(string FirstNumber, string SecondNumber)
    {
        var result = _operations.Substract(FirstNumber, SecondNumber);
        return Ok(result);
    }
    
    [HttpGet("multiply/{FirstNumber}/{SecondNumber}")]
    public IActionResult GetMult(string FirstNumber, string SecondNumber)
    {
        var result = _operations.Multiply(FirstNumber, SecondNumber);
        return Ok(result);
    }
    
    [HttpGet("divide/{FirstNumber}/{SecondNumber}")]
    public IActionResult GetDiv(string FirstNumber, string SecondNumber)
    {
        var result = _operations.Divide(FirstNumber, SecondNumber);
        return Ok(result);
    }
    
    [HttpGet("average/{FirstNumber}/{SecondNumber}")]
    public IActionResult GetAverage(string FirstNumber, string SecondNumber)
    {
        var result = _operations.Average(FirstNumber, SecondNumber);
        return Ok(result);
    }
}