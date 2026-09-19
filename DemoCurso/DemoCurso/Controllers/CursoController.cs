using DemoCurso.Data;
using DemoCurso.Domain;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DemoCurso.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CursoController : ControllerBase
    {
        private readonly CursoRepository _repository;

        public CursoController(CursoRepository repository)
        {
            _repository = repository;
        }
        // GET: api/<CursoController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<CursoController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<CursoController>
        [HttpPost]
        public void Post([FromBody] Curso value)
        {
            _repository.Salvar(value);

        }

        // PUT api/<CursoController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CursoController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
