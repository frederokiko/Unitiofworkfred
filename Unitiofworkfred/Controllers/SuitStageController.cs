using Microsoft.AspNetCore.Mvc;
using Unitiofworkfred.Interfaces;
using Unitiofworkfred.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Unitiofworkfred.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuitStageController : ControllerBase

    {
        private readonly IUnitOfWork _uow;
        public SuitStageController(IUnitOfWork uow)
        {
            _uow = uow;
        }
        // GET: api/<SuitStageController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<SuitStageController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<SuitStageController>
        [HttpPost]
        public void Post(SuitStageModel e)
        {
            try
            {
                SuitStageModel cm = new SuitStageModel()
                {
                   Id = e.Id,
                   Id_1=e.Id_1,
                };

                int reto = _uow.StageRepository.Add(Mappers.Mappers.MapEntitySuiteStageToModel( cm));
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

        // PUT api/<SuitStageController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<SuitStageController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
