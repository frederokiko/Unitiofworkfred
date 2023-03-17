using Unitiofworkfred.Entities;

namespace Unitiofworkfred.Interfaces
{
    public interface IUnitOfWork
    {
        IRepository<EnfantsEntity, int> ClientRepository { get; }
        IRepository<StageEntity, int> StageRepository { get; }
        IRepository<SuitStageEntity, int> SuitStageRepository { get; }

        bool Commit();
        void Rollback();
    }
}
