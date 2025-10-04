using GerenciamentoAlunos.Data;
using GerenciamentoAlunos.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GerenciamentoAlunos.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AlunosController : ControllerBase
    {
        private readonly AppDbContext _context;

        public AlunosController(AppDbContext context)
        {
            _context = context;
        }

        // GET api/alunos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Aluno>>> Get()
        {
            return await _context.Alunos.ToListAsync();
        }

        // GET api/alunos/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<Aluno>> Get(int id)
        {
            var aluno = await _context.Alunos.FindAsync(id);
            if (aluno == null) return NotFound();
            return aluno;
        }

        // POST api/alunos
        [HttpPost]
        public async Task<ActionResult<Aluno>> Post(Aluno aluno)
        {
            _context.Alunos.Add(aluno);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(Get), new { id = aluno.Id }, aluno);
        }

        // PUT api/alunos/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, Aluno aluno)
        {
            if (id != aluno.Id) return BadRequest();
            _context.Entry(aluno).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return NoContent();
        }

        // DELETE api/alunos/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var aluno = await _context.Alunos.FindAsync(id);
            if (aluno == null) return NotFound();

            _context.Alunos.Remove(aluno);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}
