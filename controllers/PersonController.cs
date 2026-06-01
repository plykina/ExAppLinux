using ExApp.models;
using Microsoft.AspNetCore.Mvc;

namespace ExApp.controllers;

[Route("api/[controller]")]
[ApiController]
public class PersonController : ControllerBase
{
    private static List<Person> _persons = new List<Person>
    {
        new Person { Id = 1, Name = "John", Age = 30 },
        new Person { Id = 2, Name = "Jane", Age = 25 }
    };

    [HttpGet]
    public IActionResult GetAll()
    {
        return Ok(_persons);
    }

    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
        var person = _persons.FirstOrDefault(p => p.Id == id);
        if (person == null) return NotFound();
        return Ok(person);
    }
}