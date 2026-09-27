using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using service_4_dotnet.Data;
using service_4_dotnet.Models;

namespace service_4_dotnet.Controllers;

[Route("api/[controller]")]
[ApiController]
public class PersonsController : ControllerBase
{
    private readonly AppDbContext _context;

    public PersonsController(AppDbContext context)
    {
        _context = context;
    }

    // GET: api/persons (အားလုံးကို ယူရန်)
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Person>>> GetPersons()
    {
        return await _context.Persons.ToListAsync();
    }

    // GET: api/persons/1 (တစ်ယောက်တည်း ယူရန်)
    [HttpGet("{id}")]
    public async Task<ActionResult<Person>> GetPerson(int id)
    {
        var person = await _context.Persons.FindAsync(id);
        if (person == null) return NotFound();
        return person;
    }

    // POST: api/persons (အသစ်ထည့်ရန်)
    [HttpPost]
    public async Task<ActionResult<Person>> PostPerson(Person person)
    {
        _context.Persons.Add(person);
        await _context.SaveChangesAsync();
        return CreatedAtAction(nameof(GetPerson), new { id = person.Id }, person);
    }

    // PUT: api/persons/1 (ပြင်ရန်)
    [HttpPut("{id}")]
    public async Task<IActionResult> PutPerson(int id, Person person)
    {
        if (id != person.Id) return BadRequest();
        _context.Entry(person).State = EntityState.Modified;
        await _context.SaveChangesAsync();
        return NoContent();
    }

    // DELETE: api/persons/1 (ဖျက်ရန်)
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeletePerson(int id)
    {
        var person = await _context.Persons.FindAsync(id);
        if (person == null) return NotFound();
        _context.Persons.Remove(person);
        await _context.SaveChangesAsync();
        return NoContent();
    }
}