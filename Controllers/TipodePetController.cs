using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APIPets.Domains;
using APIPets.Repositories;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace APIPets.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TipodePetController : ControllerBase
    {

        TipoDePetRepository repo = new TipoDePetRepository();

        // GET: api/<TipodePetController>
        [HttpGet]
        public List<TipoDePet> Get()
        {
            return repo.ListarTodos();
        }

        // GET api/<TipodePetController>/5
        [HttpGet("{id}")]
        public TipoDePet Get(int id)
        {
            return repo.BuscarID(id);
        }

        // POST api/<TipodePetController>
        [HttpPost]
        public TipoDePet Post([FromBody] TipoDePet t)
        {
            return repo.Cadastrar(t);
        }

        // PUT api/<TipodePetController>/5
        [HttpPut("{id}")]
        public TipoDePet Put(int id, [FromBody] TipoDePet t)
        {
            return repo.Alterar(id, t);
        }

        // DELETE api/<TipodePetController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
