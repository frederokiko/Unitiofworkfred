using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using NuGet.Protocol.Core.Types;
using System.Net;
using Unitiofworkfred.Entities;
using Unitiofworkfred.Interfaces;
using Unitiofworkfred.Models;
using Unitiofworkfred.Repositories;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Unitiofworkfred.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StageController : ControllerBase
    {


        //GET: api/<EnfantsStageController>
        private readonly IUnitOfWork _uow;
        public StageController(IUnitOfWork uow)
        {        
           _uow = uow;
        }
        //[HttpGet]
        //public IEnumerable<EnfantsModel> Get()
        //{
            
        //    return IEnumerable<EnfantsModel> ;

        //}

        // GET api/<EnfantsStageController>/5
        [HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}
        //public StageEntity GetOne(int id)
        //{
        //    //StageEntity item = StageRepository. GetOne(id);
        //    //if (item == null)
        //    //{
        //    //    throw new HttpResponseException(HttpStatusCode.NotFound);
        //    //}
        //    //return item;
        //}
        // POST api/<EnfantsStageController>
        [HttpPost]
        public void Post(StageModel e)
        {
            try
            {

                StageModel fm = new StageModel()
                {
                    Nomstage =e.Nomstage,
                };


                int ret = _uow.StageRepository.Add(Mappers.Mappers.MapModelStageToEntity(fm));
                if (ret > 0)
                {
                    _uow.Commit();
                }
                else
                {
                    _uow.Rollback();
                }
                return;
            }
            catch (Exception)
            {
                throw;
            }
        }
       

        // PUT api/<EnfantsStageController>/5
        [HttpPut("{id}")]
        public void Put([FromBody] string value)
        {
        }

        // DELETE api/<EnfantsStageController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
