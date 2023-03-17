using System.Data.SqlClient;
using Unitiofworkfred.Entities;
using Unitiofworkfred.Interfaces;

namespace Unitiofworkfred.Repositories
{
    internal class SuitStageRepositories : IRepository<SuitStageEntity, int>
      
    {
        private readonly SqlTransaction _transaction;

        public SuitStageRepositories(SqlTransaction transaction)
        {
            _transaction = transaction;

        }
        public int Add(SuitStageEntity entity)
        {
            try
            {

                SqlCommand ocmd = new SqlCommand
                {
                    Connection = _transaction.Connection,
                    Transaction = _transaction,
                    CommandText = "insert into Suit_stage (Id,Id_1) values (@Id,@Id_1)"
                };
                ocmd.Parameters.AddWithValue("Id", entity.Id);
                ocmd.Parameters.AddWithValue("Id_1", entity.Id_1);


                return (int)ocmd.ExecuteScalar();
            }
            catch (Exception)
            {
                return -1;
            }
        }

        public int Add(EnfantsEntity enfantsEntity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<StageEntity> GetAll()
        {
            throw new NotImplementedException();
        }

        public SuitStageEntity GetOne(int id)
        {


            //SqlCommand ocmd = new SqlCommand
            //{
            //    Connection = _transaction.Connection,
            //    Transaction = _transaction,
            //    CommandText = "SELECT (Id,Nom)  FROM Stage "
            //};

            //var result = ocmd.ExecuteReader();



            //return new SuitStageEntity();

            throw new NotImplementedException();

        }

        public void Update(SuitStageEntity entity)
        {
            throw new NotImplementedException();
        }

        IEnumerable<SuitStageEntity> IRepository<SuitStageEntity, int>.GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
