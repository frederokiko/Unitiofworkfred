using Microsoft.AspNetCore.Mvc;
using Unitiofworkfred.Interfaces;
using Unitiofworkfred.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Unitiofworkfred.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EnfantsController : ControllerBase
    {
        private readonly IUnitOfWork _uow;
        public EnfantsController(IUnitOfWork uow)
        {
            _uow = uow;
        }
        // GET: api/<EnfantsController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<EnfantsController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<EnfantsController>
        [HttpPost]
        public void Post(EnfantsModel e)
        {
            try
            {
                EnfantsModel cm = new EnfantsModel()
                {
                    Nom = e.Nom,
                    Prenom = e.Prenom,
                    Age = e.Age,
                };

                int reto = _uow.StageRepository.Add(Mappers.Mappers.MapModelEnfantToEntity(cm));
                if (reto > 0)
                {
                    _uow.Commit();
                }
                else
                {
                    _uow.Rollback();
                }
                return;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
      

        // PUT api/<EnfantsController>/5
        [HttpPut("{id}")]
        public void Put([FromBody] string value)
        {
        }

        // DELETE api/<EnfantsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
