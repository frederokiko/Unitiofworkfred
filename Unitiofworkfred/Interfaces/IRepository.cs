using Unitiofworkfred.Entities;

namespace Unitiofworkfred.Interfaces
{
    public interface IRepository<T, TKey>
        where T : class
    {
        T GetOne(TKey id);
        IEnumerable<T> GetAll();

        TKey Add(T entity);
        void Update(T entity);
        void Delete(TKey id);
        int Add(EnfantsEntity enfantsEntity);
        int Add(SuitStageEntity suitStageEntity);
    }
}
