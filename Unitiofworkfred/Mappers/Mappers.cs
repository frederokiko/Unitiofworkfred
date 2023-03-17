using Unitiofworkfred.Entities;
using Unitiofworkfred.Models;

namespace Unitiofworkfred.Mappers
{
    public static class Mappers
    {

        public static EnfantsModel MapEntityEnfantToModel(EnfantsEntity entity)
        {
            return new EnfantsModel()
            {
               
                Nom = entity.Nom,
                Prenom = entity.Prenom,
                Age = entity.Age,
            };
        }

        public static EnfantsEntity MapModelEnfantToEntity(EnfantsModel model)
        {
            return new EnfantsEntity()
            {
            
                Nom = model.Nom,
                Prenom = model.Prenom,
                Age = model.Age,
            };
        }

        public static StageModel MapEntityStageToModel(StageEntity entity)
        {
            return new StageModel()
            {
              
                Nomstage = entity.Nomstage,
               
            };
        }

        public static StageEntity MapModelStageToEntity(StageModel model)
        {
            return new StageEntity()
            {
             
                Nomstage=model.Nomstage,
              
            };
        }
        public static SuitStageModel MapEntitySuiteStageToModel(SuitStageEntity entity)
        {
            return new SuitStageModel()
            {

               Id= entity.Id,
               Id_1 = entity.Id,

            };
        }

        public static SuitStageEntity MapModelSuiteStageToEntity(SuitStageModel model)
        {
            return new SuitStageEntity()
            {

                Id = model.Id,
                Id_1 = model.Id,

            };
        }

        internal static StageEntity MapEntitySuiteStageToModel(SuitStageModel cm)
        {
            throw new NotImplementedException();
        }
    }
}
